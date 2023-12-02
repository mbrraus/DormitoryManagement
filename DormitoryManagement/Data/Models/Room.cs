namespace DormitoryManagement.Data.Models;

public class Room
{
    public Guid Id { get; set; }
    public required string Number { get; set; }
    public Guid FloorId { get; set; }
    public Floor Floor { get; set; } = null!;
    public ICollection<RoomInventory> RoomInventories { get; set; } = new List<RoomInventory>();
}