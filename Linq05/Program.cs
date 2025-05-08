

namespace Linq05;

class Program
{
    static void Main(string[] args)
    {
        var heroes = Hero.GetHeroes();
        
        //Gruppierung Standart
        var group1 =
            from h in heroes
            group h by h.Gang;
        Print(group1);
        Console.WriteLine();
        var group2 = heroes.GroupBy(h => h.Gang);
        Print(group2);

        Console.WriteLine();
        
        // Gruppierung mit individuellen element

        var group3 = heroes
            .GroupBy(h => h.Gang, h => new { h.HeroName, h.Age });
        Print(group3);
    }

    public static void Print<TKey, TElement>(IEnumerable<IGrouping<TKey, TElement>> coll)
    {
        foreach (var group in coll)
        {
            Console.WriteLine(group.Key);
            foreach (var hero in group)
            {
                Console.WriteLine(hero);
            }
        }
    }
}