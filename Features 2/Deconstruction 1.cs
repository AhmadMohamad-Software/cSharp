using System;
class Program
{
    static void Main(string[] args)
    {
        var (FirstName, Age) = GetUserInfo(12);
    }

    public static (string,int) GetUserInfo(int id)
    {
        //some logic to get user info from DB
        string firstName = "ali";
        int age = 20;
        return (firstName,age);
    }
}
