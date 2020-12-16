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
        public int Id { get; set; }
        public string MaLopHocPhan { get; set; }
        public string TenLopHocPhan { get; set; }
        public int SiSoDaDangKy { get; set; }
        public int SiSoToiDa { get; set; }
        public string TrangThai { get; set; }
        public int MaMonHocPhan { get; set; }
        public int MaGiaiVien { get; set; }
        public int MaPhongHoc { get; set; }
        public int Thu { get; set; }

        public virtual GiangVien GiangVien { get; set; }
        public virtual CanBoDaoTao CanBoDaoTao { get; set; }
        public virtual ICollection<TietHoc> TietHocs { get; set; }
        public virtual PhongHoc PhongHoc { get; set; }
        
        [Required]
        public virtual MonHocHocPhan MonHocHocPhan { get; set; }
    }
}
