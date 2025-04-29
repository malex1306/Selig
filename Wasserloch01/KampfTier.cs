namespace Wasserloch01;

public class KampfTier
{
    public void Kaempfen(object? sender, RaubkatzeEventArgs e) 
    {
        Console.WriteLine($"{e.Info} das Kapmfp-Tier bereitet sich auf den Kapmpf vor!");
    }
    public void Registrieren(Waechtertier waechtertier)
    {
        
        waechtertier.RaubkatzeKommt += Kaempfen;
    }
}