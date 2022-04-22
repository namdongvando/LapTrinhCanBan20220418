using System;

namespace VongLapWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i< 100)
            //{
            //    Console.WriteLine("{0} Xin chao");
            //    i++;
            //}
            int a;
            bool kt = true;
            do
            {
                Console.WriteLine("Nhap so nguyen a");
                kt = 
                    int.TryParse(Console.ReadLine(), out a);

            } while (kt ==false);

            int b;
            kt = true;
            do
            {
                Console.WriteLine("Nhap so nguyen b");
                kt =
                    int.TryParse(Console.ReadLine(), out b);
                if (b == 0 ) {
                    kt = false;
                }

            } while (kt == false);

        }
    }
}
