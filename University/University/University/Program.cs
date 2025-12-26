namespace University
{
    internal class Program
    {
        static void Main(string[]args)
        {
            List<Person> people = new List<Person>
            {new Student
            {
                Name = "ali",
                Age = 21,
                StudentId = 1001,
                Major = "Software Engineer"
            },
            new Professor
            {
                Name = "Dr Soheili",
                Age = 45,
                ProfessorId = 2001,
                Subject = "Database Manager"
            },
            new Student
            {
                Name = "Mohammad",
                Age = 33,
                StudentId = 1002,
                Major = "Software Engineer"
            },
            new Professor
            {
                Name = "Dr Taheri",
                Age = 55,
                ProfessorId = 2002,
                Subject = "Developer"
            }
            };
            foreach (Person person in people)
            {
                Console.WriteLine(person.GetDetails());
            }
        }
    }
}
