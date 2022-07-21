//Console.BackgroundColor = ConsoleColor.White;
string digit = "";
for (int i = 1; i <10; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = (ConsoleColor)j;
        Console.SetCursorPosition((j - 1) * 14, i);
        digit = (i * j).ToString();
        switch (digit.Length)
        {
            case 1:
                digit += "   ";
                break;
            case 2:
                digit += "  ";
                break;
        }
        Console.Write($"{j} x {i} = {digit}");
    }
    digit = "";
    Console.WriteLine();
}

for (int i = 1; i <10; i++)
{
    for (int j = 6; j <=10; j++)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = (ConsoleColor)j;
        Console.SetCursorPosition((j - 6) * 14, 12 + i);
        digit = (i * j).ToString();
        switch (digit.Length)
        {
            case 1:
                digit += "   ";
                break;
            case 2:
                digit += "  ";
                break;
        }
        Console.Write($"{j} x {i} = {digit}");
    }
    digit = "";
    Console.WriteLine();
}

Console.ResetColor();
