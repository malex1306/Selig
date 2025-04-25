namespace Events01;

public class Model
{
    private List<string> dataList;
    private Action? dataChanged;
    public event Action? DataChanged;

    // public event Action DataChanged
    // {
    //     add { dataChanged += value;}
    //     remove { dataChanged -= value; }
    // }
    //
    
    public Model()
    {
        dataList = ["Hallo", "Do7"];
    }

    public void AddData(string s)
    {
        dataList.Add(s);
        DataChanged?.Invoke();
    }

    public void RemoveData(string s)
    {
        dataList.Remove(s);
        DataChanged?.Invoke();
    }

    public List<string> GetAllData()
    {
        return dataList;   
    }
}