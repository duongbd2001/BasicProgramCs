using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitArrayProgram
{
    /// <summary>
    /// CHIA MẢNG THÀNH HAI MẢNG CON CÓ TỔNG LỚN NHẤT
    /// </summary>
    class Program
    {
        #region Hàm sắp xếp mảng bằng Quick Sort :(((
        public static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Beep();
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            //Nhập mảng cần chia
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            //Sắp xếp mảng theo thứ tự tăng dần
            Quick_Sort(a, 0, n - 1);
            int min;                       //min là biến dùng để khai báo số phần tử của mảng bé hơn
            if (k <= n / 2)
            {
                min = k;
            }
            else
            {
                min = n - k;
            }
            int[] b = new int[min];         //mảng b là mảng gồm các phần thử bé hơn
            int[] c = new int[n - min];     //mảng c là mảng gồm các phần tử lớn hơn
            for (int i = 0; i < min; i++)
            {
                b[i] = a[i];
            }
            for (int i = 0; i < n - min; i++)
            {
                c[i] = a[min + i];
            }
            int sumB = 0, sumC = 0;
            //Tính tổng các phẩn tử trong mảng b
            for (int i = 0; i < min; i++)
            {
                sumB += b[i];
            }
            //Tính tổng các phần tử trong mảng c
            for (int i = 0; i < n - min; i++)
            {
                sumC += c[i];
            }
            //Cuối cùng là in ra hiệu 2 mảng
            Console.WriteLine("Hiệu của 2 mảng là: " + sumC + " - " + sumB + " = " + (sumC - sumB));
        }
    }
}
