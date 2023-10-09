using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Data;

public class DormitoryContext(DbContextOptions<DormitoryContext> options) : DbContext(options)
{
    public required DbSet<TestRoom> TestRooms { get; set; }
}