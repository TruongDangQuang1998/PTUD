using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class NamHoc
    {
        [Key]
        public int NamHocId { get; set; }
        public string TenNamHoc { get; set; }
        public virtual ICollection<MonHocHocPhan> MonHocHocPhans { get; set; }
    }
}
