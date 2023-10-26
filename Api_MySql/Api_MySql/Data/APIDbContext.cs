using Api_MySql.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_MySql.Data
{
    public class APIDbContext : DbContext
    {
       public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) 
        {
        
        }
        
        public DbSet<Estado> Estado { get; set; }       
    }
}
