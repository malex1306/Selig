namespace StringBuilder01
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string input = "hallo welt, ich bin C#"; 
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 || input[i - 1] == ' ')
                {
                    sb.Append(char.ToUpper(input[i]));
                }
                else
                {
                    sb.Append(char.ToLower(input[i]));
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}