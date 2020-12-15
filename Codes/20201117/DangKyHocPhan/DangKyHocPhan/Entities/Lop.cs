using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class Lop
    {
        [Key]
        public int IdLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        [Required]
        public virtual ChuyenNganh ChuyenNganh { get; set; }
    }
}
