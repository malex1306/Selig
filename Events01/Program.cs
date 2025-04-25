namespace Events01;

class Program
{
    static void Main(string[] args)
    {
        Model m = new Model();
        View v = new View(m);
        Controller c = new Controller(m);
        c.BusinessLogic();
    }
}