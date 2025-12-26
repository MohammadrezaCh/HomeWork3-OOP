using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Person
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public virtual string GetDetails()
        {
           return ($"My name is {Name} and I'm {Age} years old");
        }
    }
}
