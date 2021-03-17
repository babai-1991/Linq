using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class EngineeringStudent:Student
    {
        public EngineeringStudent(int studentId, string firstName, string lastName) : base(studentId, firstName, lastName)
        {
        }
    }
}
