namespace Events01;

public class Controller
{
    private Model model;
    
    public Controller (Model model)
    {
        this.model = model;
    }

    public void BusinessLogic()
    {
        string input;

        do
        {
            input = Console.ReadLine()!;
            if (input != String.Empty)
            {
                if (input[0] == '-')
                {
                    model.RemoveData(input.Substring(1));
                }
                else
                {
                    model.AddData(input);
                }
            }
        } while (input != String.Empty);
    }
}