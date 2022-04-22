using System;

namespace TinhTongToiN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap So Nguyen N");
            int a;
            if (int.TryParse(Console.ReadLine(), out a)==false) {
                Console.WriteLine("N không hop le");
                return;
            }
            int tong = 0;
            for (int i = 1; i <= a; i++)
            {
                tong += i;
                //tong = tong + i;
            }
            Console.WriteLine("Tong toi N la:{0}",tong);

        }
    }
}
