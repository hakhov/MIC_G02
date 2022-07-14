int x = int.Parse(Console.ReadLine());

int m = x % 10;//->352%10=35.2->2
int h = x / 100;//352/100=3.52->3
int t = x / 10 % 10;//352/10=35.2->35%10=3.5->5

Console.WriteLine(h);
Console.WriteLine(t);
Console.WriteLine(m);