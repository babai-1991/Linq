using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.UI.Models;

namespace cms_linq.LinqFiltering
{
    class TestPilot
    {
        static List<Student> _students = new List<Student>();
        public static void Start()
        {
            InitializeData();

            //LinqWhere();

            LinqOfType();
        }

        /*
         * In the case of inheritance, we can have base class, derived class and multiple levels,
         * In such cases, you can use this OfType() operator in order to filter Asper your type.
         */
        private static void LinqOfType()
        {
            IEnumerable<EngineeringStudent> enggStudents = _students.OfType<EngineeringStudent>();
            foreach (EngineeringStudent std in enggStudents)
            {
                Console.WriteLine(std.StudentId + " " + std.FirstName + " " + std.LastName);
            }
        }

        private static void LinqWhere()
        {
            //IEnumerable<Student> studentFilter = _students.Where(s => s.LastName == "Smith");
            IEnumerable<Student> studentFilter = _students.Where(s => s.LastName.Equals("Smith"));
            foreach (Student std in studentFilter)
            {
                Console.WriteLine(std.StudentId + " " + std.FirstName + " " + std.LastName);
            }
        }

        private static List<Student> InitializeData()
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
