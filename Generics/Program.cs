namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        var str = new StringStack(10);
        Console.WriteLine(str.Count);
        str.Push("Hallo");
        str.Push("DO7");
        Console.WriteLine(str.Count);
        Console.WriteLine(str.Pop());
        Console.WriteLine(str.Count);
        
        var ints = new IntStack(10);
        ints.Push(10);
        ints.Push(99);
        ints.Push(101);
        Console.WriteLine(ints.Pop());
        Console.WriteLine(ints.Pop());
        Console.WriteLine(ints.Pop());

        var doubles = new GernericStack<double>(10);
        doubles.Push(10.1);
        doubles.Push(99.0);
        Console.WriteLine(doubles.Pop());
        
        var strings = new GernericStack<string>(10);
        strings.Push("Hallo");
        Console.WriteLine(strings.Pop());
    }
}