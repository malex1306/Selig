namespace Delegates01;

delegate void MyDelegate(string s);

class Program
{
    public static void Methode1(string text)
    {
        Console.WriteLine("Methode1: " + text);
    }

    public static void Methode2(string text)
    {
        Console.WriteLine("Methode2: " + text);
    }
    
    static void Main(string[] args)
    {
        MyDelegate del1 = new MyDelegate(Methode1);
        MyDelegate del2 = new MyDelegate(Methode2);
        del2 += del1;
        
        Console.ReadLine();
        del1("Hallo");
        del2("Welt");
        
        MyDelegate del3 = Methode1;
        del3("Hallo");
    }
}