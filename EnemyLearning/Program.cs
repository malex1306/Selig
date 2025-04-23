using Microsoft.ML;
using Microsoft.ML.Data;

namespace EnemyLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            // MLContext initialisieren
            var context = new MLContext();

            // 1. Daten aus CSV laden
            var data = context.Data.LoadFromTextFile<GameState>(
                path: "../../../data.csv",
                separatorChar: ',',
                hasHeader: true
            );

            // 2. Daten-Pipeline erstellen
            var pipeline = context.Transforms.Conversion.MapValueToKey(
                    outputColumnName: "Label",
                    inputColumnName: nameof(GameState.Action)
                )
                // Konvertiere PlayerVisible (bool) zu float (1.0/0.0)
                .Append(context.Transforms.CustomMapping<GameState, ConvertedGameState>(
                    (input, output) => output.PlayerVisibleFloat = input.PlayerVisible ? 1f : 0f,
                    contractName: "ConvertPlayerVisible")
                )
                // Features kombinieren (alle müssen float sein)
                .Append(context.Transforms.Concatenate(
                    outputColumnName: "Features",
                    "PlayerVisibleFloat",
                    nameof(GameState.Health),
                    nameof(GameState.DistanceToPlayer)
                ))
                // Algorithmus für Klassifizierung
                .Append(context.MulticlassClassification.Trainers.SdcaMaximumEntropy(
                    labelColumnName: "Label",
                    featureColumnName: "Features"
                ))
                // Vorhergesagte Aktion zurück in String umwandeln
                .Append(context.Transforms.Conversion.MapKeyToValue(
                    outputColumnName: "PredictedLabel",
                    inputColumnName: "PredictedLabel"
                ));

            // 3. Daten in Trainings- und Testsets aufteilen
            var splitData = context.Data.TrainTestSplit(data, testFraction: 0.2);
            var trainData = splitData.TrainSet;
            var testData = splitData.TestSet;

            // 4. Modell trainieren
            var model = pipeline.Fit(trainData);

            // 5. Modell evaluieren
            var predictions = model.Transform(testData);
            var metrics = context.MulticlassClassification.Evaluate(predictions);

            Console.WriteLine($"Modell-Genauigkeit: {metrics.MacroAccuracy:P2}");
            Console.WriteLine($"Log-Loss: {metrics.LogLoss}\n");

            // 6. Vorhersage-Engine erstellen
            var predictionEngine = context.Model.CreatePredictionEngine<GameState, GameActionPrediction>(model);

            // 7. Test-Vorhersagen machen
            var testCases = new[]
            {
                new GameState { PlayerVisible = true, Health = 80, DistanceToPlayer = 5 },
                new GameState { PlayerVisible = false, Health = 100, DistanceToPlayer = 15 },
                new GameState { PlayerVisible = true, Health = 20, DistanceToPlayer = 1 },
                new GameState { PlayerVisible = true, Health = 70, DistanceToPlayer = 7 }
            };

            foreach (var testCase in testCases)
            {
                var prediction = predictionEngine.Predict(testCase);
                Console.WriteLine($"Spieler sichtbar: {testCase.PlayerVisible}, " +
                                  $"Gesundheit: {testCase.Health}, " +
                                  $"Distanz: {testCase.DistanceToPlayer} => " +
                                  $"Vorhersage: {prediction.Action}");
            }
        }
    }

    // Klassen für Datenhaltung
    public class GameState
    {
        [LoadColumn(0)]
        public bool PlayerVisible { get; set; }

        [LoadColumn(1)]
        public float Health { get; set; }

        [LoadColumn(2)]
        public float DistanceToPlayer { get; set; }

        [LoadColumn(3)]
        public string Action { get; set; }
    }

    public class ConvertedGameState : GameState
    {
        public float PlayerVisibleFloat { get; set; }
    }

    public class GameActionPrediction
    {
        [ColumnName("PredictedLabel")]
        public string Action { get; set; }
    }
}