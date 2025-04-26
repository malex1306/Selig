namespace Bestelldienst01;

public class BestellungEventArgs : EventArgs
{
    public string Produktname { get; }
    public int Menge { get; }

    public BestellungEventArgs(string produktname, int menge)
    {
        Produktname = produktname;
        Menge = menge;
    }
}


public class ModelBestellDienst
{
    public event EventHandler<BestellungEventArgs> BestellungAufgeben;

    public void NeueBestellung(string produkt, int menge)
    {
        OnBestellungAufgeben(new BestellungEventArgs(produkt, menge));
    }

    public virtual void OnBestellungAufgeben(BestellungEventArgs e)
    {
        BestellungAufgeben?.Invoke(this, e);
    }
}