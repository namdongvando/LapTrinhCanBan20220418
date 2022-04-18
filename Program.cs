using System;

namespace LapTrinhCanBan20220418
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Xin chào");
            //Console.ReadKey();
            // khai báo biến
            int a = 6;
            int b;
            // gán giá trị cho biến
            b = 5; 

            Console.WriteLine(@"A là: {0},
B là: {1} Tổng A+B là: {2}", a,b,a+b); 
            Console.WriteLine(@"A là: {0},
B là: {1} Hieu A-B là: {2}", a, b, a - b);
            Console.WriteLine(@"A là: {0},
B là: {1} Tich A*B là: {2}", a, b, a * b);
            Console.WriteLine(@"A là: {0},
B là: {1} Thương A/B là: {2}", a, b, a / b);

        }
    }
}
