namespace WarpKern01;

public class WarpKernKonsole
{
    public void TemperaturÄnderungAnzeigen(object? sender, WarpKernEventArgs e)
    {
        if (sender is WarpKern warpkern)
        {
            Console.WriteLine($"[{e.Zeitpunkt}] {warpkern.Name}: Temperatur geändert von {e.AlteTemperatur:F2}°C auf {e.NeueTemperatur:F2}°C.");
        }
    }

    public void WarnungAnzeigen(object? sender, WarpKernEventArgs e)
    {
        if (sender is WarpKern warpkern)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{e.Zeitpunkt}] WARNUNG! {warpkern.Name}: Temperatur überschreitet 500°C! Aktuell: {e.NeueTemperatur:F2}°C.");
            Console.ResetColor();
        }
    }
}