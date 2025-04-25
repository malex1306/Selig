namespace Wasserstand01;

    public class WasserstandEventArgs : EventArgs
    {
        public string FlussName { get; }
        public int Wasserstand { get; }

        public WasserstandEventArgs(string flussName, int wasserstand)
        {
            FlussName = flussName;
            Wasserstand = wasserstand;
        }
    }


