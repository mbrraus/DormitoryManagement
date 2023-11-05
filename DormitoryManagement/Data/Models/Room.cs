namespace DormitoryManagement.Data.Models;

public class Room
{
    public required Guid Id { get; set; }
    public required string Number { get; set; }
    public required Guid FloorId { get; set; }
    public Floor Floor { get; set; } = null!;
}