using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class Khoa
    {
        [Key]
        public int Id { get; set; }
        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public int SoLuong { get; set; }
        public virtual ICollection<ChuyenNganh> ChuyenNganhs { get; set; }
    }
}
