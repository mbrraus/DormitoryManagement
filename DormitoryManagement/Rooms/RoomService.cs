using DormitoryManagement.Data;
using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Rooms;

public class RoomService(IDbContextFactory<DormitoryContext> contextFactory)
{
    public async Task<List<Building>> GetBuildings()
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        var buildings = await context.Buildings
            .Include(x => x.Floors)
            .ThenInclude(x => x.Rooms)
            .ToListAsync();

        return buildings;
    }
    
    public async Task<List<Room>> GetRoomsByFloorId(Guid floorId)
    {
        await using var context = await contextFactory.CreateDbContextAsync();
        
        // Fetch the rooms that belong to the specified floor
        var rooms = await context.Rooms
            .Where(room => room.FloorId == floorId)
            .Include(r => r.Floor)
            .ToListAsync();

        return rooms;
    }
    
    
}