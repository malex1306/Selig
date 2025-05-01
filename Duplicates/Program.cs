namespace Duplicates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ContainsDuplicateChars("Hallo"));
        Console.WriteLine(ContainsDuplicateChars("Hey"));
    }

    static bool ContainsDuplicateChars(string s)
    {
        var seen = new HashSet<char>();
        foreach (char c in s)
        {
            if (seen.Contains(c)) return true;
            seen.Add(c);
        }
        return false;
    }
}