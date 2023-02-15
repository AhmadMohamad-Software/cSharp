using System;

public class Program
{
    public class Person
    {
        public string Name { set; get; }
        public int? Age { set; get; }
    }
    public static void Main()
    {
        Person me = new Person();
        me.Name = "ahmad mohamad";
        me.Age = null;
        Console.WriteLine($"Your name {me.Name}, your age {me.Age}");
    }
}