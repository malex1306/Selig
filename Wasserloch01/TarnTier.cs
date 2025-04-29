namespace Wasserloch01;

public class TarnTier
{
    public void Tarnt(object? sender, RaubkatzeEventArgs e) 
    {
        Console.WriteLine($"{e.Info} Das Tarn-Tier tarnt sich und bleibt unbeweglich!");
    }
    public void Registrieren(Waechtertier waechtertier)
    {
        
        waechtertier.RaubkatzeKommt += Tarnt;
    }
}