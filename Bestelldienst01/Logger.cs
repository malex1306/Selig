namespace Bestelldienst01;

public class Logger
{
    public void BestellungLoggen(object sender, BestellungEventArgs e)
    {
        Console.WriteLine($"Logger: Bestellung gespeichert: {e.Menge} x {e.Produktname}!");
    }
}