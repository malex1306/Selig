namespace OrderBy;

class Program
{
    static void Main(string[] args)
    {
        string[] names = ["Inga", "Udo", "Kim", "Peter", "Hans", "Gerda"];
        
        //Sortierung aufsteigend
        var sorted = names
            .OrderBy(n => n.Length);
        var sorted2 = 
            from n in names
            orderby n.Length
            select n;

        foreach (var n in sorted)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();
        foreach (var n in sorted2)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();
        // Sortierung absteigend
        var sorted3 = names
            .OrderByDescending(n => n.Length);
        var sorted4 = from n in names
            orderby n.Length descending
                select n;

        foreach (var n in sorted3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();
        foreach (var n in sorted4)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();
        //Mehrfache Sortierung
        
        var sorted5 = names
            .OrderBy(n => n.Length)
            .ThenByDescending(n => n);
        foreach (var n in sorted5)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();
        var sorted6 = from n in names
            orderby n.Length, n descending
            select n;
        foreach (var n in sorted6)
        {
            Console.WriteLine(n);
        }
    }
}