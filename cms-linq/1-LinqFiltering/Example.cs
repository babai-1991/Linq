using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.UI.Models;

namespace cms_linq.LinqFiltering
{
    class Example
    {
        
        public static void Start()
        {
            
            //LinqWhere();

            LinqOfType();
        }

        /*
         * In the case of inheritance, we can have base class, derived class and multiple levels,
         * In such cases, you can use this OfType() operator in order to filter Asper your type.
         */
        private static void LinqOfType()
        {
            IEnumerable<EngineeringStudent> enggStudents = StudentList.FetchStudents().OfType<EngineeringStudent>();
            foreach (EngineeringStudent std in enggStudents)
            {
                Console.WriteLine(std.StudentId + " " + std.FirstName + " " + std.LastName);
            }
        }

        private static void LinqWhere()
        {
            //IEnumerable<Student> studentFilter = _students.Where(s => s.LastName == "Smith");
            IEnumerable<Student> studentFilter = StudentList.FetchStudents().Where(s => s.LastName.Equals("Smith"));
            foreach (Student std in studentFilter)
            {
                Console.WriteLine(std.StudentId + " " + std.FirstName + " " + std.LastName);
            }
        }

        
    }
}
