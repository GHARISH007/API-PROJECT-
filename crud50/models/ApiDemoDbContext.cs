using Microsoft.EntityFrameworkCore;


namespace crud50.models
{
    public class ApiDemoDbContext:DbContext
    {
        public ApiDemoDbContext(DbContextOptions<ApiDemoDbContext> options) : base(options)
        { }
        public DbSet<User> User { get; set; }
    }
}
   
