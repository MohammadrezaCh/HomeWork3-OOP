using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Professor:Person
    {
        public int ProfessorId { get; set; }
        public string? Subject { get; set; }
        public override string GetDetails()
        {
            return $"My name is {Name} with Professor Id : {ProfessorId} and I'm {Age} years old and Subject : {Subject} ";
        }
    }
}
