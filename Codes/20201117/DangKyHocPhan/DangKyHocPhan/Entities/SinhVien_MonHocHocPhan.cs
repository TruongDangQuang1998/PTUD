using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class SinhVien_MonHocHocPhan
    {
        [Key]
        public int Id { get; set; }
        //0 not, 1 đã đăng ký
        /// <summary>
        /// 0 chưa dăng ký
        /// 1 đã đăng ký
        /// </summary>
        public int TrangThai { get; set; }
        public int MonHocHocPhanId { get; set; }
        public int MaSoSinhVien { get; set; }
        public int LopHocPhanId { get; set; }
        public string ChiTietLopHocPhanIds { get; set; }

        public virtual SinhVien SinhVien { get; set; }
        public virtual MonHocHocPhan MonHocHocPhan { get; set; }
        //public virtual LopHocPhan LopHocPhan { get; set; }
    }
}
