namespace Bestelldienst01;

class Program
{
    static void Main(string[] args)
    {
        var dienst = new ModelBestellDienst();
        var anzeige = new ViewAnzeige();
        var logger = new Logger();
        var controller = new BestellController(dienst,anzeige,logger);
        
        controller.BestellungAufgeben("Kaffe", 2);
        controller.BestellungAufgeben("Tee", 1);
        controller.BestellungAufgeben("Sandwich", 3);
    }
}