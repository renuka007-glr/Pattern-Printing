using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Printing
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern21(5);
        }
        public static void pattern21(int n)
        {
            int i = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(i + " ");
                    i++;
                }
                Console.Write("\n");
            }
        }
        public static void pattern7(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row <= col)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.Write("\n");
            }
        }
        public static void pattern6(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if(n - row < col)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.Write("\n");
            }
        }
        public static void pattern5(int n)
        {
            for (int row = 1; row <= 2 * n - 1; row++)
            {
                int colcount = (row > n) ? (2 * n - row): row;
                for (int col = 1; col <= colcount; col++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
        public static void pattern4(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.Write("\n");
            }
        }
        public static void pattern3(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
        public static void pattern2(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
        public static void pattern1(int n)
        {
            for(int row = 0 ;row < n; row++)
            {
                for(int col=0;col<n;col++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}
