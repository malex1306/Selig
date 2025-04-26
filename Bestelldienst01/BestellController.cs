namespace Bestelldienst01;

public class BestellController
{
    private readonly ModelBestellDienst _dienst;
    private readonly ViewAnzeige _anzeige;
    private readonly Logger _logger;

    public BestellController(ModelBestellDienst dienst, ViewAnzeige anzeige, Logger logger)
    {
        _dienst = dienst;
        _anzeige = anzeige;
        _logger = logger;
        
        _dienst.BestellungAufgeben += _anzeige.BestellungAnzeigen;
        _dienst.BestellungAufgeben += _logger.BestellungLoggen;
    }
    
    public void BestellungAufgeben(string produkt, int menge)
    {
        _dienst.NeueBestellung(produkt, menge);
    }
}