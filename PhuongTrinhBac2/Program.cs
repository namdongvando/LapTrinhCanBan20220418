using System;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap c");
                double c = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    throw new Exception("Khong Phai PTB2");
                }
                // a # 0
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                {
                    throw new Exception("PTVN");
                }
                // pt co nghiem
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(@"X1={0:F2} ,X2={1:F2}", x1, x2);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
