
using Microsoft.EntityFrameworkCore;
using Repository_Pattern_CRUD.Models;

namespace Repository_Pattern_CRUD.Data
{
    public class ApplicationDB:DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options):base(options)
        {
            
        }

        DbSet<User> Users { get; set; } 
    }
}
