using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayBirthday
{
    internal class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student(string lastName, string firstName, string middleName, DateTime dateOfBirth)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
