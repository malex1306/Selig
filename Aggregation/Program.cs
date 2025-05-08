namespace Aggregation;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5,4,1,3,9,8,6,7,2,0,22,12,16,18,11,19,13 };

        Console.WriteLine("Aufgabe 1a)");

        var SumOf = numbers
            .Sum();
        Console.WriteLine(SumOf);
        Console.WriteLine();
        var Test = numbers
            .Aggregate((sum, next) => sum + next);
        Console.WriteLine(Test);
        Console.WriteLine(numbers
            .Aggregate(0, (sum, next) => sum + next));
        Console.WriteLine("Aufgabe 1b)");
        
        var MinNumber = numbers.Min();
        Console.WriteLine(MinNumber);
        Console.WriteLine();
        Console.WriteLine(numbers
            .Aggregate((a, b) => a < b ? a : b));
        Console.WriteLine("Aufgabe 1c)");
        
        var MaxNumber = numbers.Max();
        Console.WriteLine(MaxNumber);
        Console.WriteLine();
        Console.WriteLine(numbers
            .Aggregate((a, b) => a > b ? a : b));
        Console.WriteLine("Aufgabe 1d)");
        
        var Average = numbers.Average();
        Console.WriteLine(Average);
        Console.WriteLine();
        Console.WriteLine(numbers
            .Aggregate((a, b) => a + b) / (double)numbers.Length);
        Console.WriteLine(numbers.Aggregate(
            0, (a, b) => a + b,
            a => a / (double)numbers.Length));
        Console.WriteLine("Aufgabe 1e)");
        
        var SmallEvenNumber = numbers
            .Where(n => n % 2 == 0)
            .Min();
        Console.WriteLine(SmallEvenNumber);
        Console.WriteLine();
        Console.WriteLine(numbers
            .Aggregate((a, next) => next % 2 == 0 && (a % 2 != 0 || next < a) ? next : a));
        Console.WriteLine("Aufgabe 1f)");
        
        var LargeEvenNumber = numbers
            .Where(n => n % 2 != 0)
            .Max();
        Console.WriteLine(LargeEvenNumber);
        Console.WriteLine();
        Console.WriteLine(numbers
            .Aggregate((a, next) => next % 2 != 0 && (a % 2 == 0 || next > a) ? next : a));
        Console.WriteLine("Aufgabe 2g)");
        
        var SumEvenNumber = numbers.Where(n => n % 2 == 0).Sum();
        Console.WriteLine(SumEvenNumber);
        Console.WriteLine();
        Console.WriteLine(numbers
            .Aggregate(0, (sum, n) => n % 2 == 0 ? sum + n : sum));
        Console.WriteLine("Aufgabe 2h)");
        
        var AverageEvenNumber = numbers.Where(n => n % 2 != 0).Average();
        Console.WriteLine(AverageEvenNumber);
        Console.WriteLine();
        Console.WriteLine(numbers
            .Aggregate((sum: 0, count: 0),
            (acc, n) => n % 2 != 0
                ? (acc.sum + n, acc.count + 1)
                : acc,
            acc => acc.count > 0 ? (double)acc.sum / acc.count : 0
        ));
        Console.WriteLine("Aufgabe 2i)");
        
        var CounterOfAllEvenNumbers = numbers
            .Count(n => n % 2 == 0);
        Console.WriteLine(CounterOfAllEvenNumbers);
        Console.WriteLine(numbers
            .Aggregate(0, (count, n) => n % 2 == 0 ? count + 1 : count));
    }
}