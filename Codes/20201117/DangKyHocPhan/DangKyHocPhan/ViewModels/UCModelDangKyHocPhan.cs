using DangKyHocPhan.ConnectDB;
using DangKyHocPhan.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DangKyHocPhan.ViewModels
{
    public class UCModelDangKyHocPhan : BaseViewModel
    {
        private Context _context;
        private IDataBaseService _dataBaseService;
        public UCModelDangKyHocPhan()
        {
            _dataBaseService = new DataBaseService();
            _context = new Context();
            _context = _dataBaseService.GetContext();
            //LoadData();
            LoadHocKi();
        }


        #region properties
        private ObservableCollection<NamHocModel> _namHocList;
        public ObservableCollection<NamHocModel> NamHocList
        {
            get { return _namHocList; }
            set {
                _namHocList = value;
                OnPropertyChanged("NamHocList");
            }
        }
        private NamHocModel _namHocSelect;
        public NamHocModel NamHocSelect
        {
            get { return _namHocSelect; }
            set {
                _namHocSelect = value;
                OnPropertyChanged("NamHocSelect");
                //Load  List Mon Hoc
                LoadListMonHoc();
            }
        }
        private ObservableCollection<HocKiModel> _hocKiList;
        public ObservableCollection<HocKiModel> HocKiList
        {
            get { return _hocKiList; }
            set {
                _hocKiList = value;
                OnPropertyChanged("HocKiList");
            }
        }
        private HocKiModel _hocKiSelect;
        public HocKiModel HocKiSelect
        {
            get { return _hocKiSelect; }
            set {
                _hocKiSelect = value;
                OnPropertyChanged("HocKiSelect");
                //Load  List Mon Hoc
                LoadListMonHoc();
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
                LoadListHocPhan(MonHocSelect.Id);
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
                LoadChiTietHocPhan(HocPhanSelect.Id);
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
        public void LoadHocKi()
        {
            var hockis = _context.HocKys;
            var namhocs = _context.NamHocs;
            var listHocKi = new ObservableCollection<HocKiModel>();
            var listNamHoc = new ObservableCollection<NamHocModel>();
            foreach (var item in hockis)
            {
                listHocKi.Add(new HocKiModel() { Id = item.MaHocKy, Name = item.TenHocKy });
            }
            foreach (var item in namhocs)
            {
                listNamHoc.Add(new NamHocModel() { Id = item.MaNamHoc, Name = item.TenNamHoc });
            }
            HocKiList = listHocKi;
            HocKiSelect = listHocKi.FirstOrDefault();
            NamHocList = listNamHoc;
            NamHocSelect = listNamHoc.FirstOrDefault();
        }
        
        public void LoadListMonHoc()
        {
            //HocKiSelect

            //NamHocSelect
            if (MonHocList!=null)
                MonHocList.Clear();
            ObservableCollection<MonHocModel> monHocs = new ObservableCollection<MonHocModel>();
            var monHocPhan = _context.MonHocHocPhans.Where(x => (x.HocKy.MaHocKy == HocKiSelect.Id)&&(x.nam));

            //Lọc lại nhựng môn đã đăng ký thì không hiện nữa
            //Call get List Mon Hoc for học kì




            //if (hocKiId == 1)
            //{
            //    monHocs.Add(new MonHocModel() {Id=1, Stt = 1, MaHP = "111111", TenMonHoc = "Môn Học 1", SoTC = 3 });
            //    monHocs.Add(new MonHocModel() { Id = 2, Stt = 2, MaHP = "222222", TenMonHoc = "Môn Học 2", SoTC = 4 });
            //    monHocs.Add(new MonHocModel() { Id = 3, Stt = 3, MaHP = "333333", TenMonHoc = "Môn Học 3", SoTC = 3 });

            //}
            //if (hocKiId == 2)
            //{
            //    monHocs.Add(new MonHocModel() { Id = 4, Stt = 1, MaHP = "444444", TenMonHoc = "Môn Học 1", SoTC = 3 });
            //    monHocs.Add(new MonHocModel() { Id = 5, Stt = 2, MaHP = "555555", TenMonHoc = "Môn Học 2", SoTC = 4 });
            //    monHocs.Add(new MonHocModel() { Stt = 3, Id = 6, MaHP = "666666", TenMonHoc = "Môn Học 3", SoTC = 3 });
            //}
            MonHocList = monHocs;


        }

        public void LoadListHocPhan(int monHocId)
        {
            if (HocPhanList != null)
                HocPhanList.Clear();

            if(monHocId == 1)
            {
                ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
                hocPhans.Add(new HocPhanModel() {Id=1, Stt = 1, MaLHP = "123456", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() {Id=2, Stt = 2, MaLHP = "234569", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() {Id=3, Stt = 3, MaLHP = "345678", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                HocPhanList = hocPhans;
            }
            if (monHocId == 2)
            {
                ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
                hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                HocPhanList = hocPhans;
            }
            if (monHocId == 3)
            {
                ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
                hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                HocPhanList = hocPhans;
            }
            if (monHocId == 4)
            {
                ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
                hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                HocPhanList = hocPhans;
            }
            if (monHocId == 5)
            {
                ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
                hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                HocPhanList = hocPhans;
            }
            if (monHocId == 6)
            {
                ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
                hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
                HocPhanList = hocPhans;
            }
        }

        public void LoadChiTietHocPhan(int hocPhanId)
        {
            if (ChiTietList != null)
                ChiTietList.Clear();
            ObservableCollection<ChiTietModel> chiTiets = new ObservableCollection<ChiTietModel>();
            chiTiets.Add(new ChiTietModel() { Stt = 1, GiangVien = "Nguyễn Văn A", LichHoc = "LT-Thứ 2 (T6-T8)", NhomTH = "", Phong = "A1.1", ThoiGian = "15/08/2020-15/11/2020" });
            chiTiets.Add(new ChiTietModel() { Stt = 2, GiangVien = "Nguyễn Văn A", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "1", Phong = "B11.1", ThoiGian = "15/08/2020-15/11/2020" });
            chiTiets.Add(new ChiTietModel() { Stt = 3, GiangVien = "Nguyễn Văn B", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "2", Phong = "B11.2", ThoiGian = "15/08/2020-15/11/2020" });
            ChiTietList = chiTiets;
            LoadNhomThucHanh(hocPhanId);
        }
        public void LoadNhomThucHanh(int hocPhanId)
        {
            if (NhomTHList != null)
                NhomTHList.Clear();
            var list2 = new ObservableCollection<string>();
            if(hocPhanId == 1 || hocPhanId == 3 || hocPhanId == 5 || hocPhanId == 5)
            {
                list2.Add("1");
                list2.Add("2");
            }
            if (hocPhanId == 2 || hocPhanId ==  4|| hocPhanId == 6 || hocPhanId == 8)
            {
                list2.Add("1");
            }
            NhomTHList = list2;
            NhomTHSelect = list2.FirstOrDefault();
        }
        public void LoadData()
        {
            //var liststring = new ObservableCollection<string>();
            //liststring.Add("Học kì 1(2020 - 2021)");
            //liststring.Add("Học kì 3(2019 - 2020)");
            //liststring.Add("Học kì 2(2019 - 2020)");
            //liststring.Add("Học kì 1(2019 - 2020)");
            //liststring.Add("Học kì 3(2018 - 2019)");
            //liststring.Add("Học kì 2(2018 - 2019)");
            //liststring.Add("Học kì 1(2018 - 2019)");
            //HocKiList = liststring;
            //HocKiSelect = liststring.FirstOrDefault();
            //ObservableCollection<MonHocModel> monHocs = new ObservableCollection<MonHocModel>();
            //monHocs.Add(new MonHocModel() { Stt = 1, MaHP = "123456", TenMonHoc = "Môn Học 1", SoTC = 3 });
            //monHocs.Add(new MonHocModel() { Stt = 2, MaHP = "123457", TenMonHoc = "Môn Học 2", SoTC = 4 });
            //monHocs.Add(new MonHocModel() { Stt = 3, MaHP = "123458", TenMonHoc = "Môn Học 3", SoTC = 3 });
            //MonHocList = monHocs;

            //ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
            //hocPhans.Add(new HocPhanModel() { Stt = 1, MaLHP = "123456", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
            //hocPhans.Add(new HocPhanModel() { Stt = 2, MaLHP = "234569", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
            //hocPhans.Add(new HocPhanModel() { Stt = 3, MaLHP = "345678", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
            //HocPhanList = hocPhans;
            
            ObservableCollection<ChiTietModel> chiTiets = new ObservableCollection<ChiTietModel>();
            chiTiets.Add(new ChiTietModel() { Stt = 1, GiangVien = "Nguyễn Văn A", LichHoc = "LT-Thứ 2 (T6-T8)", NhomTH = "", Phong = "A1.1", ThoiGian = "15/08/2020-15/11/2020" });
            chiTiets.Add(new ChiTietModel() { Stt = 2, GiangVien = "Nguyễn Văn A", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "1", Phong = "B11.1", ThoiGian = "15/08/2020-15/11/2020" });
            chiTiets.Add(new ChiTietModel() { Stt = 3, GiangVien = "Nguyễn Văn B", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "2", Phong = "B11.2", ThoiGian = "15/08/2020-15/11/2020" });
            ChiTietList = chiTiets;

            var list2 = new ObservableCollection<string>();
            list2.Add("1");
            list2.Add("2");
            NhomTHList = list2;
            NhomTHSelect = list2.FirstOrDefault();
        }
        #endregion

        #region ICommnad
        //DangKyHocPhan
        public ICommand DangKyHocPhan
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                });

            }
        }
        #endregion
    }
}
