using DormitoryManagement.Data;
using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Rooms;

public class RoomService(IDbContextFactory<DormitoryContext> contextFactory)
{
    public async Task<Room> GetRoomById(Guid id)
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        return await context.Rooms
            .Include(x => x.Floor)
            .ThenInclude(x => x.Building)
            .Include(x => x.RoomInventories)
            .SingleAsync(x => x.Id == id);
    }
    
}