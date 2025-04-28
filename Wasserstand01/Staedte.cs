namespace Wasserstand01;

public class Stadt
{
    private string name;

    public Stadt(string name)
    {
        this.name = name;
    }

    public void SchutzwandErrichten(object? sender, WasserstandEventArgs e)
    {
        if (e.Wasserstand >= 8200)
        {
            Console.WriteLine($"Stadt {name} errichtet eine Schutzwand am {e.FlussName} (Wasserstand: {e.Wasserstand} cm)");
        }
    }
}

public class Klaeranlage
{
    private string name;

    public Klaeranlage(string name)
    {
        this.name = name;
    }

    public void ReagiereAufWasserstand(object? sender, WasserstandEventArgs e)
    {
        if (e.Wasserstand > 8000)
        {
            Console.WriteLine($"Kläranlage {name} stoppt Einleitungen in den {e.FlussName} (Wasserstand: {e.Wasserstand} cm)");
        }
        else if (e.Wasserstand == 300)
        {
            Console.WriteLine($"Kläranlage {name} steigert Einleitungen in den {e.FlussName} (Wasserstand: {e.Wasserstand} cm)");
        }
    }
}