namespace Exception3;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = ["abc", "def", "ghi", "jkl"];
        
        PrintString(strings, 2);
    }
    /// <summary>
    /// Schreibt den Eintrag an der Position p aus dem Array arr auf die Konsole aus.
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="p"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static void PrintString(string[] arr, int p)
    {
        if (arr == null)
        {
            throw new ArgumentNullException(nameof(arr));
        }
        if (p < 0 || p > arr.Length -1)
        {
           throw new ArgumentOutOfRangeException(nameof(p), p, "Index out of range"); 
        }
        Console.WriteLine(arr[p]);
    }
}