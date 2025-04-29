namespace Wasserloch01;

public class FluchtTier
{
    public void Flucht(object? sender, RaubkatzeEventArgs e) 
    {
        Console.WriteLine($"{e.Info} das Flucht-Tier flieht!");
    }
    public void Registrieren(Waechtertier waechtertier)
    {
        
        waechtertier.RaubkatzeKommt += Flucht;
    }
}