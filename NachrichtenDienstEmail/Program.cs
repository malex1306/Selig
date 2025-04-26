using NachrichtenDienstEmail;

class Program
{
    static void Main(string[] args)
    {
        var dienst = new ModelNachrichtenDienst();
        var anzeige = new ViewAnzeige();
        var logger = new Logger();
        var controller = new ControllerNachrichten(dienst, anzeige, logger);

       
        controller.NeueNachrichtEingeben("Hallo Marcel!");
        controller.NeueNachrichtEingeben("Willkommen in der Event-Welt!");
    }
}