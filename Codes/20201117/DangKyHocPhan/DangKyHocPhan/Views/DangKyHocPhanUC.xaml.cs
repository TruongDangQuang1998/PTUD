using DangKyHocPhan.Models;
using DangKyHocPhan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DangKyHocPhan.Views
{
    /// <summary>
    /// Interaction logic for DangKyHocPhan.xaml
    /// </summary>
    public partial class DangKyHocPhanUC : UserControl
    {
        public DangKyHocPhanUC()
        {
            InitializeComponent();
            this.DataContext = new DangKyHocPhanUCModel();
            //List<MonHoc> monHocs = new List<MonHoc>();
            //monHocs.Add(new MonHoc() {  Stt=1, MaHP="123456",TenMonHoc="Môn Học 1", SoTC=3 });
            //monHocs.Add(new MonHoc() {  Stt=2, MaHP="123457",TenMonHoc="Môn Học 2", SoTC=4 });
            //monHocs.Add(new MonHoc() {  Stt=3, MaHP="123458",TenMonHoc="Môn Học 3", SoTC=3 });
            //lvMonHoc.ItemsSource = monHocs;

            //List<HocPhan> hocPhans = new List<HocPhan>();
            //hocPhans.Add(new HocPhan() { Stt = 1, MaLHP = "123456", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
            //hocPhans.Add(new HocPhan() { Stt = 2, MaLHP = "234569", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
            //hocPhans.Add(new HocPhan() { Stt = 3, MaLHP = "345678", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
            //lvHocPhan.ItemsSource = hocPhans;

            //List<ChiTiet> chiTiets = new List<ChiTiet>();
            //chiTiets.Add(new ChiTiet() { Stt = 1, GiangVien = "Nguyễn Văn A", LichHoc = "LT-Thứ 2 (T6-T8)", NhomTH = "", Phong = "A1.1", ThoiGian = "15/08/2020-15/11/2020" });
            //chiTiets.Add(new ChiTiet() { Stt = 2, GiangVien = "Nguyễn Văn A", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "1", Phong = "B11.1", ThoiGian = "15/08/2020-15/11/2020" });
            //chiTiets.Add(new ChiTiet() { Stt = 3, GiangVien = "Nguyễn Văn B", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "2", Phong = "B11.2", ThoiGian = "15/08/2020-15/11/2020" });

            //lvChiIiet.ItemsSource = chiTiets;
        }
    }
}
