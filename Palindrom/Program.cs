namespace Palindrom;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Gib ein Wort ein: ");
        string input = Console.ReadLine();

        if (IsPalindrom(input))
            Console.WriteLine("Das ist ein Palindrom!");
        else
            Console.WriteLine("Das ist kein Palindrom.");
    }

    static bool IsPalindrom(string s)
    {
        
        string clean = s.Replace(" ", "").ToLower();//ignoriert Leerzeichen

        
        char[] arr = clean.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        return clean == reversed;
    }
}