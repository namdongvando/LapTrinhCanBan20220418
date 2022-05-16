using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVienWF.Model
{
    class NhanVien : IModelCRUD<NhanVien>
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public static List<NhanVien> DanhSachNhanVien { get; set; }
        public static NhanVien NhanVienSua { get; internal set; }

        public NhanVien(string maNV, string tenNV, DateTime ngaySinh, string diaChi, string sDT, string email)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SDT = sDT;
            Email = email;
        }

        public NhanVien()
        {
        }

        /// <summary>
        /// Lấy Danh Sách Nhân Viên
        /// </summary>
        /// <returns></returns>
        public List<NhanVien> GetAll()
        {
            if (DanhSachNhanVien == null)
                DanhSachNhanVien = new List<NhanVien>();
            return DanhSachNhanVien;
        }

        public bool Delete(string Id)
        {
            DanhSachNhanVien = GetAll();
            DanhSachNhanVien.RemoveAll(nv => nv.MaNV == Id);
            return true;
        }

        public bool Insert(NhanVien item)
        {
            DanhSachNhanVien = GetAll();
            // kiểm tra đã có mã nhân viên chưa
            var nhanVien = DanhSachNhanVien
                .Find(nv => nv.MaNV == item.MaNV);
            if (nhanVien == null) {
                DanhSachNhanVien.Add(item);
                return true;
            }
            return false;
        }

        public bool Update(NhanVien item)
        {
            Delete(item.MaNV);
            Insert(item);
            return true;
        }

        public NhanVien GetById(string Id)
        {
            var danhSachNhanVien = GetAll();
            return danhSachNhanVien
                .Find(nv => nv.MaNV == Id);
        }
    }
}
