namespace Exception1;

class Program
{
    static void Main(string[] args)
    {
        bool fehler = true;
        while (fehler)
        {
            try
            {
                Console.WriteLine("Erste Zahl: ");
                int zahl1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Zweite Zahl: ");
                int zahl2 = int.Parse(Console.ReadLine());

                Console.WriteLine(zahl1 / zahl2);
                fehler = false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Bitte nur Zahlen eingeben!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Bitte nur im int Bereich!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Die zweite Zahl darf nicht 0 sein!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein unerwarteter Fehler!");
            }
        }
        
    }
}