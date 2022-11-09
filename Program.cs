namespace PianoLastPick
{
    internal class Program
    {
        
        static void FourOctave()
        {
            int[] fourOctaveArr = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            ttt(fourOctaveArr);
        }
        static void FifeOctave()
        {
            int[] fifeOctaveArr = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            ttt(fifeOctaveArr);
        }
        static void SixOctave()
        {
            int[] sixOctaveArr = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            ttt(sixOctaveArr);
        }
        // Я НАШЛА КАПЛИ!!!!!!!!!!!!!!!!!!!!1
        static void ChangeOctave()
        {
            ConsoleKeyInfo octave = Console.ReadKey(true);
            switch (octave.Key)
            {
                case ConsoleKey.F4:
                    {
                        Console.Clear();
                        Console.WriteLine(" Вы выбрали четвертую октаву! ");
                        FourOctave();
                        break;
                    }
                case ConsoleKey.F5:
                    {
                        Console.Clear();
                        Console.WriteLine(" Вы выбрали пятую октаву! ");
                        FifeOctave();
                        break;
                    }
                case ConsoleKey.F6:
                    {
                        Console.Clear();
                        Console.WriteLine(" Вы выбрали шестую октаву! ");
                        SixOctave();
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
        static void ttt(int[] octav)
        {
            while (true)
            {
                ConsoleKeyInfo tusa = Console.ReadKey(true);
                switch (tusa.Key)
                {
                    case ConsoleKey.E:
                        {
                            Console.Beep(octav[0], 200);
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            Console.Beep(octav[1], 200);
                            break;
                        }
                    case ConsoleKey.R:
                        {
                            Console.Beep(octav[2], 200);
                            break;
                        }
                    case ConsoleKey.F:
                        {
                            Console.Beep(octav[3], 200);
                            break;
                        }
                    case ConsoleKey.T:
                        {
                            Console.Beep(octav[4], 200);
                            break;
                        }
                    case ConsoleKey.G:
                        {
                            Console.Beep(octav[5], 200);
                            break;
                        }
                    case ConsoleKey.Y:
                        {
                            Console.Beep(octav[6], 200);
                            break;
                        }
                    case ConsoleKey.H:
                        {
                            Console.Beep(octav[7], 200);
                            break;
                        }
                    // ура, я дышу
                    case ConsoleKey.U:
                        {
                            Console.Beep(octav[8], 200);
                            break;
                        }
                    case ConsoleKey.J:
                        {
                            Console.Beep(octav[9], 200);
                            break;
                        }
                    case ConsoleKey.I:
                        {
                            Console.Beep(octav[10], 200);
                            break;
                        }
                    case ConsoleKey.K:
                        {
                            Console.Beep(octav[11], 200);
                            break;
                        }
                }
                if (tusa.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите октаву - F4, F5, F6. \nНажмите Esc, чтобы выйти из программы");
                    break;
                }

            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение между октавами - F4, F5, F6 (Esc - выйти из октавы)");
            while (true)
            {
                ChangeOctave();
            }
        }
    }
}