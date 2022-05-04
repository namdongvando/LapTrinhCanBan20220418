using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHinhHoc.Model
{
   public class NhanVien : IModelCRUD<NhanVien>
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }

        private static List<NhanVien> DSNhanVien { get; set; }

        public IList<NhanVien> GetAll()
        { 
            return DSNhanVien;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public NhanVien GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IList<NhanVien> GetByName(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(NhanVien item)
        {
            if (DSNhanVien == null)
                DSNhanVien = new List<NhanVien>();
            DSNhanVien.Add(item);
            return true;
        }

        public bool Update(NhanVien item)
        {
            throw new NotImplementedException();
        }
    }
}
