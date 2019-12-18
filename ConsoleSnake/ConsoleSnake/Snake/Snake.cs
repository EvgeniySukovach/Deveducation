using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
    {
    public class Snake
    {
        private ConsoleKey TheWay; //→↓↑←

        public Snake()
        {
            TheWay = ConsoleKey.DownArrow;//DownArrow, LeftArrow, RightArrow, UpArrow
        }

        private void EatTheFruits(Board board)
        {
            board.PlaceOfFruitL = 0;
            board.PlaceOfFruitH = 0;
            board.CountOfSegments += 1;
            board.CreateTheFruit();
        }

        public void ChangeTheWay(ConsoleKey newWay)
        {
            if (newWay == ConsoleKey.DownArrow || newWay == ConsoleKey.LeftArrow
            || newWay == ConsoleKey.RightArrow || newWay == ConsoleKey.UpArrow)
                TheWay = newWay;
        }

        public bool PushForward(Board board) //Move
        {
            switch (TheWay)
            {
                case ConsoleKey.DownArrow:
                    board.PlaceOfSnakesHeadH += 1;
                    break;
                case ConsoleKey.UpArrow:
                    board.PlaceOfSnakesHeadH -= 1;
                    break;
                case ConsoleKey.LeftArrow:
                    board.PlaceOfSnakesHeadL -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    board.PlaceOfSnakesHeadL += 1;
                    break;
            }
            if (board.PlaceOfSnakesHeadH == board.PlaceOfFruitH && board.PlaceOfSnakesHeadL == board.PlaceOfFruitL)
                EatTheFruits(board);
            if (board.PlaceOfSnakesHeadH < 0 || board.PlaceOfSnakesHeadL < 0 || board.PlaceOfSnakesHeadH >= board.H || board.PlaceOfSnakesHeadL >= board.L)
            {
                Console.Clear();
                Console.WriteLine($"Congratulations! Your score is {board.CountOfSegments}!");
                Console.ReadKey();
                return false;
            }

            return true;
        }
    }
}
