using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHinhHoc.Model
{
    class HinhTamGiac
    {
        public double CanhB { get;  set; }
        public double CanhA { get; set; }
        public double CanhC { get; set; }

        public double DienTich()
        {
            double p = ChuVi() / 2;
            return Math.Sqrt(p * 
                (p - CanhA) * 
                (p - CanhB) * 
                (p - CanhC));

        }

        public double ChuVi()
        {
            return CanhB + CanhA + CanhC;
        }
    }
}
