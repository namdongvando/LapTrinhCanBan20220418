using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHinhHoc.Model
{
    class HinhVuong
    {
        public double canh { get; set; }

        public double DienTich()
        {
            return Math.Pow(canh, 2);
        }

        public double ChuVi()
        {
            return canh * 4;
        }
    }
}
