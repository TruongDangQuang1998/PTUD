using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Models
{
    public class HocPhanModel
    {
        public int Id { get; set; }
        public int Stt { get; set; }
        public string MaLHP { get; set; }
        public string TenLopHocPhan { get; set; }
        public string Lop { get; set; }
        public int SiSoToiDa { get; set; }
        public int DaDangKy { get; set; }
        public string TrangThai { get; set; }
        public int MaMonHP { get; set; }
    }
}
