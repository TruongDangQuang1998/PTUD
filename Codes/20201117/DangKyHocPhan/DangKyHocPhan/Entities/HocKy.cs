using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class HocKy
    {
        [Key]
        public int MaHocKy { get; set; }
        public string TenHocKy { get; set; }

        public virtual ICollection<MonHocHocPhan> MonHocHocPhans { get; set; }
        
    }
}
