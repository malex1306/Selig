namespace GenericRepository;

public class User : IEntity
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public override string ToString()
    {
        return $"{Id}, {DateOfBirth}, {Name}";
    }

    public User()
    {
        Id = Guid.NewGuid();
    }
}

