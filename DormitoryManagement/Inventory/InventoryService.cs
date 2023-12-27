using DormitoryManagement.Data;
using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Inventory;

public class InventoryService(IDbContextFactory<DormitoryContext> contextFactory)
{
    public async Task<bool> CreateInventory(CreateInventoryRequest request)
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        var inventory = new InventoryItem()
        {
            Name = request.Name
        };

        await context.InventoryItems.AddAsync(inventory);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteInventory(Guid itemId)
    {
        await using var context = await contextFactory.CreateDbContextAsync();
        var item = await context.InventoryItems
            .SingleAsync(x => x.Id == itemId);
       
        
        context.InventoryItems.Remove(item);
        await context.SaveChangesAsync();
        return true; // Successfully deleted
        

     
    }

    public async Task<List<InventoryItem>> GetAllItems()
    {
        await using var context = await contextFactory.CreateDbContextAsync();
        var inventoryItems = await context.InventoryItems.ToListAsync();
        return inventoryItems;
    }
    
}