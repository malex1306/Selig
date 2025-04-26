namespace Bestelldienst01;

public class ViewAnzeige
{
    public void BestellungAnzeigen(object sender, BestellungEventArgs e)
    {
        Console.WriteLine($"Anzeige: {e.Menge} x {e.Produktname} bestellt");
    }
}