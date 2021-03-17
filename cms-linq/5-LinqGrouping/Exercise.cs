using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.UI.Models;

namespace cms_linq._5_LinqGrouping
{
    class Exercise
    {
        private static List<Student> _students;
        private static List<Course> _courses;
        public static void Start()
        {
            _students = Data.FetchStudents();
            _courses = Data.FetchCourses();
            LingGroupBy();
            
        }


        private static void LingGroupBy()
        {
            //var query = from student in _students
            //            group student by student.CourseId;
            //foreach (var data in query)
            //{
            //    Console.WriteLine("Course Id: " + data.Key);
            //    foreach (var std in data)
            //    {
            //        Console.WriteLine(std.FirstName + " " + std.LastName + " course Id: " + std.CourseId);
            //    }
            //}

            var query = _students.GroupBy(s => s.CourseId);
            foreach (var data in query)
            {
                Console.WriteLine("Course Id: " + data.Key);
                foreach (var std in data)
                {
                    Console.WriteLine(std.FirstName + " " + std.LastName + " course Id: " + std.CourseId);
                }
            }
        }
    }
}
