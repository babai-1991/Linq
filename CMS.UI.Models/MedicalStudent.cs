namespace CMS.UI.Models
{
    public class MedicalStudent : Student
    {
        public MedicalStudent(int studentId, string firstName, string lastName,string courseid) : base(studentId, firstName, lastName, courseid)
        {
        }
    }
}