using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timmintrongmangsudungphuongthuc
{
    internal class Program
    {
        public static int MinValue (int [] arr)
        {
            int Min = arr[0];
            int index = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                    index = i;
                }
            }
            return index;
        }
        public static void Main(string[] args)
        {
            //In ra mảng ngẫu nhiên
            Random random = new Random();
            Console.Write("Nhap kich thuoc mang: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] arr1 = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arr1[i] = random.Next(1,100);
            }
            Console.WriteLine("Ta co mang la: ");
            foreach (int arr in arr1)
            {
                Console.WriteLine(arr);
            }
            //Tìm giá trị min
            int index = MinValue(arr1);
            Console.WriteLine("Min la: " + arr1[index]);
            Console.ReadKey();
        }
    }
}
