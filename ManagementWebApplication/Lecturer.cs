using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementWebApplication
{
    public class Lecturer: IPerson
    {

        public string _forenames;
        public string _surname;
        public string _emailAddress;
        public DateTime _dateOfBirth;
        public string _firstName;
        public string _fullName;

        public string[] Degrees { get; set; }


        public Lecturer(int elements)
        {
            Degrees = new string[elements];
        }

        public string Forenames
        {
            get{ return _forenames; }

            set{_forenames = value;}
        }
        public string Surname
        {
            get { return _surname; }

            set { _surname = value; }
        }
        public string EmailAddress
        {
            get { return _emailAddress; }

            set { _emailAddress = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }

            set { _dateOfBirth = value; }
        }
        public string FirstName
        {
            get { return _firstName; }

            set { _firstName = value; }
        }

        public string FullName
        {
            get { return _fullName; }

            set { _fullName = value; }
        }


    }
}
