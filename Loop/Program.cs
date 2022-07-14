//while..do
//do..while
//for
//foreach

//int n = 1;
//while (n < 10)
//{
//    Console.WriteLine($"Test + {n}");
//    n++;
//}
//Console.WriteLine("after circle");

//int n = 1;
//do
//{
//    Console.WriteLine($"Test + {n}");
//    n++;
//} while (n < 10);
//Console.WriteLine("after circle");

//int x = -5;

//while (x > 0)
//{
//    Console.WriteLine(x);
//}

//Console.WriteLine("----------------");

//do
//{
//    Console.WriteLine(x);

//} while (x > 0);

//for (int n = 1; n < 10; n++)
//{
//    int x = 0;
//    Console.WriteLine($"Test + {n}");
//}

//Console.WriteLine("after circle");

//for ( ;  ;  )
//{
//    Console.WriteLine("Test");
//}

//int x = 5;
//for (; x < 10;)
//{
//    Console.WriteLine("Test");
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 6)
//       break;
//    Console.WriteLine(i);
//}
//Console.WriteLine("END ");



//for (int i = 0; i < 10; i++)
//{
//    if (i == 6)
//       continue;
//    Console.WriteLine(i);
//}
//Console.WriteLine("END ");

//Gtnel erknish bolor zuyg tver@

//for (int i = 10; i < 100; i+=5)
//{
//    Console.WriteLine(i);
//}


int number;

do
{
    Console.Clear();
    Console.WriteLine("Plase insert 3 digits number");
    number = int.Parse(Console.ReadLine());
} while (number < 100 || number > 999);
Console.WriteLine("Avart");