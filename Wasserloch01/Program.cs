namespace Wasserloch01;

class Program 
{ 
    static void Main(string[] args) 
    { 
        var waechtertier = new Waechtertier();
        var fluchttier = new FluchtTier();
        var kampftier = new KampfTier();
        var tantier = new TarnTier();

        fluchttier.Registrieren(waechtertier);
        kampftier.Registrieren(waechtertier);
        tantier.Registrieren(waechtertier);
        
        waechtertier.OnRaubkatzeKommt();
    }
}
