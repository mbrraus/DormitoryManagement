using DormitoryManagement.Data;
using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Students;

public class StudentService(IDbContextFactory<DormitoryContext> contextFactory)
{
    public async Task<List<Student>> GetAllStudents()
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        return await context.Students
            .Include(x => x.RoomAssignment)
            .ToListAsync();
    }
    
    public async Task<bool> AddStudent(AddStudentRequest addStudentRequest)
    {
        await using var context = await contextFactory.CreateDbContextAsync();
        
        var studentId = Guid.NewGuid();

        context.Students.Add(new Student()
        {
            Id = studentId,
            FirstName = addStudentRequest.FirstName,
            LastName = addStudentRequest.LastName,
        });
        
        await context.SaveChangesAsync();
        return true;
    } 
}