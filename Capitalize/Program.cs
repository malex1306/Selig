namespace Capitalize;

class Program
{
    static void Main(string[] args)
    {
        char[] chars = new char[] { ' ', '-' };
        Console.WriteLine(Capitalize("c#-prOfi", chars));       
        Console.WriteLine(Capitalize("heLlo-world again", chars)); 

    }
    
    static string Capitalize(string s, char[] separators)
    {
        if (string.IsNullOrEmpty(s)) return s;

        var result = new List<char>();
        bool capitalizeNext = true;

        foreach (char c in s)
        {
            if (capitalizeNext && char.IsLetter(c))
            {
                result.Add(char.ToUpper(c));
                capitalizeNext = false;
            }
            else
            {
                result.Add(char.ToLower(c));
                capitalizeNext = separators.Contains(c);
            }
        }

        return new string(result.ToArray());
    }

}