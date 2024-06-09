using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using my_school.Data.Contexts;
using my_school.Features.Students.Models.DTOs;
using my_school.Features.Students.Models.Entities;

namespace my_school.Features.Students.Services
{
    public class NewStudentService
    {
        private readonly PostgreSqlContext _context;

        public NewStudentService(PostgreSqlContext context)
        {
            _context = context;

        }
        public async Task<Student> Register(NewStudentRequestModel model)
        {
            var newStudent = new Student
            {

                Name = model.Name,
                ClassId = model.classId,
                Email = model.Email,
                Address = model.Address
            };

            var result = await _context.Students.AddAsync(newStudent);
            _context.SaveChanges();
            return result.Entity;

        }

        private async Task<bool> IsStudentExist(string email)
        {

            Student? checkResult = await _context.Students.FirstOrDefaultAsync(s => s.Email == email);
            return checkResult != null;
        }
    }
}
