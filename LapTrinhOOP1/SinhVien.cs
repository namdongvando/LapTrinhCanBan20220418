using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP1
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public DateTime NamSinh { get; set; }
        public bool GioiTinh { get; set; }
        public string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}",
                MaSV, TenSV, NamSinh, GioiTinh);
        }

    }
}
