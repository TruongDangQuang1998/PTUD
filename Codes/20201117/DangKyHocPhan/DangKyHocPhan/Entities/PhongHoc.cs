using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class PhongHoc
    {
        [Key]
        public int MaPhongHoc { get; set; }
        public string TenPhong { get; set; }
        public int SoLuongPhong { get; set; }
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
