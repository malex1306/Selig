namespace RemoveDuplicates;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(RemoveDuplicateChars("Otto")); 
        Console.WriteLine(RemoveDuplicateChars("Michael"));  
    }

    static string RemoveDuplicateChars(string s)
    {
        var seen = new HashSet<char>();
        var result = "";
        foreach (char c in s)
        {
            if (!seen.Remove(c))
            {
                result += c;
                seen.Add(c);
            }
        }
        return result;
    }
}