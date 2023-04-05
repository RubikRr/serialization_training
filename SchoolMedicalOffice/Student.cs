using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMedicalOffice
{
   internal class Student
    {
        public string LastName { get; set; }
        public string Class { get; set; }
        public string Reason { get; set; }

        public Student(string lastName, string @class, string reason)
        {
            LastName = lastName;
            Class = @class;
            Reason = reason;
        }
    }
}
