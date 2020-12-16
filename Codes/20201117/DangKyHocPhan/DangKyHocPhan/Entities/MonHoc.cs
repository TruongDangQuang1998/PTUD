using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class MonHoc
    {
        [Key]
        public int Id { get; set; }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int SoTinChi { get; set; }
        public string TrangThai { get; set; }
        public int SoTinChiLyThuyet { get; set; }
        public int SoTinChiThucHanh { get; set; }

        public virtual MonHocHocPhan MonHocHocPhan { get; set; }
    }
}
