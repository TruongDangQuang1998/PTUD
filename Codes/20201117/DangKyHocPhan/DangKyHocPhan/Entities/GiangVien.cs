using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    
    public class GiangVien
    {
        [Key]
        public int MaGiangVien { get; set; }
        public string TenTaiKhoan { get; set; }
        public int MaChuyenNganh { get; set; }
        [Required, ForeignKey("TenTaiKhoan")]
        public virtual TaiKhoan TaiKhoan { get; set; }
        [Required]
        public virtual ChuyenNganh ChuyenNganh { get; set; }
        //public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
