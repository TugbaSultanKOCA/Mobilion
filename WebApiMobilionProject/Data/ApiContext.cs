using Microsoft.EntityFrameworkCore;

namespace WebApiMobilionProject.Data
{
    public class ApiContext: DbContext
    {    
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer( @"Server =.; Database = ApiDb; Trusted_Connection=True; ConnectRetryCount=0");
            }
            //base.OnConfiguring(optionsBuilder);

           
        }
 
    }
}
