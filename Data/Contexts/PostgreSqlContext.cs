using Microsoft.EntityFrameworkCore;
using my_school.Features.Students.Models.Entities;

namespace my_school.Data.Contexts
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
