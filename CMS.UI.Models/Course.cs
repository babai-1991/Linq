using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class Course
    {
        public Course(string id, string name)
        {
            Id = id;
            Name = name;
           
        }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
