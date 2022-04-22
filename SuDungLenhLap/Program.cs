using System;

namespace SuDungLenhLap
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
              //  Console.WriteLine("Xin chào{0}",i);
                if (i % 2 == 0) {
                    Console.WriteLine("So Chan {0}", i);
                }
            }
            // kiểm tra 1 số nguyen duong có là so nguyen to khong
            Console.WriteLine("Nhap so nguyen duong");
            int a;
            int.TryParse(Console.ReadLine(), out a);
            if (a < 0) {
                Console.WriteLine("a không hop le");
                return;
            }
            if (a<=3)
            {
                Console.WriteLine("{0} là so nguyen to", a);
                return;
            }
            // a > 3
            for (int i = 2; i <= a; i++)
            {
                if (a % i ==0)
                {
                    if (i == a)
                    {
                        Console.WriteLine("{0} là so nguyen to", a);
                        return;
                    }
                    else {
                        Console.WriteLine(
                            "{0} không phải là so nguyen to", a);
                        return;
                    }

                }
            }

            
        }
    }
}
