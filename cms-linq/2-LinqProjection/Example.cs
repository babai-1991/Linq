using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.UI.Models;

namespace cms_linq._2_LinqProjection
{
    public class Example
    {
        public static void Start()
        {
            //LinqSelect();
            //LinqSelectVariant();
            LinqSelectAnonymous();
        }

        private static void LinqSelectAnonymous()
        {
            var students = StudentList.FetchStudents().Select(stdnt => new
            {
                ID = stdnt.StudentId,
                FullName = stdnt.FirstName + " " + stdnt.LastName
            });

            foreach (var student in students)
            {
                Console.WriteLine($"Student Id {student.ID} FullName is {student.FullName}");
            }
        }

        //only get specific property
        private static void LinqSelectVariant()
        {
            var students = StudentList.FetchStudents().
                                                    Select(stdnt => (stdnt.StudentId, stdnt.FirstName));
            foreach (var student in students)
            {
                Console.WriteLine($"Student Name: {student.FirstName} id {student.StudentId}");
            }
        }

        private static void LinqSelect()
        {
            IEnumerable<Student> students = StudentList.FetchStudents().Select(s => s);
            foreach (var student in students)
            {
                Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}");
            }
        }
    }
}
