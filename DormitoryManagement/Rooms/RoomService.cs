using DormitoryManagement.Data;
using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Rooms;

public class RoomService(IDbContextFactory<DormitoryContext> contextFactory)
{
    public async Task<List<Building>> GetAllBuildings()
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        return await context.Buildings
            .Include(x => x.Floors)
            .ThenInclude(x => x.Rooms)
            .ThenInclude(x => x.RoomAssignments)
            .ToListAsync();
    }

    public async Task<Room> GetRoomById(Guid roomId)
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        return await context.Rooms
            .Include(x => x.Floor)
            .ThenInclude(x => x.Building)
            .Include(x => x.RoomInventories)
            .ThenInclude(x => x.InventoryItem)
            .Include(x => x.RoomAssignments)
            .ThenInclude(x => x.Student)
            .SingleAsync(x => x.Id == roomId);
    }

    public async Task<bool> AssignStudentToRoom(AddStudentToRoomRequest addStudentToRoomRequest)
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        var room = await context.Rooms
            .SingleAsync(x => x.Id == addStudentToRoomRequest.RoomId);

        var studentId = Guid.NewGuid();
        var assignmentId = Guid.NewGuid();

        context.Students.Add(new Student()
        {
            Id = studentId,
            FirstName = addStudentToRoomRequest.FirstName,
            LastName = addStudentToRoomRequest.LastName,
            RoomAssignmentId = assignmentId,
            RoomAssignment = new RoomAssignment()
            {
                Id = assignmentId,
                RoomId = room.Id,
                StudentId = studentId,
                StartDate = addStudentToRoomRequest.StartDate.ToUniversalTime(),
                EndDate = addStudentToRoomRequest.EndDate.ToUniversalTime()
            }
        });
        
        await context.SaveChangesAsync();
        return true;
    }
}