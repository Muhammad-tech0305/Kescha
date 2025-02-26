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
