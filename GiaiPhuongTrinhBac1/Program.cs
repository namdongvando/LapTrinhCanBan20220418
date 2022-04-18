using System;

namespace GiaiPhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a:");
            double a = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Nhap b:");
            double b = double.Parse(Console.ReadLine()); 
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("VSN");
                }
                else
                {
                    Console.WriteLine("VN");
                }
            }
            else {
                Console.WriteLine("X={0}",-b/a);
            } 
        }
    }
}
