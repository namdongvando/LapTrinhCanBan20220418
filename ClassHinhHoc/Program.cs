using ClassHinhHoc.Model;
using System;
using System.Collections.Generic;

namespace ClassHinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            // SuDungHinhVuong();
            // SuDungHinhChuNhat();
            //SuDungHinhTamGiac();
            //SuDungHinhTron();
            //SuDungNhanVien();
            NhapDSNhanVien();
            XuatDanhSachNhanVien();
        }

        private static void XuatDanhSachNhanVien()
        {
            NhanVien nv = new NhanVien();
            var dsNhanVien = nv.GetAll();
            foreach (var item in dsNhanVien)
            {
                Console.WriteLine(item.HoTen);
            }

        }

        private static void NhapDSNhanVien()
        {
            NhanVien nv = new NhanVien();
            Console.WriteLine("Nhập Ma");
            nv.MaNV = Console.ReadLine();
            Console.WriteLine("Nhập Tên");
            nv.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập SDT");
            nv.SDT = Console.ReadLine();
            Console.WriteLine("Nhập Ngày Sinh");
            nv.NgaySinh = DateTime.Parse(Console.ReadLine());
            // thêm nhân vien vào danh sách
            nv.Insert(nv);
        }

        private static void SuDungNhanVien()
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = "NV001";
            nv.HoTen = "Teo";
            nv.NgaySinh = new DateTime(2000,1,1);
            nv.SDT = "0123456789";
            bool kt = nv.Insert(nv);
           // Console.WriteLine(nv.HoTen);
            NhanVien ti = new NhanVien()
            {
                HoTen = "Ti",
            };
            NhanVien nvba = new NhanVien()
            {
                HoTen = "Ba",
            };
            ti.Insert(ti);
            ti.Insert(nvba);
            IList<NhanVien> dsNhanVien = nv.GetAll();
            foreach (var nhanVien in dsNhanVien)
            {
                Console.WriteLine(nhanVien.HoTen);
            }


        }

        private static void SuDungHinhTron()
        {
            HinhTron hinhTron = new HinhTron();
            hinhTron.BanKinh = 15.0; 
            double dt = hinhTron.DienTich();
            double cv = hinhTron.ChuVi();
            Console.WriteLine(
                "Dien Tich: {0}, Chu Vi{1}", dt, cv);
        }

        private static void SuDungHinhTamGiac()
        {
            HinhTamGiac tamGiac = new HinhTamGiac();
            tamGiac.CanhB = 15.0;
            tamGiac.CanhA = 10.0;
            tamGiac.CanhC = 10.0;
            double dt = tamGiac.DienTich();
            double cv = tamGiac.ChuVi();
            Console.WriteLine(
                "Dien Tich: {0}, Chu Vi{1}", dt, cv);
        }

        private static void SuDungHinhChuNhat()
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.CanhB = 15.0;
            hcn.CanhA = 10.0;
            double dt = hcn.DienTich();
            double cv = hcn.ChuVi();
            Console.WriteLine(
                "Dien Tich: {0}, Chu Vi{1}", dt, cv);
        }

        private static void SuDungHinhVuong()
        {
            HinhVuong hv = new HinhVuong();
            hv.canh = 4;
            Console.WriteLine(hv.DienTich());
            Console.WriteLine(hv.ChuVi());

            HinhVuong hv1 = new HinhVuong()
            {
                canh = 10
            };
            Console.WriteLine(hv1.DienTich());
        }
    }
}
