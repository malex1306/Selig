namespace WarpKern01;

class Program
{
    static void Main(string[] args)
    {
        WarpKernKonsole konsole = new WarpKernKonsole();

        WarpKern kern1 = new WarpKern("Warpkern Alpha");
        WarpKern kern2 = new WarpKern("Warpkern Beta");
        WarpKern kern3 = new WarpKern("Warpkern Gamma");

       
        kern1.TemperaturGeaendert += konsole.TemperaturÄnderungAnzeigen;
        kern1.TemperaturZuHoch += konsole.WarnungAnzeigen;

        kern2.TemperaturGeaendert += konsole.TemperaturÄnderungAnzeigen;
        kern2.TemperaturZuHoch += konsole.WarnungAnzeigen;

        kern3.TemperaturGeaendert += konsole.TemperaturÄnderungAnzeigen;
        kern3.TemperaturZuHoch += konsole.WarnungAnzeigen;

       
        for (int i = 0; i < 20; i++)
        {kern1.ÄndereTemperatur();
            kern2.ÄndereTemperatur();
            kern3.ÄndereTemperatur();

            System.Threading.Thread.Sleep(500); 
        }

        Console.ReadLine();
    }
}
    
