//Console.WriteLine("Please insert just number");
//int x = int.Parse(Console.ReadLine());

//switch (x)
//{
//    case 0:
//        Console.WriteLine(x * 10);
//        break;
//    case 4:
//        Console.WriteLine(x * 40);
//        break;
//    case 9:
//        Console.WriteLine(x * 90);
//        break;
//    default:
//        Console.WriteLine("Please insert correct number");
//        break;
//}

////Console.WriteLine("Hello");


//switch (x)
//{
//    case 0:
//    case 1:
//    case 3:
//        Console.WriteLine(x * 40);
//        break;
//    case 9:
//        Console.WriteLine(x * 90);
//        break;
//    default:
//        Console.WriteLine("Please insert correct number");
//        break;
//}

Console.WriteLine("Please choose Yes or No");
string text = Console.ReadLine();
switch (text)
{
    case "y":
    case "Y":
        Console.WriteLine("Yes");
        break;
    case "n":
    case "N":
        Console.WriteLine("No");
        break;
    default:
        Console.WriteLine("Please insert correct text");
        break;
}

Console.WriteLine("Is Prime"); Console.WriteLine("Is not Prime");