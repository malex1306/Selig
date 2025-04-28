using Wasserstand01;

class Program
{
    static void Main()
    {
        var rhein = new Fluss("Rhein", 500);
        var donau = new Fluss("Donau", 500);

        var rheingold = new Schiff("Rheingold");
        var lorelei = new Schiff("Lorelei");
        var xaver = new Schiff("Xaver");
        var franz = new Schiff("Franz");

        var mainz = new Stadt("Mainz");
        var wien = new Stadt("Wien");

        var klaerwerkRhein = new Klaeranlage("Rheinwerke");
        var klaerwerkDonau = new Klaeranlage("Donauwerke");

        
        rhein.WasserstandGeaendert += rheingold.ReagiereAufWasserstand;
        rhein.WasserstandGeaendert += lorelei.ReagiereAufWasserstand;
        rhein.WasserstandGeaendert += mainz.ReagiereAufWasserstand;
        rhein.WasserstandGeaendert += klaerwerkRhein.ReagiereAufWasserstand;

        donau.WasserstandGeaendert += xaver.ReagiereAufWasserstand;
        donau.WasserstandGeaendert += franz.ReagiereAufWasserstand;
        donau.WasserstandGeaendert += wien.ReagiereAufWasserstand;
        donau.WasserstandGeaendert += klaerwerkDonau.ReagiereAufWasserstand;

       
        for (int i = 0; i < 10; i++)
        {
            rhein.RandomWasserStand();
            donau.RandomWasserStand();
            Thread.Sleep(400);
        }
    }
}