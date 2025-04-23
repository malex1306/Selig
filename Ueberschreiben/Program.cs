namespace Ueberschreiben;

class Program
{
    static void Main(string[] args)
    {
       //Basis sub1 = new Sub();
       //Sub sub2 = new Sub();
       //sub1.Methode1();
       //sub1.Methode2();
       //Console.WriteLine();
       //sub2.Methode1();
       //sub2.Methode2();
       Basis[] objekte =
       [
           new Basis(),
           new Sub(),
           new Sub2()
       ];
       foreach (Basis item in objekte)
       {
           item.Methode2();
       }
    }

    public class Basis
    {
        public void Methode1()
        {
            Console.WriteLine("Methode1 aus Basis");
        }
        public virtual void Methode2()
        {
            Console.WriteLine("Methode2 aus Basis");
        }
    }

    public class Sub : Basis
    {
        public new void Methode1()
        {
            Console.WriteLine("Methode1 aus Sub");
        }

        public override void Methode2()
        {
            Console.WriteLine("Methode2 aus Sub");
        }
    }

    public class Sub2 : Basis
    {
        public override void Methode2()
        {
            Console.WriteLine("Methode2 aus Sub2");
        }
    }
}