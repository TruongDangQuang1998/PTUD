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
        public string MaTietHoc { get; set; }
        public string MaThuHoc { get; set; }//Thứ
        public string NhomTH { get; set; }
        //public string Phong { get; set; }
        //public string GiangVien { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public int LopHocPhanId { get; set; }


        public int MaGiangVien { get; set; }
        public int MaPhongHoc { get; set; }
        //public int Thu { get; set; }

        public virtual GiangVien GiangVien { get; set; }
        //public virtual CanBoDaoTao CanBoDaoTao { get; set; }
        public virtual Thu Thu { get;set;}
        public virtual TietHoc TietHocs { get; set; }
        public virtual PhongHoc PhongHoc { get; set; }
        public virtual LopHocPhan LopHocPhan { get; set; }
    }
}
