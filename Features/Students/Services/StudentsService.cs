using Microsoft.EntityFrameworkCore;
using my_school.Data.Contexts;
using my_school.Features.Students.Models.Entities;

namespace my_school.Features.Students.Services
{
    public class StudentsService
    {
        private readonly PostgreSqlContext _context;

        public StudentsService(PostgreSqlContext context)
        {
            _context = context;

        }

        public async Task<List<Student>> FetchAll()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
