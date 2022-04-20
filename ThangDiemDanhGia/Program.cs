using System;

namespace ThangDiemDanhGia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập Điểm");
            double diem = 0;
            bool isNumber = 
                double.TryParse(
                    Console.ReadLine(), out diem
                    );
            // đã có điểm
            if (diem > 10 || diem < 0)
            {
                Console.WriteLine("Diem khong hop le");
                return;
            }
            // diểm 0-> 10
            if (diem < 3.5)
            {
                Console.WriteLine("kém");
            }
            if (diem >= 3.5 && diem < 5)
            {
                Console.WriteLine("Yếu");
            }
            if(diem >=5 && diem <6.5)
            {
                Console.WriteLine("TB");
            }
            if (diem >= 6.5 && diem < 8.5)
            {
                Console.WriteLine("Khá");
            }
            if (diem >= 8.5)
            {
                Console.WriteLine("Giỏi");
            }
        }
    }
}
