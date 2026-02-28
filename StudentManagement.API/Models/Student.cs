using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.API.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string StudentNumber { get; set; }

        public DateTime? BirthDate { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }
    }
}
