// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Zadej kolik ti je");
string prectenyRadek = Console.ReadLine();  
int vek = Convert.ToInt32(prectenyRadek);
int odchodDoDuchodu = 67 - vek;
if(vek > 65)
{
    Console.WriteLine("Jses boomer");
}
else
{
    Console.WriteLine(" Ještě něco chybí ..." + odchodDoDuchodu);
}