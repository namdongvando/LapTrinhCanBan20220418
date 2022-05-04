using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHinhHoc.Model
{
    class HinhTron
    {
        public double BanKinh { get; internal set; }

        internal double DienTich()
        {
            return  Math.PI * Math.Pow(BanKinh,2);
        }

        internal double ChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }
    }
}
