using System;

namespace SuDungLenhIF
{
    class Program
    {
        static void Main(string[] args)
        {
            #region xác dịnh chẵn lẻ
            //Console.WriteLine("Nhap so nguyen a");
            //int a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("Số Chẵn");
            //}
            //else {
            //    Console.WriteLine("Số Lẻ");
            //}
            #endregion

            #region tìm số lớn nhất trong 3 số
            int a = 5;
            int b = 10;
            int c = 16;
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine(@"Giá Trị lon nhat là:{0}",max);
            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            Console.WriteLine(@"Giá Trị nhỏ nhat là:{0}", min);
            #endregion
        }
    }
}
