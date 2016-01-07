using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirst.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string InstructorName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
