using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class TietHoc
    {
        [Key]
        public int MaTietHoc { get; set; }
        public string TenTietHoc { get; set; }
        public virtual LopHocPhan LopHocPhan { get; set; }
    }
}
