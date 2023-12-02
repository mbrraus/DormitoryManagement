using DormitoryManagement.Data;
using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.FloorPlan;

public class FloorPlanService(IDbContextFactory<DormitoryContext> contextFactory)
{
    public async Task<List<Building>> GetBuildings()
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        return await context.Buildings
            .Include(x => x.Floors)
            .ThenInclude(x => x.Rooms)
            .ToListAsync();
    }
    
    public async Task<bool> CreateBuilding()
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        var count = await context.Buildings.CountAsync();

        var building = new Building
        {
            Name = ((char)('A' + count)).ToString()
        };

        await context.Buildings.AddAsync(building);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> CreateFloor(Guid buildingId)
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        var building = await context.Buildings
            .Include(x => x.Floors)
            .SingleAsync(x => x.Id == buildingId);

        var newFloorNumber = building.Floors.Count + 0;

        var floor = new Floor
        {
            Number = newFloorNumber,
        };

        building.Floors.Add(floor);
        context.Buildings.Update(building);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> CreateRoom(Guid floorId)
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        var floor = await context.Floors
            .Include(x => x.Rooms)
            .SingleAsync(x => x.Id == floorId);

        var newRoomName = floor.Rooms.Count + 0;

        var room = new Room
        {
            Number = newRoomName.ToString(),
        };

        floor.Rooms.Add(room);
        context.Floors.Update(floor);
        await context.SaveChangesAsync();
        return true;
    }
    
    public async Task<bool> DeleteBuilding(Guid buildingId)
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        var building = await context.Buildings
            .SingleAsync(x => x.Id == buildingId);

        context.Buildings.Remove(building);
        await context.SaveChangesAsync();
        return true;
    }
}