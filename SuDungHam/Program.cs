using System;

namespace SuDungHam
{
    class Program
    {
        static void Main(string[] args)
        {
            //XinChao();
            //XinChao("Nguyen Van Teo");
            Menu();


        }

        private static void Menu()
        {
            Console.WriteLine("========Menu=========");
            Console.WriteLine("1. Phương Trinh Bac 1");
            Console.WriteLine("2. Phương Trinh Bac 2");
            Console.WriteLine("3. UCLN");
            Console.WriteLine("4. Tin So Lon Nhat");
            Console.WriteLine("5. Tinh N!");
            Console.WriteLine("Chọn: ");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    PTB1();
                    break;
                case "2":
                    PTB2();
                    break;
                case "3":
                    UCLN();
                    break;
                case "4":
                    TSLN();
                    break;
                case "5":
                    TinhGiaiThua();
                    break;
                case "exit":
                    return;
            }
            Menu();
        }

        private static void TinhGiaiThua()
        {
            int a = NhapSoNguyenDuong("Nhap N!");
            int gt = 1;
            for (int i = 1; i <= a; i++)
            {
                gt = gt * i;
            }
            //int gt1=1;
            //int j = 1;
            //while (j <= a) {
            //    gt1 = gt1 * j;
            //    j++;
            //}
            Console.WriteLine("N! = {0}", gt);
        }

        private static void TSLN()
        {

        }

        private static void UCLN()
        {
            int a = NhapSoNguyenDuong("Nhap So a");
            int b = NhapSoNguyenDuong("Nhap So b");
            while (a * b > 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            Console.WriteLine("UCLN là: ", a + b);

        }

        private static int NhapSoNguyenDuong(string thongBao)
        {
            Console.WriteLine(thongBao);
            int a;
            while (true)
            {
                bool kt = int.TryParse(
                    Console.ReadLine(), out a);
                if (kt == true)
                {
                    if (a > 0)
                    {
                        return a;
                    }
                }
                Console.WriteLine("Nhap lai");
            }

        }

        private static void PTB2()
        {
            try
            {
                double a = NhapSo("Nhap So a");
                double b = NhapSo("Nhap So b");
                double c = NhapSo("Nhap So c");
                if (a == 0)
                {
                    throw new Exception("Không Phai PTB2");
                }
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                {
                    throw new Exception("VN");
                }
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("X1= {0}, X2={1}", x1, x2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static double NhapSo(string thongBao)
        {
            Console.WriteLine(thongBao);
            double a;
            while (double.TryParse
                (Console.ReadLine(), out a)
                == false)
            {
                Console.WriteLine("Nhap Lai");
            }
            return a;
        }

        /// <summary>
        /// giai ptb1
        /// </summary>
        private static void PTB1()
        {
            try
            {
                double a, b;
                Console.WriteLine("Nhap a");
                bool kt = double.TryParse(Console.ReadLine(), out a);
                if (kt == false)
                {
                    throw new Exception("a không hop le");
                }

                Console.WriteLine("Nhap b");
                kt = double.TryParse(Console.ReadLine(), out b);
                if (kt == false)
                {
                    throw new Exception("b không hop le");
                }

                if (a == 0)
                {
                    if (b == 0)
                    {
                        throw new Exception("VSN");
                    }
                    throw new Exception("VN");
                }
                double x = -b / a;
                Console.WriteLine("Nghiem la: {0}", x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// Xuất ra màn hình cin chào ho ten: 
        /// </summary>
        /// <param name="hoTem">Chuỗi</param>
        private static void XinChao(string hoTem)
        {
            Console.WriteLine("Xin chao {0}", hoTem);
        }

        /// <summary>
        /// đây là hàm chay chữ xin chào
        /// </summary>
        private static void XinChao()
        {
            Console.WriteLine("Xin Chào");
        }
    }
}
