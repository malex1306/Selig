namespace Generics;

public class IntStack
{
    private int[] data;
    public int Count { get; private set; } = 0;

    public IntStack(int capacity)
    {
        data = new int[capacity];
    }
    
    public void Push(int element)
    {
        if (Count < data.Length)
        {
            data[Count] = element;
            Count++;
        }
    }
    public int? Pop()
    {
        if (Count > 0)
        {
            Count--;
            int? element = data[Count];
            data[Count] = default;
            return element;
        }
        return default;
    }
}