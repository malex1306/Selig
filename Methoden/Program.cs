namespace Methoden;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(20, 22));
        Console.WriteLine(Add(20, 22, 19));
        //Console.WriteLine(Add(20.0, 22.0));
        Console.WriteLine(Add(20,22, 5));
    }

    public static int Add(int zahl1, int zahl2, int? zahl3 = null)
    {
        return zahl1 + zahl2 + (zahl3 == null ? 0 : (int)zahl3);
    }

   
    public static int Add(int zahl1, int zahl2)
    {
        return zahl1 + zahl2;
    }

    //public static int Add(int zahl1, int zahl2, int zahl3)
    //{
       // return zahl1 + zahl2 + zahl3;
    //}

    //public static double Add(double zahl1, double zahl2)
    //{
      //  return zahl1 + zahl2;
    //}
}