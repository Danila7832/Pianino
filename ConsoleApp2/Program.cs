using System;

internal class Program
{
    static ConsoleKey key;

    static int[] fifthactave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
    static int[] sixactave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
    static int[] currentactave = fifthactave;
    static int time = 150;

    static void Main(string[] args)
    {
        Console.WriteLine("Смена актав F1 и F2 (по умолчанию выбрана первая из списка)");
        Console.WriteLine("Черные клавиши C# - Q, Eb - E, F# - R, G# - T, Bb - Y");
        Console.WriteLine("Белые клавиши C - A, D - S, E - D, F - F, G - G, A - H, B - J");

        do
        {
            key = Console.ReadKey(true).Key;

            ActaveChange();
            PlaySound();

        } while (key != ConsoleKey.Escape);
    }

    static void ActaveChange()
    {
        if (key == ConsoleKey.F1)
            currentactave = fifthactave;

        if (key == ConsoleKey.F2)
            currentactave = sixactave;
    }

    static void PlaySound()
    {
        switch (key)
        {
            case ConsoleKey.A:
                Console.Beep(currentactave[0], time);
                break;
            case ConsoleKey.Q:
                Console.Beep(currentactave[1], time);
                break;
            case ConsoleKey.S:
                Console.Beep(currentactave[2], time);
                break;
            case ConsoleKey.E:
                Console.Beep(currentactave[3], time);
                break;
            case ConsoleKey.D:
                Console.Beep(currentactave[4], time);
                break;
            case ConsoleKey.F:
                Console.Beep(currentactave[5], time);
                break;
            case ConsoleKey.R:
                Console.Beep(currentactave[6], time);
                break;
            case ConsoleKey.G:
                Console.Beep(currentactave[7], time);
                break;
            case ConsoleKey.T:
                Console.Beep(currentactave[8], time);
                break;
            case ConsoleKey.H:
                Console.Beep(currentactave[9], time);
                break;
            case ConsoleKey.U:
                Console.Beep(currentactave[10], time);
                break;
            case ConsoleKey.J:
                Console.Beep(currentactave[11], time);
                break;
        }
    }
}