namespace Wasserstand01;

public class Fluss
{
    private string name;
    private int wasserstand;
    private static Random random = new Random();

    
    public event EventHandler<WasserstandEventArgs>? WasserstandGeaendert;

    public Fluss(string name, int wasserstand)
    {
        this.name = name;
        this.wasserstand = wasserstand;
    }

    public void RandomWasserStand()
    {
        wasserstand = random.Next(100, 10001);
        

        
        WasserstandGeaendert?.Invoke(this, new WasserstandEventArgs(name, wasserstand));
    }
}