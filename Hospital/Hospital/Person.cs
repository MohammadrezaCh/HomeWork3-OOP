using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Person
    {
        public Person(string name, int age, string nationalCode)
        {
            Name = name;
            Age = age;
            _nationalCode = nationalCode;
        }

        private string _nationalCode;
        public string Name { get; set; }
        public int Age { get; set; }
        public string NationalCode
        {
            get => _nationalCode; 
            set
            {
                if (_nationalCode.Length==10)
                {

                }
                else
                {
                    Console.WriteLine("please enter 10 characters");
                }
            }
        }
        
        public virtual string GetDetails()
        {
            return $"Im {Name} and {Age} yearsold with NationalCode {NationalCode}";
        }
    }
}
