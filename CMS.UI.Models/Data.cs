using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class StudentList
    {
        static List<Student> _students;
        public static List<Student> FetchStudents()
        {
            _students = new List<Student>()
            {
                new EngineeringStudent(101, "James", "Smith"),
                new EngineeringStudent(102, "Robert", "Smith"),
                new MedicalStudent(103, "Maria", "Rodriguez"),
                new EngineeringStudent(104, "David", "Smith"),
                new MedicalStudent(105, "James", "Johnson"),
                new EngineeringStudent(106, "James", "SevenLast"),
                new MedicalStudent(107, "Maria", "Garcia"),
                new MedicalStudent(108, "Mary", "Smith")
            };
            return _students;
        }
    }
}
