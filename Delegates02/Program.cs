namespace Delegates02;


class Program
{
    public static bool IsEven(int value)
    {
        return value % 2 == 0;
    }
    public static bool IsOdd(int value)
    {
        return value % 2 != 0;
    }

    public static bool Greater3(int value)
    {
        return value > 3;
    }
    

    public static void ShowFilterValues(int[] values, Func<int, bool> filter)//higherOrderFunction
    {
        foreach (int item in values)
        {
            if (filter(item))
            {
                Console.Write(item + " ");
            }
        }

        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        ShowFilterValues(values, IsEven);
        ShowFilterValues(values, IsOdd);
        ShowFilterValues(values, Greater3);
        
        ShowFilterValues(values, delegate(int value) { return value < 5; });
        ShowFilterValues(values, value => value > 5);
        
    }
}