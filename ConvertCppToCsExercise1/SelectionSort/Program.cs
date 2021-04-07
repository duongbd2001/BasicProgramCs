using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;
			Console.Write("nhập số phần tử của mảng: ");
			int n = Int32.Parse(Console.ReadLine());
			int[] a = new int[n];
			for (int i = 0; i < n; i++)
			{
				a[i] = Int32.Parse(Console.ReadLine());
			}
			for (int i = 0; i < n - 1; i++)
			{
				int min = i;
				int j;
				for (j = i; j < n; j++)
				{
					if (a[j] < a[min])
					{
						min = j;
					}
				}
				int temp = a[i];
				a[i] = a[min];
				a[min] = temp;
				Console.Write("Bước " + (i + 1) + ": ");
				for (int k = 0; k < n; k++)
				{
					Console.Write(a[k] + " ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
    }
}
