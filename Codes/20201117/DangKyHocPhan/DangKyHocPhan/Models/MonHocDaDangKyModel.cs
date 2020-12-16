using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Models
{
    public class MonHocDaDangKyModel
    {
        public int Id { get; set; }
        public int IdMonHoc { get; set; }
        public int STT { get; set; }
        public string MaHP { get; set; }
        public string TenMonHoc { get; set; }
        public string GiangVien { get; set; }
        public int SoTC { get; set; }
        public string TrangThai { get; set; }
        public string NhomTH { get; set; }
    }
}
