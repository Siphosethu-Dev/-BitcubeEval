using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementWebApplication
{
    interface IPerson
    {
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
    }
}
