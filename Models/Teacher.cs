using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseManagement.Api.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = "";

        public string? Email { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}