namespace LinqJoins;


class Program
{
    static void Main(string[] args)
    {
        var prods = Data.Product.GetProducts();
        var groups = Data.ProductGroup.GetGroups();
        
        //Inner join Querry Expression

        var inner1 = from g in groups
            join p in prods on g.GroupId equals p.GroupId
            select new
            {
                g.GroupId,
                g.GroupName,
                p.ProductId,
                p.ProductName
            };
        Print(inner1);
        Console.WriteLine();
        
        //Extension Method Syntax

        var inner2 = groups.Join(
            prods,
            g => g.GroupId,
            p => p.GroupId,
            (g, p) => new
            {
                g.GroupId, 
                g.GroupName, 
                p.ProductId, 
                p.ProductName
            });
        Print(inner2);
        Console.WriteLine();
        //LeftJoin Querry Expression

        var outer1 = from g in groups
            join p in prods on g.GroupId equals p.GroupId into joinedSet
            from subgroup in joinedSet.DefaultIfEmpty()
            select new
            {
                g.GroupId,
                g.GroupName,
                ProductId = subgroup?.ProductId ?? 0,
                ProductName = subgroup?.ProductName ?? "<null>"
            };
        Print(outer1);
        // Extension Method
        Console.WriteLine();
        var outer2 = groups.GroupJoin(
            prods,
            g => g.GroupId,
            p => p.GroupId,
            (g, prodList) => new
            {
                group = g, subgroup = prodList
            }).SelectMany(joinedset => joinedset.subgroup.DefaultIfEmpty(),
            (joinedset, prod) => new
            {
                joinedset.group.GroupId,
                joinedset.group.GroupName,
                ProductId = prod?.ProductId ?? 0,
                ProductName = prod?.ProductName ?? "<null>"
            });
            
        Print(outer2);
    }
    public static void Print<T>(IEnumerable<T> coll)
    {
        foreach (T item in coll)
        {
            Console.WriteLine(item);
        }
    }
}