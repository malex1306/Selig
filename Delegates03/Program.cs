namespace DelegatesArrayFilter;

    class Program
    {
        public static void ShowFilteredValues(string[] values, Func<string, bool> filter)
        {
            foreach (string item in values)
            {
                if (filter(item))
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
        }
        
        public static bool IsUpperCase(string value)
        {
            return !string.IsNullOrEmpty(value) && value == value.ToUpper();
        }

        static void Main(string[] args)
        {
            
            string[] values = [
                "HELLO",
                "World",
                "abcdef",
                "AXE",
                "xylophon",
                "Achtung",
                "MIXED",
                "YOLO",
                "axt",
                "x",
                "kurz",
                "toolongword"
            ];

            Console.WriteLine("Nur Großbuchstaben (IsUpperCase):");
            ShowFilteredValues(values, IsUpperCase);

           
            Console.WriteLine("Nur Großbuchstaben (Lambda):");
            ShowFilteredValues(values, value => !string.IsNullOrEmpty(value) && value == value.ToUpper());

            
            Console.WriteLine("Strings, die mit 'A' anfangen:");
            ShowFilteredValues(values, value => value.StartsWith('A'));

            Console.WriteLine("Strings mit mehr als 5 Zeichen:");
            ShowFilteredValues(values, value => value.Length > 5);

            Console.WriteLine("Strings mit einem 'x':");
            ShowFilteredValues(values, value => value.Contains('x'));

            Console.WriteLine("Strings > 2 und < 7 Zeichen:");
            ShowFilteredValues(values, value => value.Length > 2 && value.Length < 7);

            Console.WriteLine("Strings mit einem 'a' und > 5 Zeichen:");
            ShowFilteredValues(values, value => value.Contains('a') && value.Length > 5);
        }
    }

