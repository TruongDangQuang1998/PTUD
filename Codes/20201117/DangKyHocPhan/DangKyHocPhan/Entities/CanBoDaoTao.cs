using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class CanBoDaoTao
    {
        [Key]
        public int MaNV { get; set; }
        public string TenTaiKhoan { get; set; }
        public string ChucVu { get; set; }

        [Required, ForeignKey("TenTaiKhoan")]
        public TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
