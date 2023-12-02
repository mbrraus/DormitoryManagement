namespace DormitoryManagement.Data.Models;

public class Building
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Floor> Floors { get; set; } = new List<Floor>();
}