
namespace ChessBoardNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = ReadSize();
            RenderBoard(size);
        }

        static int ReadSize()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Hur stort schackbräde vill du ha? (3-50)");
                string input = Console.ReadLine();
                if (int.TryParse(input, out n) && n >= 3 && n <= 50)
                {
                    return n;
                }
                Console.WriteLine("Ogiltigt storlek. Ange ett heltal mellan 3 och 50.");
            }
        }

        static void RenderBoard(int size)
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
    }
}
