using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student:Person
    {
        public required int StudentId { get; set; }
        public string? Major { get; set; }
        public override string GetDetails()
        {
            return $"My name is {Name} with student Id : {StudentId} and I'm {Age} years old and Major : {Major} ";
        }
    }
}
