using System.Globalization;

namespace LinqAnonymeTypen;

class Program
{
    static void Main(string[] args)
    {
        Hero h1 = new Hero()
        {
            HeroName = "Batman",
            Gang = "Justice League",
            FirstName = "Bruce",
            LastName = "Wayne",
            DateOfBirth = new DateTime(1963, 2, 19)
        };
        Console.WriteLine(h1);
        Console.WriteLine(h1.GetType());

        var heroShort = new
        {
            h1.HeroName,
            h1.Gang,
        };
        Console.WriteLine(heroShort);
        Console.WriteLine(heroShort.GetType());

        var h2Short = new
        {
            HeroName = "Thor", Gang = "Avengers"
        };
        
        Console.WriteLine(h2Short);
        Console.WriteLine(h2Short.GetType());
        
        //Linq Query Expression Syntax
        var heroes = Hero.GetHeroes();

        var justiceLeaque = from h in heroes
            where h.Gang == "Justice League"
            select new { h.HeroName, h.Gang };
        foreach (var item in justiceLeaque)
        {
            Console.WriteLine(item);
        }
    }
    
}