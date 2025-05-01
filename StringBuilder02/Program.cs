using System.Text;

namespace StringBuilder02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hallo welt-programmierer";
            char[] chars = new char[] { ' ', '-' };

            string result = Capitalize(input, chars);
            Console.WriteLine(result);
        }

        static string Capitalize(string input, char[] chars)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 || chars.Contains(input[i - 1]))
                {
                    sb.Append(char.ToUpper(input[i]));
                }
                else
                {
                    sb.Append(char.ToLower(input[i]));
                }
            }
            return sb.ToString();
        }
    }
}