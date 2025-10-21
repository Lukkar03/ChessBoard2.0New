
namespace ChessBoardNew
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
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
                    Console.Write((row + col) % 2 == 0 ? "◼︎" : "◻︎");
                }
                Console.WriteLine();

            }
        }
    }
}
//Jag var lite osäker på hur jag skulle få rutorna att lägga sig i rätt ordning och få det att se ut som ett schakbräde samt hur jag skulle få dom att synas då det först bara blev frågetecken istället för rutor.
//Så jag tog hjälp av Copilot och frågade om tips och guidning steg för steg hur jag skulle lösa det.
//Jag frågade vart i koden "Console.OutputEncoding = System.Text.Encoding.Unicode;" skulle ligga och flyttade därefter den då jag hade lagt den på fel ställe, samt hur jag skulle få rutaorna att lägga sig i formen av ett schackbräde vilket jag fick hjälp att skriva själv steg för steg 