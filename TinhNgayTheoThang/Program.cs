using System;

namespace TinhNgayTheoThang
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhập Thang");
                int thang, nam;
                bool isNumber = int.TryParse(
                    Console.ReadLine(), 
                    out thang
                    );
                if (isNumber == false)
                {
                    // năm không hộp lệ
                    throw new Exception("thang không hop lệ");
                }

                Console.WriteLine("Nhap Nam");
                isNumber = int.TryParse(
                    Console.ReadLine(), 
                    out nam
                    );
                // kiển tra nhập có đúng không
                if (isNumber ==false)
                {
                    throw new Exception("Nam không hop le");
                }
                // kiêm tra thang 1-> 12
                if (thang > 12 || thang < 1) {
                    throw new Exception("thang không hop le");
                }
                // 1,3,5,7,10,8,12 => 31 
                // 2 28|| 29
                // 4,6,9,11 => 30
                if (thang == 2)
                {
                    if (nam % 4 == 0)
                    {
                        Console.WriteLine("29 ngay");
                        return;
                    } 

                    Console.WriteLine("28 ngay");
                    return;

                }
                switch (thang)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("30 ngay");
                        return;
                        
                }

                if(thang == 4 
                    || thang==6
                    || thang == 9 
                    || thang == 11)
                {
                    Console.WriteLine("30 ngay");
                    return;
                }

                Console.WriteLine("31 ngay");
                return;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            

        }
    }
}
