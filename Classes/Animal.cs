using System;
namespace Kescha.Classes
{
   class Animal : IAnimal
   {
      public string Name {get ; set;}
      public int Age {get; set;}
      public Animal(string animalName, int animalAge)
      {
         Name = animalName;
         Age = animalAge;
      }
      public void Greeting()
      {
         Console.Write("Ismingiz nima: ");
         string userName = Console.ReadLine();
         Console.WriteLine($"Salom {userName}, mening ismim {Name}!");
         Console.Write("Yoshingiz nechada: ");
         int userAge = int.Parse(Console.ReadLine());
         Console.WriteLine($"Zo'r! Meniki {Age} da.");
      }
      public int AgeDifference(int userAge)
      {
         return userAge - Age;
      }
      public void Compare()
      {
         Console.Write("Yoshingiz nechada: ");
         int yosh = int.Parse(Console.ReadLine());
         Console.WriteLine($"Meniki 3 da, yoshimiz farqi {yosh - 3} yosh ekan." );
         Console.WriteLine($"Siz Keshadan kattami?\n>>> {yosh > 3}");
         Console.WriteLine($"Siz Keshadan kichikmi?\n>>> {yosh < 3}");
         Console.WriteLine($"Siz Kesha bilan tengdoshmi?\n>>> {yosh == 3}");
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
      }
      public void FriendsKeschas()
      {
         string[] friends = { "Vasya", "Kasee", "Valya" };
         int[] ages = { 1, 2, 2 };
         Console.WriteLine($"Keshaning {friends[0]}, {friends[1]} va {friends[2]} degan do\'stlari bor.\nUlardan {friends[0]} {ages[0]} yoshda, {friends[1]} {ages[1]} yoshda va {friends[2]} {ages[2]} yoshda.");
         for (int index = 0; index < friends.Length; index ++)
         {
            Console.WriteLine($"{friends[index]} {ages[index]} yoshda.");
         }
      }
   }
   class Bird : Animal
   {
      public Bird(string name, int age) : base(name, age){}
   }
  
}