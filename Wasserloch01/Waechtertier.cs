namespace Wasserloch01;

public class Waechtertier
{
    public event EventHandler<RaubkatzeEventArgs>? RaubkatzeKommt;

    public void OnRaubkatzeKommt()
    {
        RaubkatzeKommt?.Invoke(this, new RaubkatzeEventArgs(info:"Raubkatze in der Nähe"));
    }
}