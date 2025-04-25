namespace Events01;

public class View
{
    private Model model;

    public View(Model model)
    {
        this.model = model;
        this.model.DataChanged += ShowData;
    }

    public void ShowData()
    {
        Console.Clear();
        Console.WriteLine("Datenbestand: ");
        foreach (var s in model.GetAllData() )
        {
            Console.WriteLine(s);       
        }
        Console.WriteLine();
    }
}