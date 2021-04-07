using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortProgram
{
    class Program
    {
		/// <summary>
		/// Cài đặt thuật toán sắp xếp nổi bọt
		/// </summary>
		/// <param name="args"></param>
        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;
			int n = Int32.Parse(Console.ReadLine());
			int[] a = new int[n];
			for (int i = 0; i < n; i++)
			{
				a[i] = Int32.Parse(Console.ReadLine());
			}
			bool haveSwap = false;
			for (int i = 0; i < n - 1; i++)
			{
				haveSwap = false;
				for (int j = 0; j < n - i - 1; j++)
				{
					if (a[j] > a[j + 1])
					{
						int temp = a[j];
						a[j] = a[j + 1];
						a[j + 1] = temp;
						haveSwap = true;
					}

				}
				if (haveSwap == false)
				{
					break;
				}
				Console.Write("\nBước " + (i + 1) + ": ");
				for (int j = 0; j < n; j++)
				{
					Console.Write(a[j] + " ");
				}
				Console.WriteLine();
			}
		}
    }
}
