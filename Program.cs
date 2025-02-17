using System;

Console.Write("Salom, mening ismim Kesha. Siznikichi?\n>>> ");
string ism = Console.ReadLine();
Console.Write("Xush kelibsiz " + ism + ", yoshingiz nechada?\n>>> ");
int yosh = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Meniki 3 da, yoshimiz farqi {yosh - 3} yosh ekan." );
