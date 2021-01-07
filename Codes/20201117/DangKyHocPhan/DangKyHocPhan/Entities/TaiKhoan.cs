using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class TaiKhoan
    {
        [Key]
        //public int TaiKhoanId { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string TenQuyen { get; set; }
        public string TenNguoiDung { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        
        public virtual List<GiangVien> GiangVien { get; set; }
        public virtual List<SinhVien> SinhVien { get; set; }
        public virtual List<CanBoDaoTao> CanBoDaoTao { get; set; }

    }
}
