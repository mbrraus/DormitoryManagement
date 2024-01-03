using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Data;

public class DormitoryContext(DbContextOptions<DormitoryContext> options) : DbContext(options)
{
    public required DbSet<Building> Buildings { get; set; }
    public required DbSet<Floor> Floors { get; set; }
    public required DbSet<Room> Rooms { get; set; }
    public required DbSet<RoomInventory> RoomInventories { get; set; }
    public required DbSet<InventoryItem> InventoryItems { get; set; }
    public required DbSet<Student> Students { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.RoomAssignment)
            .WithOne(ra => ra.Student)
            .HasForeignKey<Student>(s => s.RoomAssignmentId);

        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        var buildings = new List<Building>
        {
            new()
            {
                Id = Guid.NewGuid(), // Set a non-default Guid value
                Name = "Building A",
                Floors = new List<Floor>
                {
                    new()
                    {
                        Id = Guid.NewGuid(), // Also set for Floor
                        Number = 1,
                        Rooms = GenerateRooms("A1")
                    },
                    new()
                    {
                        Id = Guid.NewGuid(), // Also set for Floor
                        Number = 2,
                        Rooms = GenerateRooms("A2")
                    }
                }
            },
            new()
            {
                Id = Guid.NewGuid(), // Set a non-default Guid value
                Name = "Building B",
                Floors = new List<Floor>
                {
                    new()
                    {
                        Id = Guid.NewGuid(), // Also set for Floor
                        Number = 1,
                        Rooms = GenerateRooms("B1")
                    },
                    new()
                    {
                        Id = Guid.NewGuid(), // Also set for Floor
                        Number = 2,
                        Rooms = GenerateRooms("B2")
                    }
                }
            }
        };

        // Add Buildings
        foreach (var building in buildings)
        {
            modelBuilder.Entity<Building>().HasData(new { building.Id, building.Name });

            // Add Floors for each Building
            foreach (var floor in building.Floors)
            {
                modelBuilder.Entity<Floor>().HasData(new { floor.Id, floor.Number, BuildingId = building.Id });

                // Add Rooms for each Floor
                foreach (var room in floor.Rooms)
                    modelBuilder.Entity<Room>().HasData(new
                        { room.Id, room.Number, room.AllowedPersons, FloorId = floor.Id });
            }
        }

        // Create inventory items
        var inventoryItems = new List<InventoryItem>
        {
            new() { Id = Guid.NewGuid(), Name = "Chair" },
            new() { Id = Guid.NewGuid(), Name = "Desk" },
            new() { Id = Guid.NewGuid(), Name = "Bed" },
            new() { Id = Guid.NewGuid(), Name = "Lamp" },
            new() { Id = Guid.NewGuid(), Name = "Bookshelf" },
            new() { Id = Guid.NewGuid(), Name = "Wardrobe" },
            new() { Id = Guid.NewGuid(), Name = "Curtains" }
        };

        // Seed Inventory Items
        foreach (var item in inventoryItems)
            modelBuilder.Entity<InventoryItem>().HasData(new { item.Id, item.Name });

        // Assign inventory to rooms randomly
        var random = new Random();
        foreach (var building in buildings)
        {
            foreach (var floor in building.Floors)
            {
                foreach (var room in floor.Rooms)
                {
                    // Randomly select a subset of inventory items for each room
                    var roomInventoryItems = inventoryItems.OrderBy(_ => random.Next())
                        .Take(random.Next(1, inventoryItems.Count)).ToList();

                    foreach (var item in roomInventoryItems)
                    {
                        var expectedQuantity = random.Next(1, 5); // Random quantity between 1 and 4
                        var actualQuantity = expectedQuantity;

                        // Introduce a discrepancy in some cases
                        if (random.NextDouble() < 0.2) // 20% chance
                            actualQuantity = random.Next(1, 5);

                        var roomInventory = new RoomInventory
                        {
                            Id = Guid.NewGuid(),
                            RoomId = room.Id,
                            InventoryItemId = item.Id,
                            ExpectedQuantity = expectedQuantity,
                            ActualQuantity = actualQuantity
                        };

                        modelBuilder.Entity<RoomInventory>().HasData(new
                        {
                            roomInventory.Id, roomInventory.RoomId, roomInventory.InventoryItemId,
                            roomInventory.ExpectedQuantity, roomInventory.ActualQuantity
                        });
                    }
                }
            }
        }
    }

    private List<Room> GenerateRooms(string floorPrefix)
    {
        var random = new Random();
        var rooms = new List<Room>();

        for (var i = 1; i <= 10; i++)
        {
            rooms.Add(new Room
            {
                Id = Guid.NewGuid(),
                Number = $"{floorPrefix}-{i:00}",
                AllowedPersons = random.Next(3, 6)
            });
        }

        return rooms;
    }
}