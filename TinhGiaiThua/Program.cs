using System;

namespace TinhGiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap N!");
            int a;
            if (int.TryParse(Console.ReadLine(), out a)==false) {
                Console.WriteLine("N không hop le");
                return;
            }
            if (a <1)
            {
                Console.WriteLine("N không hop le");
                return;
            }
            int gt = 1;
            for (int i = 1; i <= a; i++)
            {
                gt = gt * i;
            }

            Console.WriteLine("N!= {0}",gt);
            return;

        }
    }
}
