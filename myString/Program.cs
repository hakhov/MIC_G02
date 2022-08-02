string s1 = "ABCD";
string s2 = "1234";
string s3 = string.Concat(s1, s2);
Console.WriteLine(string.Concat(s1, s2));
Console.WriteLine(s1 + s2);
Console.WriteLine($"{s1}{s2}");
Console.WriteLine((int)s1[0]);

string[] s4 = { "aaa", "bbb", "ccc", "ddd","yan" };
//char s = '.';
string s = "...";
string s5 = string.Join(s, s4);

Console.WriteLine(s5);

foreach (var item in s5)
{
    Console.Write(item);
}
Console.WriteLine();
Console.WriteLine(s5.EndsWith("yan"));
Console.WriteLine(s5.Insert(1,"Hello"));
Console.WriteLine(s5.IndexOf("bb"));
Console.WriteLine(s5.Substring(3));
Console.WriteLine(s5.Substring(0,5));
string x = s5.Substring(3);

