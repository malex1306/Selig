namespace Filter;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5,4,1,3,9,8,6,7,2,0,22,12,16,18,11,19,13 };

        Console.WriteLine("-----1a-----");
        var smaller = numbers
            .Where(n => n < 7).OrderByDescending(n => n);
        foreach (var number in smaller)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("-----1b-----");
        
        var even = numbers.Where(n => n % 2 == 0);
        foreach (var number in even)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("------1c-----");
        
        var oneInt = numbers.Where(n => n % 2 != 0 && n >= 0 && n < 10);
        foreach (var number in oneInt)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("-----1d------");
        var element = numbers
            .Skip(5)
            .Where(n => n % 2 == 0);
        foreach (var number in element)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("-----1e------");
        var noRest =
            numbers.Where(number => number % 2 == 0 || number % 3 == 0);
        foreach (var number in noRest)
        {
            Console.WriteLine(number);
        }
        
        string[] numbers2 = [ "zero", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen" ];
        
        Console.WriteLine("-----2a-----");
        var stringLength = numbers2
            .Where(numbers2 => numbers2.Length == 3);
        foreach (var number in stringLength)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("-----2b-----");
        var oInside = numbers2
            .Where(numbersO => numbersO.ToLower().Contains("o"));
        foreach (var number in oInside)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("-----2c------");
        var endOfTeen = numbers2
            .Where(numbers1 => numbers1.EndsWith("teen"));
        foreach (var number in endOfTeen)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("------2d------");
        var endOfTeenBig = numbers2
            .Where(numbers3 => numbers3.EndsWith("teen"))
            .Select(n => n.ToUpper());
        foreach (var number in endOfTeenBig)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("-----2e------");
        var fourInside = numbers2
            .Where(numbers4 => numbers4
                .Contains("four"));
        foreach (var number in fourInside)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("------2f------");
        var Begin = numbers2
            .Where(numbers5 => !numbers5
                .StartsWith("t") && !numbers5
                .StartsWith("f"));
        foreach (var number in Begin)
        {
            Console.WriteLine(number);
        }
    }
}