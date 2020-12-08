using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementWebApplication
{
    public class Degree:Lecturer
    {
        public string DegreeName { get; set; }
        public int Duration { get; set; }
        public string[] Courses { get; set; }

        public Degree(int elements) :base(elements)
        {
            Courses = new string[elements];
        }

    }
}
