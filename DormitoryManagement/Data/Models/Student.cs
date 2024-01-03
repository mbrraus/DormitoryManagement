namespace DormitoryManagement.Data.Models;

public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public Guid? RoomAssignmentId { get; set; }
    public virtual RoomAssignment RoomAssignment { get; set; }
}
