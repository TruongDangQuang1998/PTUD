using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class LopHocPhan
    {
        [Key]
        public int LopHocPhanId { get; set; }
        public string MaLopHocPhan { get; set; }
        public string TenLopHocPhan { get; set; }
        public int SiSoDaDangKy { get; set; }
        public int SiSoToiDa { get; set; }
        public string TrangThai { get; set; }
        public int MonHocHocPhanId { get; set; }
        [Required]
        public virtual MonHocHocPhan MonHocHocPhan { get; set; }
    }
}
