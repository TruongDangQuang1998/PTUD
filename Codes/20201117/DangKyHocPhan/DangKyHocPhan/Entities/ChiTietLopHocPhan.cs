using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class ChiTietLopHocPhan
    {
        [Key]
        public int ChiTietLopHocPhanId { get; set; }
        //public string LichHoc { get; set; }
        public string TietHoc { get; set; }
        public string ThuHoc { get; set; }//Thứ
        public string NhomTH { get; set; }
        //public string Phong { get; set; }
        //public string GiangVien { get; set; }
        public string ThoiGian { get; set; }
        public int MaLopHocPhan { get; set; }


        public int MaGiaiVien { get; set; }
        public int MaPhongHoc { get; set; }
        //public int Thu { get; set; }

        public virtual GiangVien GiangVien { get; set; }
        //public virtual CanBoDaoTao CanBoDaoTao { get; set; }
        public virtual TietHoc TietHocs { get; set; }
        public virtual PhongHoc PhongHoc { get; set; }
    }
}
