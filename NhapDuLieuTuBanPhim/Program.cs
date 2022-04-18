using System;

namespace NhapDuLieuTuBanPhim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập Họ Tên");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Xin Chao: {0}",hoTen);

            Console.WriteLine("Nhập nam sinh");
            //string namSinh = Console.ReadLine();
            //int bod = int.Parse(namSinh);
            int bod = int.Parse(Console.ReadLine());
            int namHienTai = DateTime.Now.Year;
            Console.WriteLine("Tuoi: {0}"
                ,namHienTai-bod);


        }
    }
}
