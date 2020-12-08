using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementWebApplication
{
    public class Course: Degree
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public Course(int elements) : base(elements)
        { 
        }
    }
}
