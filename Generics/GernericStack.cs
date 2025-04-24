namespace Generics;

public class GernericStack<T> 
{
    private T?[] data;
    public int Count { get; private set; } = 0;

    public GernericStack(int capacity)
    {
        data = new T[capacity];
    }
    
    public void Push(T element)
    {
        if (Count < data.Length)
        {
            data[Count] = element;
            Count++;
        }
    }
    public T? Pop()
    {
        if (Count > 0)
        {
            Count--;
            T? element = data[Count];
            data[Count] = default;
            return element;
        }
        return default;
    }
}