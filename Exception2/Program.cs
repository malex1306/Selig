namespace Exception2;

class Program
{
    static void Main(string[] args)
    {
        bool fehler = true;
        int zahl1 = EingabeInt("Bitte Zahl 1 eingeben");
        do
        {
            int zahl2 = EingabeInt("Bitte Zahl 2 eingeben");

            if (zahl2 != 0)
            {
                Console.WriteLine(zahl1 / zahl2);
                fehler = false;
            }
        } while (fehler);
    }

     static int EingabeInt(string text)
        {
            int zahl;
            do
            {
                Console.Write(text);
            } while (!Int32.TryParse(Console.ReadLine(), out zahl));

            return zahl;

        }
    
}