// See https://aka.ms/new-console-template for more information
Console.Write("Please insert number!");
int number = int.Parse(Console.ReadLine());

ulong fac = 1;
for (int i = 1; i <= number; i++)
{
    fac *= (ulong)i;
}

Console.WriteLine($"Factorial for {number}! = {fac}");
