using System;

namespace UCLN
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            // nhap a
            Console.WriteLine("Nhap a");
            int.TryParse(Console.ReadLine(), out a);
            // nhap b
            Console.WriteLine("Nhap b");
            int.TryParse(Console.ReadLine(), out b);

            while (a * b > 0)
            {
                if (a > b)
                {
                    a = a % b;
                }else {
                    b = b % a;
                }
            }

            Console.WriteLine("UCLN la :{0}",a+b);

        }
    }
}
