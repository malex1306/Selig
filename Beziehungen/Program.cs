namespace Beziehungen;

class Program
{
    static void Main(string[] args)
    {
        //Assoziation oder Aggregation
        //Car hat eigene Referenz in der Main
        var car = new Car() { Model = "Toyota"};
        var driver = new Driver() {Name = "Paul", Car = car};
        
        Console.WriteLine(driver.Car.Model);
        
        //Komposition
        var building = new Building(10, 15);
    }

    
 
}