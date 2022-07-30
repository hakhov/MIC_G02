Random r = new();

int temp = r.Next(3, 15);
int n = temp % 2 == 0 ? temp + 1 : temp;
int[,] arr = new int[n, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = r.Next(-20, 30);
        //Console.Write($"{arr[i, j]}\t");

    }
    // Console.WriteLine();
}

Console.WriteLine(new String('_', 50));
int[] arrI = new int[n];
int[] arrJ = new int[n];

int index = 0;
for (int i = 0; i < n; i++)
{
    for (int j = n - 1 - i; j < n - i; j++)
    {
        arrI[index] = i;
        arrJ[index] = j;
        index++;
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i == arrI[i] && j == arrJ[i])
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ResetColor();
        }
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}