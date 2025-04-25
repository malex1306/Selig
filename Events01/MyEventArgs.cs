namespace Events01;

public class MyEventArgs : EventArgs
{
    public string Operation { get; }
    public string Value { get; }

    public MyEventArgs(string op, string val)
    {
        Operation = op;
        Value = val;
    }
}