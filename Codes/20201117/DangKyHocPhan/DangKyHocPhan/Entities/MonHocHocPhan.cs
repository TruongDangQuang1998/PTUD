using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class MonHocHocPhan
    {
        [Key]
        public int Id { get; set; }
        public string MaMonHocPhan { get; set; }
        public int MonHocId { get; set; }
        public string TrangThai { get; set; }
        public int MaHocKi { get; set; }
        public int MaNamHoc { get; set; }
        [Required]
        public virtual MonHoc MonHoc { get; set; }
        public virtual ICollection<SinhVien_MonHocHocPhan> SinhVien_MonHocHocPhans { get; set; }
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
        [Required]
        public virtual HocKy HocKy { get; set; }
        [Required]
        public virtual NamHoc NamHoc { get; set; }
    }
}
