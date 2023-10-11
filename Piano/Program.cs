   
Console.WriteLine("Весёлая пианинка приветствует Вас!");
Console.WriteLine("Чтобы переключаться между октавами, Вам необходимо использовать клавиши F1, F2, F3");
Console.WriteLine("Белые клавиши - Q, E, T, U, O, A,");
Console.WriteLine("Черные клавиши - W, R, Y, I, P,S");

Octave();

static void Octave()
{


    int[] FirstOctave = new int[12] { 440, 493, 523, 587, 659, 698, 783, 880, 987, 1046, 1174, 1318 };
    int[] SecondOctave = new int[12] { 880, 987, 1046, 1174, 1318, 1396, 1567, 1760, 1975, 2093, 2349, 2637 };
    int[] ThirdOctave = new int[12] { 1760, 1975, 2093, 2349, 2637, 2793, 3135, 3520, 3951, 4186, 4699, 5274 };
    int[] dopOctave = FirstOctave;

    do
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.F1)
        {
            Console.WriteLine("\n Первая октава");
            dopOctave = FirstOctave;
        }
        else if (key.Key == ConsoleKey.F2)
        {
            Console.WriteLine("\n Вторая октава");
            dopOctave = SecondOctave;
        }
        else if (key.Key == ConsoleKey.F3)
        {
            Console.WriteLine("\n Третья октава");
            dopOctave = ThirdOctave;
        }
        Zvuk(key, dopOctave);
    }
    while (true);


}

static void Zvuk(ConsoleKeyInfo key, int[] dopOctave)
{
    switch (key.Key)
    {
        case ConsoleKey.Q:
            Console.Beep(dopOctave[0], 300);
            break;
        case ConsoleKey.W:
            Console.Beep(dopOctave[1], 300);
            break;
        case ConsoleKey.E:
            Console.Beep(dopOctave[2], 300);
            break;
        case ConsoleKey.R:
            Console.Beep(dopOctave[3], 300);
            break;
        case ConsoleKey.T:
            Console.Beep(dopOctave[4], 300);
            break;
        case ConsoleKey.Y:
            Console.Beep(dopOctave[5], 300);
            break;
        case ConsoleKey.U:
            Console.Beep(dopOctave[6], 300);
            break;
        case ConsoleKey.I:
            Console.Beep(dopOctave[7], 300);
            break;
        case ConsoleKey.O:
            Console.Beep(dopOctave[8], 300);
            break;
        case ConsoleKey.P:
            Console.Beep(dopOctave[9], 300);
            break;
        case ConsoleKey.A:
            Console.Beep(dopOctave[10], 300);
            break;
        case ConsoleKey.S:
            Console.Beep(dopOctave[11], 300);
            break;
    }
}
