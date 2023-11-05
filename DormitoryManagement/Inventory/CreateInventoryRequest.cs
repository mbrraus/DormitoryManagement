using System.ComponentModel.DataAnnotations;

namespace DormitoryManagement.Inventory;

public class CreateInventoryRequest
{
    [Required] public string Name { get; set; } = null!;
}