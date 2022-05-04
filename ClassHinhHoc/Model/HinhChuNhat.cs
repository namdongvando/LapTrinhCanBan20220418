using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHinhHoc.Model
{
    class HinhChuNhat
    {
        public double CanhA { get; set; }
        public double CanhB { get; set; }

        public double DienTich()
        {
            return CanhA * CanhB;
        }

        internal double ChuVi()
        {
            return (CanhA + CanhB) * 2;
        }
    }
}
