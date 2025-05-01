using System.Text;

namespace BeispielExtensionMethods;

public static class Extensions
{
    public static string SwitchCase(this string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in input)
        {
            sb.Append(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
        }
        return sb.ToString();
    }

    public static int Add(this int a, int b)
    {
        return a + b;
    }
}