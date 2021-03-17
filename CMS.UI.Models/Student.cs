using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public abstract class Student
    {
        protected Student(int studentId, string firstName, string lastName,string courseId)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            CourseId = courseId;
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CourseId { get; set; }

    }
}
