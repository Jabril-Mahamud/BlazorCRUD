using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorCRUD.Models;

namespace BlazorCRUD.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BlazorCRUD.Robot> Robot { get; set; } = default!;

        public DbSet<History> History { get; set; } = default!;

    }
}
