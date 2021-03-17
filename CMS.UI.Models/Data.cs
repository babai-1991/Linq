using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class Data
    {
        static List<Student> _students;
        private static List<Course> _courses;
        public static List<Student> FetchStudents()
        {
            _students = new List<Student>()
            {
                new EngineeringStudent(101, "James", "Smith","UD101"),
                new EngineeringStudent(102, "Robert", "Smith","UD102"),
                new MedicalStudent(103, "Maria", "Rodriguez","UD104"),
                new EngineeringStudent(104, "David", "Smith","UD103"),
                new MedicalStudent(105, "James", "Johnson","UD104"),
                new EngineeringStudent(106, "James", "SevenLast","UD101"),
                new MedicalStudent(107, "Maria", "Garcia","UD104"),
                new MedicalStudent(108, "Mary", "Smith","UD106")
            };
            return _students;
        }

        public static List<Course> FetchCourses()
        {
            _courses = new List<Course>()
            {
                new Course("UD101", "B.TECH"),
                new Course("UD102", "B.ARCH"),
                new Course("UD103", "B.E"),
                new Course("UD104", "M.B.B.S"),
                new Course("UD105", "B.D.S"),
                new Course("UD106", "B.PHARM")
            };
            return _courses;
        }
    }
}
