namespace DormitoryManagement.Data.Models;

public class Building
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public List<Floor> Floors { get; set; } = new();
}