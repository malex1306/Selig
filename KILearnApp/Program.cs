using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KILearnApp
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine(" Gib ein Thema ein: ");
            string thema = Console.ReadLine();

            var frageUndAntworten = await FrageAnKI(thema);

            Console.WriteLine("\n Multiple-Choice-Frage:");
            Console.WriteLine(frageUndAntworten.Frage);
            Console.WriteLine("A. " + frageUndAntworten.Antworten[0]);
            Console.WriteLine("B. " + frageUndAntworten.Antworten[1]);
            Console.WriteLine("C. " + frageUndAntworten.Antworten[2]);
            Console.WriteLine("D. " + frageUndAntworten.Antworten[3]);

            Console.WriteLine("\nWelche Antwort ist richtig? (A, B, C oder D)");
            string benutzerAntwort = Console.ReadLine()?.Trim().ToUpper();

            if (benutzerAntwort == frageUndAntworten.RichtigeAntwort)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Richtig!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Falsch! Die richtige Antwort war: {frageUndAntworten.RichtigeAntwort}");
            }
            Console.ResetColor();
        }

        static async Task<MCQResult> FrageAnKI(string thema)
        {
            var apiKey = ""; 
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            client.DefaultRequestHeaders.Add("HTTP-Referer", "https://deine-app.com");
            client.DefaultRequestHeaders.Add("X-Title", "KILearnApp");

            var inhalt = new
            {
                model = "openai/gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "system", content = "Du bist ein hilfreicher Lernassistent." },
                    new
                    {
                        role = "user",
                        content = $"Erstelle eine Multiple-Choice-Frage zum Thema '{thema}', mit einer richtigen Antwort (gekennzeichnet mit einem * am Ende) und drei falschen. Format: Frage, dann A. B. C. D."
                    }
                }
            };

            var json = JsonSerializer.Serialize(inhalt);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://openrouter.ai/api/v1/chat/completions", content);
            var responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine("\n Hier die erste Frage:");
            Console.WriteLine(responseBody);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($" Fehler: {response.StatusCode}");
                return new MCQResult { Frage = "Fehler beim Abrufen.", Antworten = Array.Empty<string>(), RichtigeAntwort = "" };
            }

            using var doc = JsonDocument.Parse(responseBody);
            var antwort = doc.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();

            return ParseFrageUndAntworten(antwort);
        }

        static MCQResult ParseFrageUndAntworten(string antwort)
        {
            var lines = antwort.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            string frage = lines[0].Trim();
            var antworten = new string[4];
            string richtigeAntwort = "";

            for (int i = 0; i < 4 && i + 1 < lines.Length; i++)
            {
                var line = lines[i + 1].Trim();
                var prefix = line.Substring(0, 1); 
                var text = line.Substring(3).Trim();

                if (text.EndsWith("*"))
                {
                    text = text.TrimEnd('*').Trim();
                    richtigeAntwort = prefix;
                }

                antworten[i] = text;
            }

            return new MCQResult
            {
                Frage = frage,
                Antworten = antworten,
                RichtigeAntwort = richtigeAntwort
            };
        }
    }

    public class MCQResult
    {
        public string Frage { get; set; }
        public string[] Antworten { get; set; }
        public string RichtigeAntwort { get; set; }
    }
}
