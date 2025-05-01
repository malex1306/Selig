namespace Baumarkt;

    class Program
    {
        static void Main(string[] args)
        {
            string liste = "0123; Hammer, Dübel, Nägel\n"
                           + "4711; Kantholz, Säge, Nägel, Leim\n"
                           + "8698; Schrauben, Dübel, Hänge-WC\n"
                           + "9876; Fischfutter, Hammer, Säge\n"
                           + "4862; Kantholz, Säge\n"
                           + "3179; Schrauben, Schraubenzieher, Dübel\n"
                           + "7410; Leim, Fischfutter\n"
                           + "8520; Hänge-WC, Nägel, Säge";

            var kundenDaten = liste
                .Split('\n')
                .Select(zeile => zeile.Split(';'))
                .ToDictionary(
                    teile => teile[0].Trim(),
                    teile => teile[1].Split(',').Select(a => a.Trim()).ToList()
                );

           
            void ViewByCustomerID()
            {
                foreach (var kundenummer in kundenDaten)
                {
                    Console.WriteLine($"Kundennummer: {kundenummer.Key}");
                    foreach (var artikel in kundenummer.Value)
                    {
                        Console.WriteLine("-  " + artikel);
                    }
                }
            }

           
           void ViewByArticle()
            {
                
                Dictionary<string, List<string>> artikelDaten = new Dictionary<string, List<string>>();

                foreach (var eintrag in kundenDaten)
                {
                    string kundennummer = eintrag.Key;
                    foreach (string artikel in eintrag.Value)
                    {
                        if (!artikelDaten.ContainsKey(artikel))
                        {
                            artikelDaten[artikel] = new List<string>();
                        }
                        artikelDaten[artikel].Add(kundennummer);
                    }
                }

               
                foreach (var eintrag in artikelDaten)
                {
                    Console.WriteLine($"Artikel: {eintrag.Key}");
                    foreach (string kundennummer in eintrag.Value)
                    {
                        Console.WriteLine($"- {kundennummer}");
                    }
                }
            }

            
            ViewByCustomerID();
            Console.WriteLine("\n-------------------------\n");
            ViewByArticle();
        }
    }

