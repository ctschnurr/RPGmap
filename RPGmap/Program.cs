using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGmap
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        static void Main(string[] args)

        {
            Console.SetWindowSize(92, 39);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

            Console.CursorVisible = false;

            DisplayMap();

            Console.ReadKey(true);
            Console.Clear();

            DisplayMap(1);

            Console.ReadKey(true);
            Console.Clear();

            DisplayMap(2);

            Console.ReadKey(true);
            Console.Clear();

            DisplayMap(3);

            Console.ReadKey(true);

            //  while (gameOver == false)
            //  {
            //      //PlayerDraw(x, y);
            //      //PlayerUpdate();
            //  }
        }

        static void DisplayMap()
        {

            for (int mapX = 0; mapX < 12; mapX++)
            {
                Console.SetCursorPosition(0, mapX);
                for (int mapY = 0; mapY < 30; mapY++)
                {
                    Console.Write(map[mapX, mapY]);
                }

            }

        }

        static void DisplayMap(int scale)
        {

            int mapV = 0;
            int drawV;

            int mapH = 0;

            int rowNum = 1;
            int colNum = 1;

            switch (scale)
            {
                case 1:
                    rowNum = 12;
                    colNum = 30;
                    break;

                case 2:
                    rowNum = 6;
                    colNum = 15;
                    break;

                case 3:
                    rowNum = 0;
                    colNum = 0;
                    break;
            }

            int mapRow = rowNum + 1;
            int mapCol = colNum + 1;

            int drawH = mapCol;

            for (int column = 0; column < 12; column++)
            {
                for (int row = 0; row < 30; row++)
                {
                    drawV = mapRow;
                    for (int v = 0; v < scale; v++)
                    {
                        char tile = (map[mapV, mapH]);

                        Console.SetCursorPosition(drawH, drawV);
                        for (int h = 0; h < scale; h++)
                        {
                            Console.Write(tile);
                        }
                        drawV = drawV + 1;
                    }
                    mapH = mapH + 1;
                    drawH = drawH + scale;
                    

                }
                mapRow = mapRow + scale;
                drawH = mapCol;
                
                mapV = mapV + 1;
                mapH = 0;          
            }

            Console.SetCursorPosition(colNum, rowNum);

            Console.Write("╔");

            for (int x = 0; x < (30 * scale); x++)
            {
                Console.Write("═");
            }

            Console.WriteLine("╗");

            for (int y = 1; y <= (12 * scale); y++)
            {
                Console.SetCursorPosition(colNum, rowNum + y);
                Console.Write("║");
                Console.SetCursorPosition(colNum + ((30 * scale) + 1), rowNum + y);
                Console.Write("║");
            }

            Console.SetCursorPosition(colNum, mapRow);

            Console.Write("╚");

            for (int x = 0; x < (30 * scale); x++)
            {
                Console.Write("═");
            }

            Console.Write("╝");

            Console.SetCursorPosition(colNum, mapRow + 1);

            Console.Write(" Scale: " + scale);

        }
    }
}
