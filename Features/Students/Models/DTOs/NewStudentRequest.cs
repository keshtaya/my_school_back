using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace my_school.Features.Students.Models.DTOs
{
    public class NewStudentRequestModel
    {
        [Required]
        [StringLength(50)]
        [FromForm (Name="اسم الطالب")]
        public required String Name { get; set; }

        [Required]
        [FromForm(Name = "كود الفصل")]
        public required int classId { get; set; }

        [Required]
        [StringLength(50)]
        [FromForm (Name = "البريد الالكتروني")]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [StringLength(100)]
        [FromForm (Name = "عنوان الطالب")]
        public required string Address { get; set; }


    }
}
