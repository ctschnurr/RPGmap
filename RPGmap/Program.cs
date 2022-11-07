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
            //Console.SetWindowSize(62, 26);
            //Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

            Console.CursorVisible = false;

            DisplayMap(1);

            Console.ReadKey(true);

            DisplayMap(2);

            Console.ReadKey(true);

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
            int drawX = 0;
            int gridX = 0;

            int mapH = 0;
            int drawY = 0;

            for (int z = 0; z < 30; z++)
            {
                
                for (int x = 0; x < scale; x++)
                {
                    char tile = (map[mapV, mapH]);

                    Console.SetCursorPosition(drawY, drawX);
                    for (int y = 0; y < scale; y++)
                    {
                        Console.Write(tile);
                    }
                    drawX = drawX + 1;
                }
                mapY = mapY + 1;

            }

            




            //      for (int mapX = 0; mapX < 12; mapX++)
            //      {
            //          Console.SetCursorPosition(0, mapX);
            //          for (int mapY = 0; mapY < 30; mapY++)
            //          {
            //              char tile = (map[mapX, mapY]);
            //
            //              for (int x = 1; x <= scale; x++)
            //              {
            //                  for(int y = 1; y <= scale; y++)
            //                  {
            //                      Console.Write(tile);
            //                  }
            //                  Console.SetCursorPosition(Console.CursorLeft - scale, Console.CursorTop + x);
            //              }
            //          }
            //
            //      }

        }
    }
}
