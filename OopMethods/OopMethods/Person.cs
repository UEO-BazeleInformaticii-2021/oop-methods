using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public void SayHello()
        {
            SayHello("Hello, my name is:");
        }

        public void SayHello(string introductionFormula)
        {
            Console.WriteLine($"{introductionFormula} {FullName}");
        }

        public int GetAge()
        {
            return DateTime.Today.Year - DateOfBirth.Year;
        }
    }
}
