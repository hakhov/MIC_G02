double number = 123454.567;

Console.WriteLine(String.Format($"{number:N}"));
Console.WriteLine(String.Format($"{number:N1}"));
Console.WriteLine(String.Format($"{number:N2}"));
Console.WriteLine(String.Format($"{number:N3}"));
Console.WriteLine(String.Format($"{number:N4}"));
Console.WriteLine("---------------------------");
Console.WriteLine(String.Format($"{number:F}"));
Console.WriteLine(String.Format($"{number:F1}"));
Console.WriteLine(String.Format($"{number:F2}"));
Console.WriteLine("---------------------------");
Console.WriteLine(String.Format($"{number:e}"));

int number2 = 45;
Console.WriteLine(String.Format($"{number2:c}"));
Console.WriteLine(String.Format($"{number2:p}"));
Console.WriteLine("---------------------------");

Console.WriteLine(String.Format("{0:###0}",35));
Console.WriteLine(String.Format("{0:000#}",35.6));
Console.WriteLine(String.Format("{0:000.#}",35.6));
Console.WriteLine("---------------------------");

DateTime dateTime = DateTime.Now;
Console.WriteLine(string.Format($"{dateTime}"));
Console.WriteLine(string.Format($"{dateTime:D}"));
Console.WriteLine(string.Format($"{dateTime:d}"));
Console.WriteLine(string.Format($"{dateTime:G}"));
Console.WriteLine(string.Format($"{dateTime:T}"));
Console.WriteLine(string.Format($"{dateTime:t}"));
Console.WriteLine(string.Format($"{dateTime:tt}"));

Console.WriteLine(String.Format("{0:hh:mm:ss  -  MM yyyy}", dateTime));
Console.WriteLine(String.Format("{0:hh:mm:ss  -  MMM yyyy}", dateTime));
Console.WriteLine(String.Format("{0:hh:mm:ss  -  MMMM yyyy}", dateTime));
Console.WriteLine(String.Format("{0:hh:mm:ss  -  MMM yy}", dateTime));

Random random = new Random();

