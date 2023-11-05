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
}