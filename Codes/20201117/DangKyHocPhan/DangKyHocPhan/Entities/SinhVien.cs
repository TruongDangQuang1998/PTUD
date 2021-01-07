using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class SinhVien
    {
        [Key]
        public int MaSoSinhVien { get; set; }
        public string TenTaiKhoan { get; set; }
        //public int MaKhoa { get; set; }
        public int NamHoc { get; set; }
        public int MaChuyenNganh { get; set; }
        public int MaLoaiDaoTao { get; set; }
        [Required, ForeignKey("TenTaiKhoan")]
        public virtual TaiKhoan TaiKhoan { get; set; }
        [Required]
        public virtual ChuyenNganh ChuyenNganh { get; set; }
        [Required]
        public virtual LoaiDaoTao LoaiDaoTao { get; set; }
        //public virtual Khoa Khoa { get; set; }
        public virtual ICollection<SinhVien_MonHocHocPhan> SinhVien_MonHocHocPhans { get; set; }
    }
}
