namespace WarpKern01;

public class WarpKern
{
    public string Name { get; }
    private double warpkernTemperatur;
    private Random random = new Random();

    public event EventHandler<WarpKernEventArgs>? TemperaturGeaendert;
    public event EventHandler<WarpKernEventArgs>? TemperaturZuHoch;

    public WarpKern(string name)
    {
        Name = name;
        warpkernTemperatur = random.NextDouble() * 300; 
    }

    public void ÄndereTemperatur()
    {
        double alteTemperatur = warpkernTemperatur;
        warpkernTemperatur += random.NextDouble() * 100 - 30; 

        var eventArgs = new WarpKernEventArgs(alteTemperatur, warpkernTemperatur);

        TemperaturGeaendert?.Invoke(this, eventArgs);
        if (warpkernTemperatur > 500)
        {
            TemperaturZuHoch?.Invoke(this, eventArgs);
        }
    }

}