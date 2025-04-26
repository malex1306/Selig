namespace NachrichtenDienstEmail;

public class Logger
{
    public void NachrichtLoggen(object sender, NachrichtenEventargs e)
    {
        Console.WriteLine($"Logger: Nachricht gespeichert -> {e.Nachricht} ");
    }
}