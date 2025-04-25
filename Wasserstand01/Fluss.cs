
namespace Wasserstand01;

    public class Fluss
    {
        private string name;
        private int wasserstand;
        private static Random random = new Random();

        public event EventHandler<WasserstandEventArgs>? ZuNiedrig;
        public event EventHandler<WasserstandEventArgs>? ZuHoch;

        public Fluss(string name, int wasserstand)
        {
            this.name = name;
            this.wasserstand = wasserstand;
        }

        public void RandomWasserStand()
        {
            wasserstand = random.Next(100, 10001);

            if (wasserstand < 250)
            {
                ZuNiedrig?.Invoke(this, new WasserstandEventArgs(name, wasserstand));
            }
            else if (wasserstand > 8000)
            {
                ZuHoch?.Invoke(this, new WasserstandEventArgs(name, wasserstand));
            }
        }
    }
