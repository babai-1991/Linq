using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.UI.Models;

namespace cms_linq._6_LinqElements
{
    public class Exercise
    {
        private static List<Student> _students;
        private static List<Course> _courses;

        public static void Start()
        {
            _students = Data.FetchStudents();
            _courses = Data.FetchCourses();
            //LinqElementAt();
            //LinqElementAtOrDefault();
            //LinqFirst();
            //LinqFirstOrDefault();
            LinqSingle();
        }


        private static void LinqSingle()
        {
            //similar to First() and FirstorDefault() or Last() and LastOrDefault() we have Single() and SingleOrDefault()
        }


        //similarly we have LastOrDefault()
        private static void LinqFirstOrDefault()
        {
            Student student = _students.FirstOrDefault(s => s.CourseId == "UD101");
            Console.WriteLine($"{student.FirstName} {student.LastName} {student.CourseId}");
            student = _students.FirstOrDefault(s => s.CourseId == "UD1011");

            Console.WriteLine(student != null
                ? $"{student.FirstName} {student.LastName} {student.CourseId}"
                : "Data not found");
        }

        //similarly we have Last()
        private static void LinqFirst()
        {
            Student student = _students.First(s => s.CourseId == "UD101");
            Console.WriteLine($"{student.FirstName} {student.LastName} {student.CourseId}");
            student = _students.First(s => s.CourseId == "UD1011"); //invalid-operation exception
            Console.WriteLine($"{student.FirstName} {student.LastName} {student.CourseId}");

        }

        private static void LinqElementAtOrDefault()
        {
            Student student = _students.ElementAtOrDefault(20);
            if (student == null)
            {
                Console.WriteLine("Please search again");
                student = _students.ElementAtOrDefault(0);
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.CourseId}");

            }
        }

        private static void LinqElementAt()
        {
            //ElementAt() return an element with specified index
            Student student = _students.ElementAt(0);
            Console.WriteLine($"{student.FirstName} {student.LastName} {student.CourseId}");
            try
            {
                Student anotherStudent = _students.ElementAt(20); // no students at that given index
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
