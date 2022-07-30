int[,] arr = new int[4, 5];
//int[,] arr1 =
//{
//    {0, 0, 0},
//    {1, 1, 1},
//    {2, 2, 2},
//    {3, 3, 3},
//};

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"arr[{i},{j}] = ");
//        arr[i, j] = int.Parse(Console.ReadLine());
//    }
//}

Random r = new();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = r.Next(-20,30);
        Console.Write($"{arr[i,j]}\t");
       
    }
    Console.WriteLine();
}
