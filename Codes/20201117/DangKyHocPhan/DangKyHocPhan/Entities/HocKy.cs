using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class HocKi
    {
        [Key]
        public int HocKiId { get; set; }
        public string TenHocKi { get; set; }

        public virtual ICollection<MonHocHocPhan> MonHocHocPhans { get; set; }
        
    }
}
