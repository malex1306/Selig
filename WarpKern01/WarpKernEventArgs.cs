namespace WarpKern01;

public class WarpKernEventArgs :EventArgs
{
    public double AlteTemperatur { get; }
    public double NeueTemperatur { get; }
    public DateTime Zeitpunkt { get; }

    public WarpKernEventArgs(double alteTemperatur, double neueTemperatur)
    {
        AlteTemperatur = alteTemperatur;
        NeueTemperatur = neueTemperatur;
        Zeitpunkt = DateTime.Now;
    }
}