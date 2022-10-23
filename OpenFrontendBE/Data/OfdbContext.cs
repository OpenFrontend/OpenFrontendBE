using Microsoft.EntityFrameworkCore;
using OpenFrontendBE.Models;

namespace OpenFrontendBE.Data
{
    public class OfdbContext: DbContext
    {
        public OfdbContext(DbContextOptions<OfdbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } 
        public DbSet<User> Users { get; set; }

    }
}
