using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class LoaiDaoTao
    {
        [Key]
        public int MaLoaiDaoTao { get; set; }
        public string TenLoaiDaoTao { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
