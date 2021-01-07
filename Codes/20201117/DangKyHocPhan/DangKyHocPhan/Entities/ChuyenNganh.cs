using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class ChuyenNganh
    {
        [Key]
        public int MaChuyenNganh { get; set; }
        public string TenChuyenNganh { get; set; }
        public int MaKhoa { get; set; }
        //public int SoLuongLop { get; set; }

        //public virtual ICollection<Lop> Lops { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
        public virtual ICollection<GiangVien> GiangViens { get; set; }
        [Required]
        public virtual Khoa Khoa { get; set; }
    }
}
