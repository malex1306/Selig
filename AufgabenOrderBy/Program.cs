namespace AufgabenOrderBy;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5,4,1,3,9,8,6,7,2,0,22,12,16,18,11,19,13 };

        Console.WriteLine("Aufgabe 1a");
        var sorted = numbers
            .OrderBy(number => number);
        foreach (var number in sorted)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        Console.WriteLine("Aufgabe 1b");

        var UpSorted = numbers
            .OrderByDescending(n => n);
        foreach (var number in UpSorted)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        Console.WriteLine("Aufgabe 1c");
        
        var evenOrderBy = numbers
            .Where(n => n % 2 == 0)
            .OrderBy(n => n);
        foreach (var number in evenOrderBy)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        Console.WriteLine("Aufgabe 1d");
        var between = numbers
            .Where(n => n >= 5 && n <= 11)
            .OrderByDescending(n => n);
        foreach (var number in between)
        {
            Console.WriteLine(number);
        }
        
        string[] numbers2 = { "zero", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen" };
        
        Console.WriteLine("Aufgabe 2a");

        var stringLength = numbers2
            .OrderBy(n => n.Length)
            .ThenBy(n => n);
        foreach (var number in stringLength)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
        Console.WriteLine("Aufgabe 2b");

        var stringLength2 = numbers2
            .OrderBy(n => n.Length)
            .ThenByDescending(n => n);
        foreach (var number in stringLength2)
        {
            Console.WriteLine(number);
        }
        
        Console.WriteLine();
        Console.WriteLine("Aufgabe 2c");

        var stringReverse = numbers2
            .Reverse();
        foreach (var number in stringReverse)
        {
            Console.WriteLine(number);
        }
        
        Console.WriteLine();
        Console.WriteLine("Aufgabe 2d");

        var sortedSameChar = numbers2
            .OrderBy(n => n[0])
            .ThenByDescending(n => n[^1]);
            

        foreach (var number in sortedSameChar)
        {
            Console.WriteLine(number);
        }
    }
}