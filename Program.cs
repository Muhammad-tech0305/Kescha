using System;

// Kesha bilan yosh farqi
Console.Write("Salom, mening ismim Kesha. Siznikichi?\n>>> ");
string ism = Console.ReadLine();
Console.Write("Xush kelibsiz " + ism + ", yoshingiz nechada?\n>>> ");
int yosh = Convert.ToInt32(Console.ReadLine());
// taqqoslash
Console.WriteLine($"Meniki 3 da, yoshimiz farqi {yosh - 3} yosh ekan." );
Console.WriteLine($"Siz Keshadan kattami?\n>>> {yosh > 3}");
Console.WriteLine($"Siz Keshadan kichikmi?\n>>> {yosh < 3}");
Console.WriteLine($"Siz Kesha bilan tengdoshmi>\n>>> {yosh == 3}");

