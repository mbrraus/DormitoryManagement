namespace DormitoryManagement.Data.Models;

public class RoomInventory
{
    public required Guid Id { get; set; }
    public required Guid RoomId { get; set; }
    public required Guid InventoryItemId { get; set; }
    public required int ExpectedQuantity { get; set; }
    public required int ActualQuantity { get; set; }

    public virtual Room Room { get; set; } = null!;
    public virtual InventoryItem InventoryItem { get; set; } = null!;
}