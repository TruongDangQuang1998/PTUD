using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class SinhVien_MonHocHocPhan
    {
        [Key]
        public int Id { get; set; }
        public string TrangThai { get; set; }

        public virtual SinhVien SinhVien { get; set; }
        public virtual MonHocHocPhan MonHocHocPhan { get; set; }
    }
}
