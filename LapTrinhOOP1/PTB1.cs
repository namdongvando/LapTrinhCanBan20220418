using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP1
{
    class PTB1
    {
        //ax+b=0
        public double soA { get; set; }
        public double soB { get; set; }
        public double nghiem { get; set; }

        public PTB1(double soA, double soB)
        {
            this.soA = soA;
            this.soB = soB; 
        }

        public double GiaiPT() {
            try
            {
                if (soA == 0)
                {
                    if (soB == 0)
                        throw new Exception("VSN");
                    throw new Exception("VN");
                }
                nghiem = -soB / soA;
                return nghiem;
            }
            catch (Exception ex)
            {
                return double.NaN; 
            }

            
        }

    }
}
