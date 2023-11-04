namespace DormitoryManagement.Data.Models;

public class Floor
{
    public required Guid Id { get; set; }
    public required int Number { get; set; }
    public required Guid BuildingId { get; set; }
    public Building Building { get; set; } = null!;
    public List<Room> Rooms { get; set; } = new();
}