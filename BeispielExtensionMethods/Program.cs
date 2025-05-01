namespace BeispielExtensionMethods;

class Program
{
    static void Main(string[] args)
    {
        string input = "Hello World!";
        Console.WriteLine(input.SwitchCase());
        
        Console.WriteLine("AbCdEf".SwitchCase());
        Console.WriteLine(4711.Add(123));
    }
}