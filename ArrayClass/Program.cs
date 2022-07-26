int[] arr1 = { 10, 20, 30, 40, 50, 40, 80, 90,40 };
int[] arr2 = { 10, 20, 30, 40, 50 };

for (int i = 0; i < arr1.Length; i++)
{
    Console.WriteLine("{0}", arr1[i]);
}

Console.WriteLine(new string('-', 50));

//Array.Clear(arr,2,2);

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine("{0}", arr[i]);
//}

Console.WriteLine(arr1.Equals(arr2));

int[] arr3 = arr2;
Console.WriteLine(arr3.Equals(arr2));

arr3[3] = -100;
Console.WriteLine(new string('-', 50));

for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine("{0}", arr2[i]);
}

Console.WriteLine(new string('-', 50));

int index = Array.LastIndexOf(arr1,40);
Console.WriteLine(index);

Array.Sort(arr1);
Array.Reverse(arr1);
Console.WriteLine(new string('-', 50));

for (int i = 0; i < arr1.Length; i++)
{
    Console.WriteLine("{0}", arr1[i]);
}
