using System;
class Program
{
    
    static void Main(string[] args)
    {
       object obj = 2;
       if (obj is int age)
       {
          Console.WriteLine("object is integer");
       }
    }
}
