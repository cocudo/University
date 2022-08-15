using Microsoft.EntityFrameworkCore;
using universityApiBackend.Models.DataModels;

namespace universityApiBackend.DataAccess
{
    public class UniversityDbContext : DbContext
    {

        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {

        }

        //TODO Add DBSets (Tables of our database)

        public DbSet<User>? Users { get; set; }
    }
}
