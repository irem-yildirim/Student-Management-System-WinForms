using System.ComponentModel.DataAnnotations;

namespace StudentManagement.API.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CourseName { get; set; }

        [Required]
        [MaxLength(50)]
        public string CourseCode { get; set; }
    }
}
