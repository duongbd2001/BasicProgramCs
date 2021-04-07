using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MoneyChangeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Tờ tiền cần đổi: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] a = new int[] { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 };
            int check = 0;
            Console.Write("\nTờ tiền đổi được: ");
            for (int i = 9; i >= 0; i--)
            {
                while (a[i] <= n)
                {
                    n = n - a[i];
                    Console.Write(a[i]+" ");
                    check++;
                }
            }
            Console.WriteLine("\nTổng số tờ tiền đổi được là "+check+"\n");
        }
    }
}
