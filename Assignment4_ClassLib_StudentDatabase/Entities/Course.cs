using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4_ClassLib_StudentDatabase.Entities
{
    [Table("Courses")]
    public class Course
    {
        public int CourseID { get; set; }
        [DisplayName("Phone Number")]
        public string CourseName { get; set; }
        [DisplayName("Course Name")]
        public string Professor { get; set; }
        public string Schedule { get; set; }
        public int StudentID { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
        public virtual ICollection<Major> Majors { get; set; } = new List<Major>();

    }
}
