namespace DormitoryManagement.Data.Models;

public class Floor
{
    public Guid Id { get; set; }
    public required int Number { get; set; }
    public Guid BuildingId { get; set; }
    public Building Building { get; set; } = null!;
    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}