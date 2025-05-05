namespace Linq02;

class Program
{
    static void Main(string[] args)
    {
        int [] numbers = [1,2,3,4,5,6,7,8,9,10];
        
        var evenNumbers = numbers
            .Where(n => n % 2 == 0);
        foreach (var n in evenNumbers)
        {
            Console.WriteLine(n);      
        }
        
        var oddNumbers = 
            from n in numbers 
            where n % 2 != 0 
            select n;
        foreach (var n in oddNumbers)
        {
            Console.WriteLine(n);       
        }
        
        //Where mit 2 Parametern (Wert und Index)
        var secondHalf = numbers
            .Where((n, i) => i >= numbers.Length / 2);
        foreach (var n in evenNumbers)
        {
            Console.WriteLine(n);
        }

        //Select
        string[] words = ["Hello", "DO7", "LINQ"];
        
        var firstLetters = words
            .Select(w => w.First());
        var wordLength = words
            .Select(w => w.Length);
        //Select mit 2 Parametern
        var words2 = words
            .Select((w, i) => new {Key = i , Value = w});
        foreach (var item in words2)
        {
            Console.WriteLine(item);       
        }
        
        //SelectMany
        var allLetters = words
            .SelectMany(w => w);
        foreach (var letter in allLetters)
        {
            Console.WriteLine(letter);
        }
    }
}