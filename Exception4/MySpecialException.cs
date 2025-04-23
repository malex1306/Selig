namespace Exception4;

public class MySpecialException : Exception

{
    public MySpecialException() {}
    public MySpecialException(string message) : base(message){}
    public MySpecialException(string message, Exception inner) : base(message, inner){}
}