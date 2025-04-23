namespace Beziehungen;

public class Building 
{
    private List<Floor> floors = new List<Floor>();

    public Building(int floorCount, int roomCount)
    {
        for (int i = 0; i < floorCount; i++)
        {
            floors.Add(new Floor(roomCount));
        }
    }
}