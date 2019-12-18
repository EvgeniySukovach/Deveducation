using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Board
    {
        public int H;
        public int L;
        public int CountOfSegments;
        public int PlaceOfFruitH;
        public int PlaceOfFruitL;
        public int PlaceOfSnakesHeadL;
        public int PlaceOfSnakesHeadH;
        public int[][] OurSnake;

        public Board()
        {
            CountOfSegments = 0;
            H = 20;
            L = 60;
            PlaceOfFruitH = 1;
            PlaceOfFruitL = 1;
            PlaceOfSnakesHeadL = 10;
            PlaceOfSnakesHeadH = 10;
        }

        public void DrawTheBoard()
        {
            //Создай верхнюю границу
            for (int i = 0; i < L + 2; i++)
                Console.Write("_");
            Console.WriteLine();
            //Создай левую и правую границы + игровое поле
            for (int i = 0; i < H; i++)
            {
                Console.Write("|");
                for (int y = 0; y < L; y++)
                {
                    if (i == PlaceOfSnakesHeadH && y == PlaceOfSnakesHeadL)
                        Console.Write("$");
                    else if (i == PlaceOfFruitH && y == PlaceOfFruitL)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }

                Console.WriteLine("|");
            }
            //Создай нижнюю границу
            for (int i = 0; i < L + 2; i++)
                Console.Write("¯");

            Console.WriteLine($"\n\n\n!!! Your score is - {CountOfSegments} !!!");
        }

        public void CreateTheFruit()
        {
            Random rnd = new Random();
            PlaceOfFruitH = rnd.Next(0, H - 1);
            PlaceOfFruitL = rnd.Next(0, L - 1);
            if (PlaceOfSnakesHeadH == PlaceOfFruitH && PlaceOfSnakesHeadL == PlaceOfFruitL)
                if (PlaceOfFruitH == 0)
                    PlaceOfFruitH += 1;
                else
                    PlaceOfFruitH -= 1;
        }
    }
}
