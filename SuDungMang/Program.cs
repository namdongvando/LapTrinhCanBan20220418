using System;
using System.Collections.Generic;

namespace SuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {
            // TaoMang();
            // SapXepMang();
            //SapXepMang1();
            //SapXepMang2();
            //TimGiaTriLonNhat();
            //TimGiaTriNhoNhat();
            // TimKiem();
            SuDungDanhSachLienKet();

        }

        private static void SuDungDanhSachLienKet()
        {
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(3);
            a.Add(6);
            a.Add(3);
            a.Add(9);
            a.Add(2);
            a.Add(9);
            a.Insert(0, 999);
            a.RemoveAll(item => item > 10);
            a.RemoveAt(0);
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }

        }

        private static void SapXepMang2()
        {
            int[] a = { 234, 23, 4234, 23, 4234, 234, 23, 423423, 2342 };
            Array.Sort(a);
            //Array.FindIndex(a, item => item == 1);
        }

        private static void SapXepMang1()
        { 
            int[] a = { 234, 23, 4234, 23, 4234, 234, 23, 423423, 2342 };
            int vtMin = 0;
            for (int i = 0; i < a.Length; i++)
            {
                vtMin = i;
                // tim vi tri gia trị nho nhat
                for (int j = i; j < a.Length; j++)
                {
                    if (a[vtMin] > a[j]) {
                        vtMin = j;
                    }
                }
                // tìm dc vi tri giá tri nho nhất từ vị trí thứ i
                // hoan vi 
                int tam = a[i];
                a[i] = a[vtMin];
                a[vtMin] = tam;

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        private static void TimKiem()
        {
            int[] a = { 234, 23, 4234, 23, 4234, 234, 23, 423423,2342 };
            Console.WriteLine("Nhap Gia Tri muốn tìm:");
            int tim = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                if (tim == a[i])
                {
                    Console.WriteLine("Có Giá Trị Cần Tim");
                    return;
                }
            }
            Console.WriteLine("Khong thay Giá Trị Cần Tim");
            return;


        }

        private static void TimGiaTriNhoNhat()
        {
            int[] a = { 234, 23, 4234, 23, 4234, 234, 23, 423423, };
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Gia Tri nho nhat La:{0}", min);
        }

        private static void TimGiaTriLonNhat()
        {
            int[] a = { 234, 23, 4234, 23, 4234, 234, 23, 423423, };
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max< a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Gia Tri LN La:{0}", max);

        }

        private static void SapXepMang()
        {
            int[] a = {23,2,34,23,42,34,23,423,42,65,6,45 };
            int i = 0;
            int tam = 0;
            while (i < a.Length-1)
            {
                if (a[i] > a[i + 1])
                {
                    // hoáng vị
                    tam = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tam;
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            // mang da sap xep
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }

        }

        private static void TaoMang()
        {
            string[] dsMaSinhVien = new string[10];
            string[] dsTenSinhVien = { 
                "Teo", "ti","Lan","Mai","Cuc","Nam"
                ,"Toan","tam","Chin","Muoi"
            };

            for (int i = 0; 
                i < dsTenSinhVien.Length;
                i++)
            {
                Console.WriteLine(dsTenSinhVien[i]);
            }


        }
    }
}
