int[] arr = new int[10];
//int[] arr1 = { 1, 8, 9, 10, 2, 3, 5 };
//string[] arr3 = { "AAA", "BBB","Cddsfsdf"};
//arr[0] = 1;
//arr[1] = 2;
//arr[2] = 3;
//arr[8] = 4;
//Console.WriteLine(arr[1]);
//Console.WriteLine(arr[9]);

for (int i = 0; i < 10; i++)
{
    // Console.Write($"arr[{i}] = ");
    arr[i] = int.Parse(Console.ReadLine());
}

arr.Append(100);

for (int i = 0; i < 11; i++)
{
    Console.WriteLine(arr[i]);
}