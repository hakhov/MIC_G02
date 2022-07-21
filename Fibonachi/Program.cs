Console.Write("Please insert count element for Fibonachi!");
int number = int.Parse(Console.ReadLine());

int element1 = 0;
int element2 = 1;

int fib = element1 + element2;

Console.Write(element1 + "\t" + element2 + "\t" + fib + "\t");

for (int i = 3; i < number; i++)
{
    element1 = element2;
    element2 = fib;
    fib = element1 + element2;
    Console.Write(fib + "\t");
}