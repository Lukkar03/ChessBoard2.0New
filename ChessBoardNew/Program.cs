using System;

namespace ChessBoardNew
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Hur stort schackbräde vill du ha? (3-50): ");
            if (int.TryParse(Console.ReadLine(), out int size) && size >= 3 && size <= 50)
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        Console.Write((row + col) % 2 == 0 ? "X" : "O");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Ange ett heltal mellan 3 och 50.");
            }
        }
    }
}
