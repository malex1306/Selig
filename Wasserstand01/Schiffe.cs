namespace Wasserstand01;

    public class Schiff
    {
        private string name;

        public Schiff(string name)
        {
            this.name = name;
        }

        public void StopWegenZuNiedrig(object? sender, WasserstandEventArgs e)
        {
            Console.WriteLine($"{name} stoppt Fahrt auf {e.FlussName} wegen zu niedrigem Wasserstand ({e.Wasserstand} cm)");
        }

        public void StopWegenZuHoch(object? sender, WasserstandEventArgs e)
        {
            Console.WriteLine($"{name} stoppt Fahrt auf {e.FlussName} wegen zu hohem Wasserstand ({e.Wasserstand} cm)");
        }
    }
