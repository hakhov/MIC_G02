using System.Collections;

ArrayList arrayList = new();
arrayList.Add(10);
arrayList.Add(20);
arrayList.Add(5);
arrayList.Add(5.9);
arrayList.Add("Hello");
arrayList.AddRange(new string[] { "ssad","ads","dsads"});
arrayList.AddRange(new int[] { -50, -50, -60 });
Console.WriteLine("//////////////////////");
Console.WriteLine(arrayList.Count);
Console.WriteLine("//////////////////////");

//for (int i = 0; i < arrayList.Count; i++)
//{
//    Console.WriteLine(arrayList[i]);
//}

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

//arrayList.Clear();
arrayList.RemoveAt(0);
Console.WriteLine("//////////////////////");
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}