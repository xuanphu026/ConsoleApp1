using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int s = 0;
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    s = s + i;
                }
            }
            Console.WriteLine(s);
            Console.ReadKey();

            //int num, sum = 0, r;
            //Console.WriteLine("NHAP VAO MOT SO : ");
            //int.Parse(Console.ReadLine());
            //while (num != 0)
            //{
            //    r = num % 10;
            //    num = num / 10;
            //    sum = sum + r;
            //}
            //Console.WriteLine("TONG CAC CHU SO CUA NO LA : " + sum);
            //Console.ReadLine();

        }
    }
}
