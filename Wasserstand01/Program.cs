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

        
        rhein.ZuNiedrig += rheingold.StopWegenZuNiedrig;
        rhein.ZuHoch += rheingold.StopWegenZuHoch;
        rhein.ZuNiedrig += lorelei.StopWegenZuNiedrig;
        rhein.ZuHoch += lorelei.StopWegenZuHoch;

        donau.ZuNiedrig += xaver.StopWegenZuNiedrig;
        donau.ZuHoch += xaver.StopWegenZuHoch;
        donau.ZuNiedrig += franz.StopWegenZuNiedrig;
        donau.ZuHoch += franz.StopWegenZuHoch;

        
        rhein.ZuHoch += mainz.SchutzwandErrichten;
        donau.ZuHoch += wien.SchutzwandErrichten;

        
        rhein.ZuHoch += klaerwerkRhein.ReagiereAufWasserstand;
        rhein.ZuNiedrig += klaerwerkRhein.ReagiereAufWasserstand;
        donau.ZuHoch += klaerwerkDonau.ReagiereAufWasserstand;
        donau.ZuNiedrig += klaerwerkDonau.ReagiereAufWasserstand;

       
        for (int i = 0; i < 10; i++)
        {
            rhein.RandomWasserStand();
            donau.RandomWasserStand();
            Thread.Sleep(400); 
        }
    }
}