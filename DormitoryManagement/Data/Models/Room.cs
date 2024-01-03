namespace DormitoryManagement.Data.Models;

public class Room
{
    public Guid Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public Guid FloorId { get; set; }
    public Floor Floor { get; set; } = null!;
    public int AllowedPersons { get; set; }
    
    public ICollection<RoomInventory> RoomInventories { get; set; } = new List<RoomInventory>();
    public ICollection<RoomAssignment> RoomAssignments { get; set; } = new List<RoomAssignment>();
}