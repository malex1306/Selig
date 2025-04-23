namespace Exception4;

class Program
{
    static void Main(string[] args)
    {
        throw new MySpecialException("Es ist etwas pasiert",
            new ArgumentNullException());
    }
}