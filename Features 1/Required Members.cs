using System;

public class Program
{
    public class Person
    {
        public required string Name { set; get; }
        public required int? Age { set; get; }
    }
    public static void Main()
    {
        Person me = new Person
        {
            Name ="ahmad mohamad",
            Age =20
        };
        
        Console.WriteLine($"Your name {me.Name}, your age {me.Age}");
    }
}