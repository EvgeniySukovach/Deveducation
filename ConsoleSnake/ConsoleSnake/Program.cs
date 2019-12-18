using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Board tableBoard = new Board();
            Snake snake = new Snake();
            bool IsContinue = true;
            tableBoard.DrawTheBoard();

            while (IsContinue)
            {
                var key = Console.ReadKey().Key;
                Console.Clear();
                snake.ChangeTheWay(key);
                IsContinue = snake.PushForward(tableBoard);
                if (IsContinue)
                    IsContinue = !key.Equals(ConsoleKey.Escape);

                tableBoard.DrawTheBoard();
            }
        }
    }
}
