namespace Aufgabe1;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Gültiges Datum
                Date date1 = new Date(23, 4, 2025);
                Console.WriteLine("Datum 1: " + date1);
                Console.WriteLine("Wochentag: " + date1.GetWeekday());

               
                Date date2 = new Date(60, 2024); // 2024 ist ein Schaltjahr
                Console.WriteLine("Datum 2: " + date2);
                Console.WriteLine("Wochentag: " + date2.GetWeekday());

                // Gleichheit prüfen
                Console.WriteLine("date1.Equals(date2)? " + date1.Equals(date2));

                // Tomorrow()
                Date tomorrow = date1.Tomorrow();
                Console.WriteLine("Morgen: " + tomorrow);

                // Yesterday()
                Console.Write("Gestern: ");
                date1.Yesterday(); // verändert date1
                Console.WriteLine(date1);

                // Fehlerhafte Eingabe 
                Date invalid = new Date(31, 2, 1700);
            }
            catch (InvalidDateException ex)
            {
                Console.WriteLine("Ungültiges Datum: " + ex.Message);
            }
            catch (DateOutOfRangeException ex)
            {
                Console.WriteLine("Jahr außerhalb des gültigen Bereichs: " + ex.Message);
            }
        }
    }
