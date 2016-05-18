using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first integer for area of a rectangle:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second integer for area of a rectangle:");
            int y = int.Parse(Console.ReadLine());
            int z = rectarea(x, y);
            Console.WriteLine("The area of your rectangle is:{0}", z);
            Console.WriteLine(Environment.NewLine + "Press enter key to continue");
            Console.ReadLine();
            Console.WriteLine("OK now give me one integer for a multiplication table:");
            int m = int.Parse(Console.ReadLine());
            mt(m);
            Console.WriteLine(Environment.NewLine + "Press enter key to continue");
            Console.ReadLine();
            int[] a = new int[10] { 50, 12, 5, 1, 89, 13, 19, 21, 77, 51 };
            int ans = max(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine(Environment.NewLine + "Press enter to see largest number in array");
            Console.ReadLine();
            Console.WriteLine(ans);
            Console.ReadLine();
        }

        static int rectarea(int x, int y)
        {
            return x * y;
        }

        static void mt(int x)
        {
            int i = 0;
            int f = 1;
            for (int z = 0; z < x; z++)
            {
                for (int c = 0; c < x; c++)
                {
                    i = i + f;

                    Console.Write(i + " ");
                }
                i = 0;
                f++;

                Console.WriteLine(Environment.NewLine);

            }
        }

        static int max(int[] x)
        {
            int ans = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > ans)
                {
                    ans = x[i];
                }
            }
            return ans;
        }

    }
}
