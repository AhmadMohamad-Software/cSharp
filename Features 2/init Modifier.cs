using System;
class Program
{
    public class Person
    {
        public string FirstName { get; init; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }

    static void Main(string[] args)
    {
        var person = new Person("John", "Doe", 30);
        Console.WriteLine(person.FirstName);
    }
}
