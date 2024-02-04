using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4_ClassLib_StudentDatabase.Entities
{
    [Table("Majors")]
    public class Major
    {
        public int MajorID { get; set; }
        [DisplayName("Major Name")]
        public string MajorName { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
