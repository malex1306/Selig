namespace NachrichtenDienstEmail;

public class ControllerNachrichten
{
    private readonly ModelNachrichtenDienst _dienst;
    private readonly ViewAnzeige _anzeige;
    private readonly Logger _logger;

    public ControllerNachrichten(ModelNachrichtenDienst dienst, ViewAnzeige anzeige, Logger logger)
    {
        _dienst = dienst;
        _anzeige = anzeige;
        _logger = logger;

        _dienst.NachrichtenEmpfangen += _anzeige.NachrichtAnzeigen;
        _dienst.NachrichtenEmpfangen += _logger.NachrichtLoggen;
    }

    public void NeueNachrichtEingeben(string text)
    {
        _dienst.NeueNachricht(text);
    }
}