namespace NachrichtenDienstEmail;

public class NachrichtenEventargs : EventArgs
{
    public string Nachricht { get; }

    public NachrichtenEventargs(string nachricht)
    {
        Nachricht = nachricht;
    }
}
public class ModelNachrichtenDienst
{
    public event EventHandler<NachrichtenEventargs> NachrichtenEmpfangen;

    public void NeueNachricht(string text)
    {
        OnNachrichtEmpfangen(new NachrichtenEventargs(text));
    }

    public virtual void OnNachrichtEmpfangen(NachrichtenEventargs e)
    {
        NachrichtenEmpfangen?.Invoke(this, e);
    }
}