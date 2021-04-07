using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
			int l = 1;
			int[] b = new int[l];
			bool haveSwap = false;
			for (int i = 0; i < n; i++)
			{
				haveSwap = false;
				b[i] = a[i];
				for (int j = 0; j < l - 1; j++)
				{
					if (b[i] < b[j])
					{
						int temp = b[i];
						b[i] = b[j];
						b[j] = temp;
						haveSwap = true;
					}
				}
				if (haveSwap == false)
				{
					break;
				}
				Console.Write("Buoc " + (i + 1) + ": ");
				for (int j = 0; j < l; j++)
				{
					Console.Write("\n" + b[i] + " ");
				}
				l++;
				Console.WriteLine();
			}
			Console.ReadKey();
		}
    }
}
