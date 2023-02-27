using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeStoreCollab.Pages
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public string? StudentEmail { get; set;}
        public DateTime Enrolldate { get; set; }
        public List<Course> EnrolledCourse { get; set; }
    }

    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CourseSeats { get; set; }
        [ForeignKey("Student.Id")]
        public int StudentId { get; set; }
    }
}
