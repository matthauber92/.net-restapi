using Microsoft.EntityFrameworkCore;

namespace ToDo.RestApi.Database
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
