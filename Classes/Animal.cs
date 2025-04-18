using System;

namespace Kescha.Classes
{
   class Animal
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

   }
}