//Console.WriteLine("1");
//Console.WriteLine("2");
//a:
//Console.WriteLine("3");
//Console.WriteLine("4");
//Console.WriteLine("5");
//goto a;
//Console.WriteLine("6");
//Console.WriteLine("7");

int a = 5;
jump:
if(a>0)
{
    Console.WriteLine(a);
    //a--;
    goto jump;
}
Console.WriteLine("after GoTo");
