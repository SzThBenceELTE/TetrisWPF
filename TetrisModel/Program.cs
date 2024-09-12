

using TetrisModel.Model;

namespace TetrisModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeWidth = 4;
            int sizeHeight = 16;
            State state = new State(16, 4);

            
            System.Console.WriteLine(state.table.isEmptyElement(1, 1));
            System.Console.WriteLine(state.table.isEmptyElement(5, 5));
            System.Console.WriteLine(state.table.isEmptyElement(16, 6));

            while (!state.IsGameOver())
            {
                state.moveDown();
            }

            for (int i = 0; i < sizeHeight; i++)
            {
                for (int j = 0; j < sizeWidth; j++)
                {
                    System.Console.Write(state.table[i,j]);
                }
                System.Console.Write("\n");
            }



        }
    }
}