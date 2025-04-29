namespace Wasserloch01;

public class RaubkatzeEventArgs : EventArgs
{
    public string Info { get; }

    public RaubkatzeEventArgs(string info)
    {
        Info = info;
    }
}