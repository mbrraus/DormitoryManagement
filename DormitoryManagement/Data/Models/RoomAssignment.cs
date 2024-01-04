namespace DormitoryManagement.Data.Models;

public class RoomAssignment
{
    public Guid Id { get; set; }
    public Guid RoomId { get; set; }
    public Guid StudentId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public virtual Room Room { get; set; }
    public virtual Student Student { get; set; }
}
