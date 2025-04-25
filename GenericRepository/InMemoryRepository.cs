namespace GenericRepository;

public class InMemoryRepository<T> where T : IEntity
{
    private Dictionary<Guid, T> data = [];
    public void Add(T entity)
    {
        data.Add(entity.Id, entity);
    }
    public void Delete(Guid id)
    {
        data.Remove(id);
    }

    public List<T> GetAll()
    {
        return data.Values.ToList();
    }
    public T? GetById(Guid id)
    {
        return data.GetValueOrDefault(id);
    }
    public void Update(T entity)
    {
        data[entity.Id] = entity;
    }

    public void Print()
    {
        foreach (T item in data.Values)
        {
            Console.WriteLine(item);
        }
    }

    public List<T> Search(Func<T, bool> filter)
    {
        List<T> list = [];
        foreach (T item in data.Values)
        {
            if (filter(item))
            {
                list.Add(item);
            }
        }
        return list;
    }
}