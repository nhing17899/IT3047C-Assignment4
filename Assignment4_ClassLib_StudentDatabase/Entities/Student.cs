using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4_ClassLib_StudentDatabase.Entities
{
    [Table("Students")]
    public class Student
    {
        public int StudentID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Class Of")]
        public int ClassOf { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        public int MajorID { get; set; }
        public int CourseID { get; set; }

        public virtual ICollection<Major> Majors { get; set; } = new List<Major>();
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
