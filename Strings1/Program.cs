namespace Strings1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Gib einen Text ein: ");
        string input = Console.ReadLine();
        AnalyseString(input);
    }

    static void AnalyseString(string s)
    {
        string vokale = "aeiou";
        string konsonanten = "bcdfghjklmnpqrstvwxyz";
        string umlaute = "äöüß";
        string ziffern = "0123456789";

        int countVokale = 0;
        int countKonsonanten = 0;
        int countUmlaute = 0;
        int countZiffern = 0;
        int countSonstiges = 0;

        foreach (char c in s.ToLower())
        {
            if (vokale.Contains(c))
                countVokale++;
            else if (konsonanten.Contains(c))
                countKonsonanten++;
            else if (umlaute.Contains(c))
                countUmlaute++;
            else if (ziffern.Contains(c))
                countZiffern++;
            else
                countSonstiges++;
        }

        Console.WriteLine($"Vokale: {countVokale}");
        Console.WriteLine($"Konsonanten: {countKonsonanten}");
        Console.WriteLine($"Umlaute/ß: {countUmlaute}");
        Console.WriteLine($"Ziffern: {countZiffern}");
        Console.WriteLine($"Sonstige Zeichen: {countSonstiges}");
    }
}