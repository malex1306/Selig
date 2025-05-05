namespace ExtensionMethods01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aufgabe a");
        string text = "Hello World!";
        string result = text.Left(5);
        Console.WriteLine(result);
        Console.WriteLine("Aufgabe b");
        string textRight = "Hello World!";
        string resultRight = textRight.Right(6);
        Console.WriteLine(resultRight);
        Console.WriteLine("Aufgabe c");
        int zahl = 42;
        Console.WriteLine(zahl.IsEven()); 
        Console.WriteLine(zahl.IsOdd());
        Console.WriteLine("Aufgabe d");
        Console.WriteLine("Anna".Palindrome());
        Console.WriteLine("Karl".Palindrome());
        Console.WriteLine("Aufgabe e");
        string text1 = "hi!";
        Console.WriteLine(text1.ContainsDuplicateChars());          
        Console.WriteLine("abcabc".RemoveDuplicateChars());       
        Console.WriteLine("hallo,welt.programm".Capitalize(new char[] { '.', ',' }));  
    }
    }
    
//Aufgabe a
public static class StringExtensions
{
    public static string Left(this string input, int n)
    {
        if (string.IsNullOrEmpty(input)) return input;
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "Wert darf nicht negativ sein.");
        if (n >= input.Length) return input;
        return input.Substring(0, n);
    }
}

//Aufgabe b
public static class StringExtensionsRight
{
    public static string Right(this string input, int n)
    {
        if (string.IsNullOrEmpty(input)) return input;
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "Wert darf nicht negativ sein.");
        if (n >= input.Length) return input;
        return input.Substring(input.Length - n, n);
    }
}

//Aufgabe c
public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }
}

//Aufgabe d
public static class StringExtensionsPalindrome
{
    public static bool Palindrome(this string s)
    {
        string clean = s.Replace(" ", "").ToLower(); 

        char[] arr = clean.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        return clean == reversed;
    }
}

//Aufgabe e
public static class StringExtensionsDuplicate
{
    public static bool ContainsDuplicateChars(this string s)
    {
        HashSet<char> seen = new HashSet<char>();
        foreach (char c in s)
        {
            if (seen.Contains(c))
                return true;
            seen.Add(c);
        }
        return false;
    }
}
public static class StringExtensionsRemove
{
    public static string RemoveDuplicateChars(this string s)
    {
        HashSet<char> seen = new HashSet<char>();
        List<char> result = new List<char>();
        foreach (char c in s)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                result.Add(c);
            }
        }
        return new string(result.ToArray());
    }
}
public static class StringExtensionsCapitalize
{
    public static string Capitalize(this string s, char[] chars)
    {
        if (string.IsNullOrEmpty(s)) return s;

        char[] result = s.ToLower().ToCharArray();
        bool capitalizeNext = true;

        for (int i = 0; i < result.Length; i++)
        {
            if (capitalizeNext && char.IsLetter(result[i]))
            {
                result[i] = char.ToUpper(result[i]);
                capitalizeNext = false;
            }

            if (chars.Contains(result[i]))
                capitalizeNext = true;
        }

        return new string(result);
    }
}
