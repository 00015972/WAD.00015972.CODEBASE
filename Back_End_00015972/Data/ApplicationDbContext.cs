using Microsoft.EntityFrameworkCore;
using Back_End_00015972.Models;

/*  My Studen ID: 00015972   */

namespace Back_End_00015972.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<KeyItem_00015972> KeyItems { get; set; } // The KeyItems table
    }
}
