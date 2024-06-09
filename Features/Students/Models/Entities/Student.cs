using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace my_school.Features.Students.Models.Entities
{
    [Table("students")]
    [Index(nameof(Name), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }


        [Required]
        [Column("name")]
        [StringLength(50)]
        public required string Name { get; set; }


        [Required]
        [Column("class_id")]
        public required int ClassId { get; set; }
        [StringLength(50)]
        [Required]
        [EmailAddress]
        [Column("email")]
        public required string Email { get; set; }

        [Required]
        [StringLength(100)]
        [Column("address")]
        public required string Address { get; set; }
    }
}
