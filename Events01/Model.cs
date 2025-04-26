namespace Events01;

public class Model
{
    private List<string> dataList;

    public event EventHandler<MyEventArgs>? DataChanged;

    public Model()
    {
        dataList = new List<string> { "Hallo", "Do7" };
    }

    public void AddData(string s)
    {
        dataList.Add(s);
        DataChanged?.Invoke(this, new MyEventArgs(s, s));
    }

    public void RemoveData(string s)
    {
        dataList.Remove(s);
        DataChanged?.Invoke(this, new MyEventArgs(s, s));
    }

    public List<string> GetAllData()
    {
        return dataList;
    }
}