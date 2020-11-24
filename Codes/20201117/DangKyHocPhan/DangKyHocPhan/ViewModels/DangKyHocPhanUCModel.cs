using DangKyHocPhan.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.ViewModels
{
    public class DangKyHocPhanUCModel : BaseViewModel
    {
        public DangKyHocPhanUCModel()
        {
            LoadData();
        }


        #region properties
        private ObservableCollection<string> _hocKiList;
        public ObservableCollection<string> HocKiList
        {
            get { return _hocKiList; }
            set {
                _hocKiList = value;
                OnPropertyChanged("HocKiList");
            }
        }
        private string _hocKiSelect;
        public string HocKiSelect
        {
            get { return _hocKiSelect; }
            set {
                _hocKiSelect = value;
                OnPropertyChanged("HocKiSelect");
            }
        }
        private ObservableCollection<string> _nhomTHList;
        public ObservableCollection<string> NhomTHList
        {
            get { return _nhomTHList; }
            set
            {
                _nhomTHList = value;
                OnPropertyChanged("NhomTHList");
            }
        }
        private string _nhomTHSelect;
        public string NhomTHSelect
        {
            get { return _nhomTHSelect; }
            set
            {
                _nhomTHSelect = value;
                OnPropertyChanged("NhomTHSelect");
            }
        }
        private ObservableCollection<MonHocModel> _monHocList;
        public ObservableCollection<MonHocModel> MonHocList
        {
            get { return _monHocList; }
            set
            {
                _monHocList = value;
                OnPropertyChanged("MonHocList");
            }
        }
        private MonHocModel _monHocSelect;
        public MonHocModel MonHocSelect
        {
            get { return _monHocSelect; }
            set
            {
                _monHocSelect = value;
                OnPropertyChanged("MonHocSelect");
            }
        }
        private ObservableCollection<HocPhanModel> _hocPhanList;
        public ObservableCollection<HocPhanModel> HocPhanList
        {
            get { return _hocPhanList; }
            set
            {
                _hocPhanList = value;
                OnPropertyChanged("HocPhanList");
            }
        }
        private HocPhanModel _hocPhanSelect;
        public HocPhanModel HocPhanSelect
        {
            get { return _hocPhanSelect; }
            set
            {
                _hocPhanSelect = value;
                OnPropertyChanged("HocPhanSelect");
            }
        }
        private ObservableCollection<ChiTietModel> _chiTietList;
        public ObservableCollection<ChiTietModel> ChiTietList
        {
            get { return _chiTietList; }
            set
            {
                _chiTietList = value;
                OnPropertyChanged("ChiTietList");
            }
        }
        private ChiTietModel _chiTietSelect;
        public ChiTietModel ChiTietSelect
        {
            get { return _chiTietSelect; }
            set
            {
                _chiTietSelect = value;
                OnPropertyChanged("ChiTietSelect");
            }
        }

        #endregion

        #region Methods
        public void LoadData()
        {
            var liststring = new ObservableCollection<string>();
            liststring.Add("Học kì 1(2020 - 2021)");
            liststring.Add("Học kì 3(2019 - 2020)");
            liststring.Add("Học kì 2(2019 - 2020)");
            liststring.Add("Học kì 1(2019 - 2020)");
            liststring.Add("Học kì 3(2018 - 2019)");
            liststring.Add("Học kì 2(2018 - 2019)");
            liststring.Add("Học kì 1(2018 - 2019)");
            HocKiList = liststring;
            HocKiSelect = liststring.FirstOrDefault();
            ObservableCollection<MonHocModel> monHocs = new ObservableCollection<MonHocModel>();
            monHocs.Add(new MonHocModel() { Stt = 1, MaHP = "123456", TenMonHoc = "Môn Học 1", SoTC = 3 });
            monHocs.Add(new MonHocModel() { Stt = 2, MaHP = "123457", TenMonHoc = "Môn Học 2", SoTC = 4 });
            monHocs.Add(new MonHocModel() { Stt = 3, MaHP = "123458", TenMonHoc = "Môn Học 3", SoTC = 3 });
            MonHocList = monHocs;

            ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
            hocPhans.Add(new HocPhanModel() { Stt = 1, MaLHP = "123456", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
            hocPhans.Add(new HocPhanModel() { Stt = 2, MaLHP = "234569", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
            hocPhans.Add(new HocPhanModel() { Stt = 3, MaLHP = "345678", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
            HocPhanList = hocPhans;

            ObservableCollection<ChiTietModel> chiTiets = new ObservableCollection<ChiTietModel>();
            chiTiets.Add(new ChiTietModel() { Stt = 1, GiangVien = "Nguyễn Văn A", LichHoc = "LT-Thứ 2 (T6-T8)", NhomTH = "", Phong = "A1.1", ThoiGian = "15/08/2020-15/11/2020" });
            chiTiets.Add(new ChiTietModel() { Stt = 2, GiangVien = "Nguyễn Văn A", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "1", Phong = "B11.1", ThoiGian = "15/08/2020-15/11/2020" });
            chiTiets.Add(new ChiTietModel() { Stt = 3, GiangVien = "Nguyễn Văn B", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "2", Phong = "B11.2", ThoiGian = "15/08/2020-15/11/2020" });
            ChiTietList = chiTiets;

            var list2 = new ObservableCollection<string>();
            liststring.Add("1");
            liststring.Add("2");
            NhomTHList = liststring;
            NhomTHSelect = liststring.FirstOrDefault();
        }


        
        #endregion
    }
}
