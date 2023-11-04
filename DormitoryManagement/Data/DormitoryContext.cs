using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Data;

public class DormitoryContext(DbContextOptions<DormitoryContext> options) : DbContext(options)
{
    public required DbSet<Building> Buildings { get; set; }
    public required DbSet<Floor> Floors { get; set; }
    public required DbSet<Room> Rooms { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var building1Id = Guid.NewGuid();
        var building2Id = Guid.NewGuid();

        modelBuilder.Entity<Building>().HasData(
            new Building { Id = building1Id, Name = "Building A" },
            new Building { Id = building2Id, Name = "Building B" }
        );
    
        var floor1Id = Guid.NewGuid();
        var floor2Id = Guid.NewGuid();
        var floor3Id = Guid.NewGuid();
        var floor4Id = Guid.NewGuid();
    
        modelBuilder.Entity<Floor>().HasData(
            new Floor { Id = floor1Id, Number = 1, BuildingId = building1Id },
            new Floor { Id = floor2Id, Number = 2, BuildingId = building1Id },
            new Floor { Id = floor3Id, Number = 1, BuildingId = building2Id },
            new Floor { Id = floor4Id, Number = 2, BuildingId = building2Id }
        );
    
        modelBuilder.Entity<Room>().HasData(
            new Room { Id = Guid.NewGuid(), Number = "101", FloorId = floor1Id},
            new Room { Id = Guid.NewGuid(), Number = "102", FloorId = floor1Id},
            new Room { Id = Guid.NewGuid(), Number = "103", FloorId = floor1Id},
            new Room { Id = Guid.NewGuid(), Number = "201", FloorId = floor2Id},
            new Room { Id = Guid.NewGuid(), Number = "202", FloorId = floor2Id},
            new Room { Id = Guid.NewGuid(), Number = "203", FloorId = floor2Id},
            new Room { Id = Guid.NewGuid(), Number = "204", FloorId = floor2Id},
            new Room { Id = Guid.NewGuid(), Number = "301", FloorId = floor3Id},
            new Room { Id = Guid.NewGuid(), Number = "302", FloorId = floor3Id},
            new Room { Id = Guid.NewGuid(), Number = "303", FloorId = floor3Id},
            new Room { Id = Guid.NewGuid(), Number = "304", FloorId = floor3Id},
            new Room { Id = Guid.NewGuid(), Number = "401", FloorId = floor4Id},
            new Room { Id = Guid.NewGuid(), Number = "402", FloorId = floor4Id},
            new Room { Id = Guid.NewGuid(), Number = "403", FloorId = floor4Id}
        );
    }

}