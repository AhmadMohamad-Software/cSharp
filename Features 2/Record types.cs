using System;
class Program
{
    public record Person(string FirstName,int Age);
    static void Main(string[] args)
    {
        Person p1 = new("ali", 22);
        //create new record object with modified properties
        Person p2 = p1 with { FirstName="ahmad",Age = 25 };
        Console.WriteLine($"first name : {p2.FirstName} your age {p2.Age}");
    }
}
