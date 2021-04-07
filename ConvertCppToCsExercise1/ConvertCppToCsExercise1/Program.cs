using System;
using System.Text;

namespace ConvertCppToCsExercise1
{
    class Program
    {
         static int DeQuy(int[] a, int n)
        {
            int[] b = new int [n - 1]; int j = 0;
            for (int i = 1; i < n; i++)
            {
                b[j] = a[i] + a[i - 1];
                j++;
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            return DeQuy(b, n - 1);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập n = ");
            int n = Int32.Parse(Console.ReadLine());           
            Console.WriteLine();
            int[] a = new int [n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine(DeQuy(a, n));
        }
    }
}
