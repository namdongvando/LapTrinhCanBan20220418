using System;

namespace LapTrinhOOP1
{  

    class Program
    {
        static void Main(string[] args)
        {

            GiaiPTB1();
         
        }

        private static void GiaiPTB1()
        {
            PTB1 ptb1 = new PTB1(1, 2);
            ptb1.GiaiPT();
            Console.WriteLine(ptb1.nghiem);
        }

        private static void ThemSinhVien()
        {
            SinhVien teo = new SinhVien()
            {
                MaSV = "sv001",
                TenSV = "Teo Nguyen",
                NamSinh = new DateTime(2000, 1, 1),
                GioiTinh = true
            };
            Console.WriteLine(teo.MaSV);
            Console.WriteLine(teo.TenSV);
            Console.WriteLine(teo.NamSinh);
            Console.WriteLine(teo.GioiTinh);

            SinhVien Ti = new SinhVien();
            Ti.MaSV = "sv002";
            Ti.TenSV = "Ti Tran";
            Ti.NamSinh = new DateTime(2000, 2, 2);
            Ti.GioiTinh = true;
            Console.WriteLine(Ti.ToString()); 
        }
    }
}
