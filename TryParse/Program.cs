//string s = null;
////int x = int.Parse(s);
////int x = Convert.ToInt32(s);
//int x;
//bool t = int.TryParse(s, out x);
//Console.WriteLine(x);
//Console.WriteLine(t);

while (true)
{
    Console.Clear();
    Console.WriteLine("Please insert just number with 3 digiths");
    Console.Write("Number is = ");

    string txt = Console.ReadLine();

    if (int.TryParse(txt, out int result) && result > 99 &&result<1000)
    {
        Console.WriteLine($"Our result is {result}");
        break;
    }
}
