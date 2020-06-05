using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string Credits { get; set; }
        public string Subject { get; set; }
        public List<Student> students { get; set; }
    }
}
