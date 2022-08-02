string s = null;
Console.WriteLine(s);
string.IsNullOrEmpty(s);
int? a = null;
Nullable<int> b = null;
Console.WriteLine(b.HasValue ? b.Value : "NO");

int? x1 = null;
int? x2 = null;
if (x1 == x2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
