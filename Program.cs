﻿using System;
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
    }
}



<<<<<<< HEAD
=======
// Kesha bilan yosh farqi
Console.Write("Salom, mening ismim Kesha. Siznikichi?\n>>> ");
string ism = Console.ReadLine();
Console.Write("Xush kelibsiz " + ism + ", yoshingiz nechada?\n>>> ");
int yosh = Convert.ToInt32(Console.ReadLine());
// taqqoslash
Console.WriteLine($"Meniki 3 da, yoshimiz farqi {yosh - 3} yosh ekan." );
Console.WriteLine($"Siz Keshadan kattami?\n>>> {yosh > 3}");
Console.WriteLine($"Siz Keshadan kichikmi?\n>>> {yosh < 3}");
Console.WriteLine($"Siz Kesha bilan tengdoshmi?\n>>> {yosh == 3}");
// shartlash
if (yosh < 3)
{
    Console.WriteLine("Siz Keshadan kichik.");
}
else if (yosh == 3)
{
    Console.WriteLine("Siz Kesha bilan tengdosh.");
}
else
{
    Console.WriteLine("Siz Keshadan katta.");
} 
// ternar operatori
string message = 
    (yosh-3)>0 || (yosh-3)==0
    ?"Siz Keshadan kichik emas."
    :"Siz Keshadan kichik.";
 Console.WriteLine(message);
// array operator
string[] friends = { "Vasya", "Kasee", "Valya" };
int[] ages = { 1, 2, 2 };
Console.WriteLine($"Keshaning {friends[0]}, {friends[1]} va {friends[2]} degan do\'stlari bor.\nUlardan {friends[0]} {ages[0]} yoshda, {friends[1]} {ages[1]} yoshda va {friends[2]} {ages[2]} yoshda.");
// for and foreach
for (int index = 0; index < friends.Length; index ++)
{
    Console.WriteLine($"{friends[index]} {ages[index]} yoshda.");
}
>>>>>>> ef4689fbd3d6e98475eee5fbbf0868f6f6d7deba
