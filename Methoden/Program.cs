namespace Methoden;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(20, 22));
        Console.WriteLine(Add(20, 22, 19));
        Console.WriteLine(Add(20.0, 22.0));
    }

    public static int Add(int zahl1, int zahl2)
    {
        return zahl1 + zahl2;
    }

    public static int Add(int zahl1, int zahl2, int zahl3)
    {
        return zahl1 + zahl2 + zahl3;
    }

    public static double Add(double zahl1, double zahl2)
    {
        return zahl1 + zahl2;
    }
}