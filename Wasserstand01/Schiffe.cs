namespace Wasserstand01;

public class Schiff
{
    private string name;

    public Schiff(string name)
    {
        this.name = name;
    }

    public void ReagiereAufWasserstand(object? sender, WasserstandEventArgs e)
    {
        if (e.Wasserstand < 250)
        {
            Console.WriteLine($"{name} stoppt Fahrt auf {e.FlussName} wegen zu niedrigem Wasserstand ({e.Wasserstand} cm)");
        }
        else if (e.Wasserstand > 8000) 
            Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine($"{name} stoppt Fahrt auf {e.FlussName} wegen zu hohem Wasserstand ({e.Wasserstand} cm)");
        Console.ResetColor(); 
    }
}