using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVienWF.Model
{
    class PhuongTrinh
    {
        public double SoA { get; set; }
        public double SoB { get; set; }

        public double Giai() {
            if (SoA == 0)
                if (SoB == 0)
                    throw new Exception("VSN");
                else
                    throw new Exception("VN");
            return -SoB / SoA;
        }
    }
}
