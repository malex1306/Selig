namespace Pagination;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5,4,1,3,9,8,6,7,2,0,22,12,16,18,11,19,13 };

        Console.WriteLine("Aufgabe 1a)");
        Print(numbers.Take(5));
        Console.WriteLine();
        Console.WriteLine("Aufgabe 1b)");
        
        Print(numbers.TakeLast(5));
        Console.WriteLine();
        Console.WriteLine("Aufgabe 1c)");
        Print(numbers
            .Skip(3)
            .SkipLast(3));
        Console.WriteLine();
        Console.WriteLine("Aufgabe 1d)");
        Print(numbers.TakeWhile(n => n != 22));
        Console.WriteLine();
        Console.WriteLine("Aufgabe 1e)");
        Print(numbers.SkipWhile(n => n != 12).Skip(1));
        Console.WriteLine();
        Console.WriteLine("Aufgabe 1f)");
        
        int pageSize = 5;
        int totalPages = (int)Math.Ceiling((double)numbers.Length / pageSize);

        for (int page = 0; page < totalPages; page++)
        {
            var pageData = numbers.Skip(page * pageSize).Take(pageSize);

            Console.WriteLine($"Seite {page + 1}:");
            foreach (var number in pageData)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
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