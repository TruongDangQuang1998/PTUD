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
        public int Id { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string TenQuyen { get; set; }
        public string TenNguoiDung { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public int SoDienThoai { get; set; }

        public virtual CanBoDaoTao CanBoDaoTao { get; set; }
        public virtual GiangVien GiangVien { get; set; }
        public virtual SinhVien SinhVien { get; set; }

    }
}
