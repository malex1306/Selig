using System;
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

        
        rhein.ZuNiedrig += rheingold.StopWegenZuNiedrig;
        rhein.ZuHoch += rheingold.StopWegenZuHoch;
        rhein.ZuNiedrig += lorelei.StopWegenZuNiedrig;
        rhein.ZuHoch += lorelei.StopWegenZuHoch;

        donau.ZuNiedrig += xaver.StopWegenZuNiedrig;
        donau.ZuHoch += xaver.StopWegenZuHoch;
        donau.ZuNiedrig += franz.StopWegenZuNiedrig;
        donau.ZuHoch += franz.StopWegenZuHoch;

        // Nur Reaktion bei Event
        for (int i = 0; i < 10; i++)
        {
            rhein.RandomWasserStand();
            donau.RandomWasserStand();
            Thread.Sleep(400); 
        }
    }
}