for (int i = 1; i < 30; i++)
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.SetCursorPosition(i *3-3, i - 1);
    Console.Write("Hello");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.SetCursorPosition(i * 3, i);
    Console.Write("Hello");
    Thread.Sleep(300);
}

Console.ResetColor();
