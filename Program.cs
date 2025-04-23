using System;
using Kescha.Classes;
class Program
{
    static void Main()
    {
        Animal kescha = new Animal("Kesha", 3);
        kescha.Greeting();
        Console.WriteLine(kescha.Name);
        Console.WriteLine(kescha.Age);
        Console.WriteLine(kescha.AgeDifference(22));
        kescha.Compare();
        kescha.FriendsKeschas();
    }
}