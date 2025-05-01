namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        static int CountCharInString(string input, char target)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == target)
                {
                    count++;
                }
            }

            return count;
        }

        int result = CountCharInString("programmieren", 'r');
        Console.WriteLine($"Das Zeichen kommt {result} mal vor.");


       
    }

}
