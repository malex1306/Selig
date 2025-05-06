namespace Linq4;

class Program
{
    static void Main(string[] args)
    {
        int [] numbers = [.. Enumerable.Range(1, 50)];
        
        //überspringen am Anfang und ende
        Print(numbers.Skip(10));
        Console.WriteLine();
        Print(numbers.SkipLast(10));
        Console.WriteLine();
        
        //Überspringen mit Bedingung mit SkipWhile
        
        Print(numbers.SkipWhile(n => n % 7 !=0));
        Console.WriteLine();
        
        Print(numbers.Take(10));
        Console.WriteLine();
        Print(numbers.TakeLast(10));
        Console.WriteLine();
        
        //Selektieren mit Bedingung mit TakeWhile
        Print(numbers.TakeWhile(n => n % 7 !=0));
        Console.WriteLine();
        //Pagination mit Skip und Take
        int PageSize = 8;

        for (int i = 1; i <= Math.Ceiling(numbers.Count() / (decimal)PageSize); i++)
        {
            Console.WriteLine($"Seite: {i}");
            Print(numbers
                .Skip((i -1) * PageSize)
                .Take(PageSize));
        }

    }

    public static void Print(IEnumerable<int> coll)
    {
        foreach (var item in coll)
        {
            Console.Write(item + " ");
        }
    }
}