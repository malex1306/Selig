namespace Beziehungen;

public class Floor 
{
    private List<Room> rooms = new List<Room>();

    public Floor(int roomCount)
    {
        for (int i = 0; i < roomCount; i++)
        {
            rooms.Add(new Room() { Description = $"Room {i}" });
        }
    }
}