using System;
class Program
{
    static void Main(string[] args)
    {
        PrintUserInfo(("ali",20));
    }

    public static void PrintUserInfo((string FirstName,int Age) user )
    {
        Console.WriteLine($"Your FirstName is : {user.FirstName}, Your Age {user.Age}");
    }
}
