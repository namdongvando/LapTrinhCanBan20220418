using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVienWF.Model
{
    class PTB2
    {
        public double SoA { get; set; }
        public double SoB { get; set; }
        public double SoC { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public PTB2(double soA, double soB, double soC)
        {
            SoA = soA;
            SoB = soB;
            SoC = soC;
            //
            Giai();
        }

        public void Giai() {
            if (SoA == 0) {
                throw new Exception("Số A Phải Khác: 0");
            }
            double d = Math.Pow(SoB, 2) - 4 * SoA * SoC;
            if (d < 0)
                throw new Exception("PTVN");
            X1 = (-SoB + Math.Sqrt(d)) / (2 * SoA);
            X2 = (-SoB - Math.Sqrt(d)) / (2 * SoA);
        }

    }
}
