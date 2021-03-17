using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.UI.Models;

namespace cms_linq._4_LinqJoin
{
    class Exercise
    {
        private static List<Student> _students;
        private static List<Course> _courses;
        public static void Start()
        {
            _students = Data.FetchStudents();
            _courses = Data.FetchCourses();
            //LinqJoinOperator();
            LinqGroupJoin();
        }

        //one to many 
        //or many to many
        //similar like left outer , right outer join
        private static void LinqGroupJoin()
        {
            //var query = from course in _courses
            //    join student in _students
            //        on course.Id equals student.CourseId
            //        into courseStudents
            //    select new
            //    {
            //        CourseName = course.Name,
            //        EnrolledStudent = courseStudents
            //    };

            //foreach (var data in query)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine($"Course Name : {data.CourseName}");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    foreach (Student std in data.EnrolledStudent)
            //    {
            //        Console.WriteLine($"Student Id: {std.StudentId} Student Name: {std.FirstName+" "+std.LastName}");
            //    }
            //}


            // Method syntax is exactly similar to Join

            var query = _courses.GroupJoin(_students,
                course => course.Id,
                student => student.CourseId,
                (c, courseStudents) =>
                    new
                    {
                        CourseName = c.Name,
                        EnrolledStudent = courseStudents
                    });

            foreach (var data in query)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Course Name : {data.CourseName}");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var std in data.EnrolledStudent)
                {
                    Console.WriteLine($"Student Id: {std.StudentId} Student Name: {std.FirstName + " " + std.LastName}");
                }
            }
        }

        //one to one
        //inner join
        private static void LinqJoinOperator()
        {
            //query operator easy on joins
            //var query = from student in _students
            //            join course in _courses
            //                on student.CourseId equals course.Id
            //            select new
            //            {
            //                StudentId = student.StudentId,
            //                Name = student.FirstName + " " + student.LastName,
            //                CourseName = course.Name
            //            };
            //foreach (var data in query)
            //{
            //    Console.WriteLine($"StudentId {data.StudentId} Name {data.Name} Enrolled for {data.CourseName}");
            //}

            //method syntax
            /*join method takes 4 input ,
             1. the collection on which I perform join
             2. second parameter is property of the first collection
             3. third parameter is the property of the second collection
             4. last parameter will be the final result
             */

            var query = _students.Join(_courses, std => std.CourseId, cor => cor.Id, (st, crs) => new
            {
                StudentId = st.StudentId,
                Name = st.FirstName + " " + st.LastName,
                CourseName = crs.Name
            });
            foreach (var data in query)
            {
                Console.WriteLine($"StudentId {data.StudentId} Name {data.Name} Enrolled for {data.CourseName}");
            }
        }
    }
}
