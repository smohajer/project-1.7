using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //array represents points of picture, i.e. pixel coordinates
            int[,] pic = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            //array to copy to
            int[,] copy = new int[4, 4];

            //moving pic to copy by rotating to the rightby 90 degrees
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    copy[j, pic.GetLength(0)-i-1] = pic[i, j];
                }
            }

            //printing solution to compare
            foreach (int a in pic)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            foreach (int a in copy)
            {
                Console.Write(a+" ");
            }
              
        }
    }
}
