using System;
using System.ComponentModel.DataAnnotations;

namespace CourseManagement.Api.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;

        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}