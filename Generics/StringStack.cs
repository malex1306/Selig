namespace Generics;

public class StringStack
{
    private string[] data;
    public int Count { get; private set; } = 0;

    public StringStack(int capacity)
    {
        data = new string[capacity];
    }
    
    public void Push(string element)
    {
        if (Count < data.Length)
        {
            data[Count] = element;
            Count++;
        }
    }
    public string Pop()
    {
        if (Count > 0)
        {
            Count--;
            string element = data[Count];
            data[Count] = default;
            return element;
        }
        return default;
    }
}