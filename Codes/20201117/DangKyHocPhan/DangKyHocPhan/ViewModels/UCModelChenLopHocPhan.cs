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
    public class UCModelChenLopHocPhan : BaseViewModel
    {
        public Context _context;
        public UCModelChenLopHocPhan()
        {
            _context = new Context();
            //LoadSinhVien();LoadHocKi();
            LoadHocKi();
        }
        #region properties
        private ObservableCollection<HocKiModel> _hocKiList;
        public ObservableCollection<HocKiModel> HocKiList
        {
            get { return _hocKiList; }
            set
            {
                _hocKiList = value;
                OnPropertyChanged("HocKiList");
            }
        }
        private HocKiModel _hocKiSelect;
        public HocKiModel HocKiSelect
        {
            get { return _hocKiSelect; }
            set
            {
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
                LoadListHocPhan();
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
                LoadChiTietHocPhan();
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

        private ObservableCollection<SinhVienModel> _sinhvienList;
        public ObservableCollection<SinhVienModel> SinhVienList
        {
            get { return _sinhvienList; }
            set
            {
                _sinhvienList = value;
                OnPropertyChanged("SinhVienList");
            }
        }
        private SinhVienModel _sinhVienSelect;
        public SinhVienModel SinhVienSelect
        {
            get { return _sinhVienSelect; }
            set
            {
                _sinhVienSelect = value;
                OnPropertyChanged("SinhVienSelect");
                TenSinhVien = value.Name;
                KhoaSinhVien = value.Khoa;
                LopSinhVien = value.Lop;
                ChuyenNganhSinhVien = value.ChuyenNganh;
            }
        }
        private string _mssvText;
        public string MSSVText
        {
            get { return _mssvText; }
            set
            {
                _mssvText = value;
                OnPropertyChanged("MSSVText");
            }
        }
        private string _khoaSinhVien;
        public string KhoaSinhVien
        {
            get { return _khoaSinhVien; }
            set
            {
                _khoaSinhVien = value;
                OnPropertyChanged("KhoaSinhVien");
            }
        }
        private string _chuyenNganhSinhVien;
        public string ChuyenNganhSinhVien
        {
            get { return _chuyenNganhSinhVien; }
            set
            {
                _chuyenNganhSinhVien = value;
                OnPropertyChanged("ChuyenNganhSinhVien");
            }
        }
        private string _lopSinhVien;
        public string LopSinhVien
        {
            get { return _lopSinhVien; }
            set
            {
                _lopSinhVien = value;
                OnPropertyChanged("LopSinhVien");
            }
        }
        private string _tenSinhVien;
        public string TenSinhVien
        {
            get { return _tenSinhVien; }
            set
            {
                _tenSinhVien = value;
                OnPropertyChanged("TenSinhVien");
            }
        }

        #endregion

        #region Methods
        //public void LoadSinhVien()
        //{
        //    var listSinhvien = new ObservableCollection<SinhVienModel>();
        //    listSinhvien.Add(new SinhVienModel() { Id = 1, MSSV = "12345678", Khoa = "CNTT", ChuyenNganh = "KTPM", Lop = "13B", Name = "Sinh Viên 1" });
        //    listSinhvien.Add(new SinhVienModel() { Id = 2, MSSV = "22345678", Khoa = "CNTT", ChuyenNganh = "KTPM", Lop = "13B", Name = "Sinh Viên 2" });
        //    listSinhvien.Add(new SinhVienModel() { Id = 3, MSSV = "32345678", Khoa = "CNTT", ChuyenNganh = "KTPM", Lop = "13B", Name = "Sinh Viên 3" });
        //    listSinhvien.Add(new SinhVienModel() { Id = 4, MSSV = "42345678", Khoa = "CNTT", ChuyenNganh = "KTPM", Lop = "13B", Name = "Sinh Viên 4" });
        //    listSinhvien.Add(new SinhVienModel() { Id = 5, MSSV = "52345678", Khoa = "CNTT", ChuyenNganh = "KTPM", Lop = "13B", Name = "Sinh Viên 5" });
        //    listSinhvien.Add(new SinhVienModel() { Id = 6, MSSV = "62345678", Khoa = "CNTT", ChuyenNganh = "KTPM", Lop = "13B", Name = "Sinh Viên 6" });
        //    listSinhvien.Add(new SinhVienModel() { Id = 7, MSSV = "72345678", Khoa = "CNTT", ChuyenNganh = "KTPM", Lop = "13B", Name = "Sinh Viên 7" });

        //    SinhVienList = listSinhvien;
        //}

        //public void LoadHocKi()
        //{
        //    var liststring = new ObservableCollection<HocKiModel>();
        //    liststring.Add(new HocKiModel() { Id = 1, Name = "Học kì 1(2020 - 2021)" });
        //    liststring.Add(new HocKiModel() { Id = 2, Name = "Học kì 3(2019 - 2020)" });
        //    liststring.Add(new HocKiModel() { Id = 3, Name = "Học kì 2(2019 - 2020)" });
        //    liststring.Add(new HocKiModel() { Id = 4, Name = "Học kì 1(2019 - 2020)" });
        //    liststring.Add(new HocKiModel() { Id = 5, Name = "Học kì 3(2018 - 2019)" });
        //    liststring.Add(new HocKiModel() { Id = 6, Name = "Học kì 2(2018 - 2019)" });
        //    liststring.Add(new HocKiModel() { Id = 7, Name = "Học kì 1(2018 - 2019)" });
        //    HocKiList = liststring;
        //    HocKiSelect = liststring.FirstOrDefault();
        //}

        //public void LoadListMonHoc(int hocKiId)
        //{
        //    //HocKiSelect
        //    if (MonHocList != null)
        //        MonHocList.Clear();
        //    ObservableCollection<MonHocModel> monHocs = new ObservableCollection<MonHocModel>();
        //    //Call get List Mon Hoc for học kì
        //    //if (hocKiId == 1)
        //    //{
        //    //    monHocs.Add(new MonHocModel() { Id = 1, Stt = 1, MaHP = "111111", TenMonHoc = "Môn Học 1", SoTC = 3 });
        //    //    monHocs.Add(new MonHocModel() { Id = 2, Stt = 2, MaHP = "222222", TenMonHoc = "Môn Học 2", SoTC = 4 });
        //    //    monHocs.Add(new MonHocModel() { Id = 3, Stt = 3, MaHP = "333333", TenMonHoc = "Môn Học 3", SoTC = 3 });

        //    //}
        //    //if (hocKiId == 2)
        //    //{
        //    //    monHocs.Add(new MonHocModel() { Id = 4, Stt = 1, MaHP = "444444", TenMonHoc = "Môn Học 1", SoTC = 3 });
        //    //    monHocs.Add(new MonHocModel() { Id = 5, Stt = 2, MaHP = "555555", TenMonHoc = "Môn Học 2", SoTC = 4 });
        //    //    monHocs.Add(new MonHocModel() { Stt = 3, Id = 6, MaHP = "666666", TenMonHoc = "Môn Học 3", SoTC = 3 });
        //    //}
        //    MonHocList = monHocs;


        //}

        //public void LoadListHocPhan(int monHocId)
        //{
        //    if (HocPhanList != null)
        //        HocPhanList.Clear();

        //    if (monHocId == 1)
        //    {
        //        ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
        //        hocPhans.Add(new HocPhanModel() { Id = 1, Stt = 1, MaLHP = "123456", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 2, Stt = 2, MaLHP = "234569", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 3, Stt = 3, MaLHP = "345678", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        HocPhanList = hocPhans;
        //    }
        //    if (monHocId == 2)
        //    {
        //        ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
        //        hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        HocPhanList = hocPhans;
        //    }
        //    if (monHocId == 3)
        //    {
        //        ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
        //        hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        HocPhanList = hocPhans;
        //    }
        //    if (monHocId == 4)
        //    {
        //        ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
        //        hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        HocPhanList = hocPhans;
        //    }
        //    if (monHocId == 5)
        //    {
        //        ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
        //        hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        HocPhanList = hocPhans;
        //    }
        //    if (monHocId == 6)
        //    {
        //        ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
        //        hocPhans.Add(new HocPhanModel() { Id = 4, Stt = 1, MaLHP = "111111", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 5, Stt = 2, MaLHP = "222222", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        hocPhans.Add(new HocPhanModel() { Id = 6, Stt = 3, MaLHP = "333333", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //        HocPhanList = hocPhans;
        //    }
        //}

        //public void LoadChiTietHocPhan(int hocPhanId)
        //{
        //    if (ChiTietList != null)
        //        ChiTietList.Clear();
        //    ObservableCollection<ChiTietModel> chiTiets = new ObservableCollection<ChiTietModel>();
        //    chiTiets.Add(new ChiTietModel() { Stt = 1, GiangVien = "Nguyễn Văn A", LichHoc = "LT-Thứ 2 (T6-T8)", NhomTH = "", Phong = "A1.1", ThoiGian = "15/08/2020-15/11/2020" });
        //    chiTiets.Add(new ChiTietModel() { Stt = 2, GiangVien = "Nguyễn Văn A", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "1", Phong = "B11.1", ThoiGian = "15/08/2020-15/11/2020" });
        //    chiTiets.Add(new ChiTietModel() { Stt = 3, GiangVien = "Nguyễn Văn B", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "2", Phong = "B11.2", ThoiGian = "15/08/2020-15/11/2020" });
        //    ChiTietList = chiTiets;
        //    LoadNhomThucHanh(hocPhanId);
        //}
        //public void LoadNhomThucHanh(int hocPhanId)
        //{
        //    if (NhomTHList != null)
        //        NhomTHList.Clear();
        //    var list2 = new ObservableCollection<string>();
        //    if (hocPhanId == 1 || hocPhanId == 3 || hocPhanId == 5 || hocPhanId == 5)
        //    {
        //        list2.Add("1");
        //        list2.Add("2");
        //    }
        //    if (hocPhanId == 2 || hocPhanId == 4 || hocPhanId == 6 || hocPhanId == 8)
        //    {
        //        list2.Add("1");
        //    }
        //    NhomTHList = list2;
        //    NhomTHSelect = list2.FirstOrDefault();
        //}
        //public void LoadData()
        //{
        //    //var liststring = new ObservableCollection<string>();
        //    //liststring.Add("Học kì 1(2020 - 2021)");
        //    //liststring.Add("Học kì 3(2019 - 2020)");
        //    //liststring.Add("Học kì 2(2019 - 2020)");
        //    //liststring.Add("Học kì 1(2019 - 2020)");
        //    //liststring.Add("Học kì 3(2018 - 2019)");
        //    //liststring.Add("Học kì 2(2018 - 2019)");
        //    //liststring.Add("Học kì 1(2018 - 2019)");
        //    //HocKiList = liststring;
        //    //HocKiSelect = liststring.FirstOrDefault();
        //    //ObservableCollection<MonHocModel> monHocs = new ObservableCollection<MonHocModel>();
        //    //monHocs.Add(new MonHocModel() { Stt = 1, MaHP = "123456", TenMonHoc = "Môn Học 1", SoTC = 3 });
        //    //monHocs.Add(new MonHocModel() { Stt = 2, MaHP = "123457", TenMonHoc = "Môn Học 2", SoTC = 4 });
        //    //monHocs.Add(new MonHocModel() { Stt = 3, MaHP = "123458", TenMonHoc = "Môn Học 3", SoTC = 3 });
        //    //MonHocList = monHocs;

        //    //ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
        //    //hocPhans.Add(new HocPhanModel() { Stt = 1, MaLHP = "123456", TenLopHocPhan = "Lop123", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //    //hocPhans.Add(new HocPhanModel() { Stt = 2, MaLHP = "234569", TenLopHocPhan = "Lop234", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //    //hocPhans.Add(new HocPhanModel() { Stt = 3, MaLHP = "345678", TenLopHocPhan = "Lop345", Lop = "DHKTPM13B", SiSoToiDa = "80", DaDangKy = "50", TrangThai = "Chờ Sinh Viên Đăng Ký" });
        //    //HocPhanList = hocPhans;

        //    ObservableCollection<ChiTietModel> chiTiets = new ObservableCollection<ChiTietModel>();
        //    chiTiets.Add(new ChiTietModel() { Stt = 1, GiangVien = "Nguyễn Văn A", LichHoc = "LT-Thứ 2 (T6-T8)", NhomTH = "", Phong = "A1.1", ThoiGian = "15/08/2020-15/11/2020" });
        //    chiTiets.Add(new ChiTietModel() { Stt = 2, GiangVien = "Nguyễn Văn A", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "1", Phong = "B11.1", ThoiGian = "15/08/2020-15/11/2020" });
        //    chiTiets.Add(new ChiTietModel() { Stt = 3, GiangVien = "Nguyễn Văn B", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "2", Phong = "B11.2", ThoiGian = "15/08/2020-15/11/2020" });
        //    ChiTietList = chiTiets;

        //    var list2 = new ObservableCollection<string>();
        //    list2.Add("1");
        //    list2.Add("2");
        //    NhomTHList = list2;
        //    NhomTHSelect = list2.FirstOrDefault();
        //}
        #endregion
        public int IdSv;
        #region ICommnad
        //DangKyHocPhan
        private int mssv;
        public ICommand TimKiemSinhVien
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    var svs = _context.SinhViens;
                    var sv = svs.FirstOrDefault(x => x.TenTaiKhoan == MSSVText);
                    //var a = DataFree.sinhVienModels.FirstOrDefault(x => x.MSSV == MSSVText);
                    if (sv != null)
                    {
                        KhoaSinhVien = sv.ChuyenNganh.Khoa.TenKhoa;
                        ChuyenNganhSinhVien = sv.ChuyenNganh.TenChuyenNganh;
                        TenSinhVien = sv.TaiKhoan.TenNguoiDung;
                        //LopSinhVien = sv.lo ;
                        IdSv = sv.MaSoSinhVien;
                        mssv = sv.MaSoSinhVien;
                        LoadListMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Sinh Viên", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                });

            }
        }
        #endregion

        public void LoadHocKi()
        {
            HocKiList = new ObservableCollection<HocKiModel>();
            foreach (var item in _context.HocKis)
            {
                HocKiList.Add(new HocKiModel() { Id = item.HocKiId, Name = item.TenHocKi });
            }
            HocKiSelect = HocKiList.FirstOrDefault();
            NamHocList = new ObservableCollection<NamHocModel>();
            foreach (var item in _context.NamHocs)
            {
                NamHocList.Add(new NamHocModel() { Id = item.NamHocId, Name = item.TenNamHoc });
            }
            NamHocSelect = NamHocList.FirstOrDefault();
        }

        public void LoadListMonHoc()
        {
            MonHocDaDangKyList = new ObservableCollection<MonHocDaDangKyModel>();
            MonHocList = new ObservableCollection<MonHocModel>();
            if (HocKiSelect != null && NamHocSelect != null)
            {
                //if (HocKiSelect.Id == 1 && NamHocSelect.Id == 1)
                if (MonHocList != null)
                {
                    var stt = 1;
                    var sttdadk = 1;
                    var dk = _context.SinhVien_MonHocHocPhans.Where(x=>x.MaSoSinhVien == mssv);
                    if (dk.Count() !=0)
                    {
                        foreach (var item in _context.MonHocHocPhans)
                        {
                            var sv_mh = dk.FirstOrDefault(x => x.MonHocHocPhanId == item.MonHocHocPhanId && x.TrangThai == 1);
                            if (sv_mh == null)
                            {
                                if (item.HocKiId == HocKiSelect.Id && item.NamHocId == NamHocSelect.Id)
                                {
                                    MonHocList.Add(new MonHocModel() { Id = item.MonHocHocPhanId, MaMH = item.MonHoc.MaMonHoc, SoTC = item.MonHoc.SoTinChi, Stt = stt, TenMonHoc = item.MonHoc.TenMonHoc });
                                    stt++;
                                }
                            }
                            else
                            {
                                var monh = sv_mh.MonHocHocPhan.MonHoc;
                                var chitiet = _context.ChiTietLopHocPhans.FirstOrDefault(x => x.ChiTietLopHocPhanId.ToString() == sv_mh.ChiTietLopHocPhanIds);
                                //var chitiet = _context.ChiTietLopHocPhans.FirstOrDefault(x => x.ChiTietLopHocPhanId == int.Parse(sv_mh.ChiTietLopHocPhanIds));
                                if (monh != null && chitiet != null)
                                {
                                    var trangthai = chitiet.LopHocPhan.TrangThai;
                                    var tt = "";
                                    switch (trangthai)
                                    {
                                        case "0":
                                            tt = "Chờ sinh viên đăng ký";
                                            break;
                                        case "1":
                                            tt = "Chấp nhận mở lớp";
                                            break;
                                        case "2":
                                            tt = "Chờ hủy lớp";
                                            break;
                                    }
                                    MonHocDaDangKyList.Add(new MonHocDaDangKyModel()
                                    {
                                        Id = sv_mh.Id,
                                        STT = sttdadk,
                                        MaHP = monh.MaMonHoc,
                                        NhomTH = chitiet.NhomTH == "0" ? "" : chitiet.NhomTH,
                                        TenMonHoc = monh.TenMonHoc,
                                        SoTC = monh.SoTinChi,
                                        TrangThai = tt

                                        //= item.MaMonHocPhan, 
                                        //SoTC = item.MonHoc.SoTinChi, Stt = stt, 
                                        //TenMonHoc = item.MonHoc.TenMonHoc, 
                                        //TrangThaiDangKy = item.TrangThai 
                                    });
                                    sttdadk++;
                                }
                            }
                        }
                    }
                }
            }

            //MonHocDaDangKyList = new ObservableCollection<MonHocDaDangKyModel>();
            //MonHocList = new ObservableCollection<MonHocModel>();
            //if (HocKiSelect != null && NamHocSelect != null)
            //{
            //    var sv = DataFree.sinhVienModels.FirstOrDefault(x => x.Id == IdSv);
            //    if(sv!=null)
            //    {
            //        if (HocKiSelect.Id == 1 && NamHocSelect.Id == 1)
            //            foreach (var item in DataFree.monHocModels)
            //            {
            //                if (MonHocList != null)
            //                    if (sv.IdMonHocs.FirstOrDefault(x=>x == item.Id)==0)
            //                        MonHocList.Add(item);
            //            }
            //        foreach (var item in sv.MonHocDaDangKyModels)
            //        {
            //            MonHocDaDangKyList.Add(item);
            //        }
            //    }

            //    //if (HocKiSelect.Id == 1 && NamHocSelect.Id == 1)
            //    //    foreach (var item in DataFree.monHocModels)
            //    //    {
            //    //        if (MonHocList != null)
            //    //            if (item.TrangThaiDangKy!= )
            //    //                MonHocList.Add(item);
            //    //    }
            //}

        }

        private NamHocModel _namHocSelect;
        public NamHocModel NamHocSelect
        {
            get { return _namHocSelect; }
            set
            {
                _namHocSelect = value;
                OnPropertyChanged("NamHocSelect");
                //Load  List Mon Hoc
                LoadListMonHoc();
            }
        }
        private ObservableCollection<NamHocModel> _namHocList;
        public ObservableCollection<NamHocModel> NamHocList
        {
            get { return _namHocList; }
            set
            {
                _namHocList = value;
                OnPropertyChanged("NamHocList");
            }
        }
        private ObservableCollection<MonHocDaDangKyModel> _monHocDaDangKyList;
        public ObservableCollection<MonHocDaDangKyModel> MonHocDaDangKyList
        {
            get { return _monHocDaDangKyList; }
            set
            {
                _monHocDaDangKyList = value;
                OnPropertyChanged("MonHocDaDangKyList");
            }
        }
        private MonHocDaDangKyModel _monHocDaDangKySelect;
        public MonHocDaDangKyModel MonHocDaDangKySelect
        {
            get { return _monHocDaDangKySelect; }
            set
            {
                _monHocDaDangKySelect = value;
                OnPropertyChanged("MonHocDaDangKySelect");
            }
        }
        public void LoadListHocPhan()
        {
            HocPhanList = new ObservableCollection<HocPhanModel>();
            if (HocPhanList != null)
                HocPhanList.Clear();
            if (MonHocSelect != null)
            {
                var stt = 1;
                foreach (var item in _context.LopHocPhans)
                {
                    //if (MonHocSelect.Id == item.MaMonHP)
                    //    HocPhanList.Add(item);
                    if (MonHocSelect.Id == item.MonHocHocPhanId)
                    {
                        var tt = "";
                        switch (item.TrangThai)
                        {
                            case "0":
                                tt = "Chờ sinh viên đăng ký";
                                break;
                            case "1":
                                tt = "Chấp nhận mở lớp";
                                break;
                            case "2":
                                tt = "Chờ hủy lớp";
                                break;
                        }

                        HocPhanList.Add(new HocPhanModel()
                        {
                            Id = item.LopHocPhanId,
                            DaDangKy = item.SiSoDaDangKy,
                            SiSoToiDa = item.SiSoToiDa,
                            Lop = item.TenLopHocPhan,
                            Stt = stt,
                            MaLHP = MonHocSelect.MaMH + item.MaLopHocPhan,
                            MaMonHP = item.MonHocHocPhan.MonHocHocPhanId,
                            TenLopHocPhan = item.MonHocHocPhan.MonHoc.TenMonHoc,
                            TrangThai = tt//item.TrangThai
                                          //0 chờ sinh vien đăng ký
                                          //1 chấp nhập mở lớp
                                          //2 Chờ hủy lớp

                        }); //item
                        stt++;
                    }
                }
            }


            //HocPhanList = new ObservableCollection<HocPhanModel>();
            //if (HocPhanList != null)
            //    HocPhanList.Clear();
            //if (MonHocSelect != null)
            //{
            //    foreach (var item in DataFree.hocPhanModels)
            //    {
            //        if (MonHocSelect.Id == item.MaMonHP)
            //            HocPhanList.Add(item);
            //    }
            //}
        }

        public void LoadChiTietHocPhan()
        {
            ChiTietList = new ObservableCollection<ChiTietModel>();
            NhomTHList = new ObservableCollection<string>();
            if (HocPhanSelect != null)
            {
                var stt = 1;
                foreach (var item in _context.ChiTietLopHocPhans)
                {
                    if (HocPhanSelect.Id == item.LopHocPhanId)
                    {
                        ChiTietList.Add(new ChiTietModel()
                        {
                            Id = item.ChiTietLopHocPhanId,
                            GiangVien = item.GiangVien.TaiKhoan.TenNguoiDung,
                            LichHoc = item.Thu.TenThuHoc + " Tiết" + item.TietHocs.TenTietHoc,
                            MaLopHocPhan = HocPhanSelect.MaLHP,
                            NhomTH = item.NhomTH == "0" ? "" : item.NhomTH,
                            Phong = item.PhongHoc.TenPhong,
                            Stt = stt,
                            ThoiGian = item.ThoiGianBatDau.ToString("dd/MM/yyyy") + " - " + item.ThoiGianKetThuc.ToString("dd/MM/yyyy")
                        });
                        stt++; if (!string.IsNullOrEmpty(item.NhomTH))
                        {
                            if (item.NhomTH != "0")
                            {
                                NhomTHList.Add(item.NhomTH);
                                NhomTHSelect = NhomTHList.FirstOrDefault();
                            }
                        }
                    }
                    
                }
            }




            //ChiTietList = new ObservableCollection<ChiTietModel>();
            //NhomTHList = new ObservableCollection<string>();
            //if (HocPhanSelect != null)
            //{
            //    foreach (var item in DataFree.chiTietModels)
            //    {
            //        if (HocPhanSelect.Id == item.MaLopHocPhan)
            //        {
            //            ChiTietList.Add(item);
            //        }
            //        if (!string.IsNullOrEmpty(item.NhomTH))
            //        {
            //            NhomTHList.Add(item.NhomTH);
            //            NhomTHSelect = NhomTHList.FirstOrDefault();
            //        }
            //    }
            //}
        }
        public ICommand DangKyHocPhan
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (MonHocSelect != null && HocPhanSelect != null)
                    {
                        if (ChiTietList.Count == 0)
                        {
                            MessageBox.Show("Bạn chưa chọn môn học.\n Vui lòng chọn môn học trước khí đăng ký", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else if (ChiTietList.Count == 1 && ChiTietSelect != null)
                        {
                            MonHocDaDangKyList.Add(new MonHocDaDangKyModel()
                            {
                                Id = HocPhanSelect.Id,
                                GiangVien = ChiTietSelect.GiangVien,
                                MaHP = HocPhanSelect.MaLHP,
                                SoTC = MonHocSelect.SoTC,
                                STT = MonHocDaDangKyList.Count + 1,
                                TenMonHoc = MonHocSelect.TenMonHoc,
                                TrangThai = HocPhanSelect.TrangThai,
                                IdMonHoc = MonHocSelect.Id
                                //,lịch học
                            });
                            var sv_hp = _context.SinhVien_MonHocHocPhans;
                            sv_hp.Add(new Entities.SinhVien_MonHocHocPhan()
                            {
                                LopHocPhanId = HocPhanSelect.Id,
                                ChiTietLopHocPhanIds = ChiTietSelect.Id.ToString(),
                                MaSoSinhVien = _context.SinhViens.FirstOrDefault(x => x.TenTaiKhoan == test.User).MaSoSinhVien,//Todo
                                MonHocHocPhanId = MonHocSelect.Id,
                                TrangThai = 1
                            });
                            //0 chưa đăng ký
                            //1 là đăng ký rồi
                            //var monhoc = DataFree.monHocModels.FirstOrDefault(x => x.Id == MonHocSelect.Id);
                            //monhoc.TrangThaiDangKy = 1;
                            MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                        }
                        else if (NhomTHSelect != null && ChiTietSelect != null)
                        {
                            MonHocDaDangKyList.Add(new MonHocDaDangKyModel()
                            {
                                Id = HocPhanSelect.Id,
                                GiangVien = ChiTietSelect.GiangVien,
                                MaHP = HocPhanSelect.MaLHP,
                                SoTC = MonHocSelect.SoTC,
                                STT = MonHocDaDangKyList.Count + 1,
                                TenMonHoc = MonHocSelect.TenMonHoc,
                                TrangThai = HocPhanSelect.TrangThai,
                                IdMonHoc = MonHocSelect.Id,
                                NhomTH = NhomTHSelect
                            });
                            var sv_hp = _context.SinhVien_MonHocHocPhans;
                            sv_hp.Add(new Entities.SinhVien_MonHocHocPhan()
                            {
                                LopHocPhanId = HocPhanSelect.Id,
                                ChiTietLopHocPhanIds = ChiTietSelect.Id.ToString(),
                                MaSoSinhVien = mssv,//Todo
                                MonHocHocPhanId = MonHocSelect.Id,
                                TrangThai = 1,
                            });
                            //var monhoc = DataFree.monHocModels.FirstOrDefault(x => x.Id == MonHocSelect.Id);
                            //monhoc.TrangThaiDangKy = 1;
                            MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn Nhóm Thực hành", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    _context.SaveChanges();
                    LoadListMonHoc();


                    //if (MonHocSelect != null && HocPhanSelect != null)
                    //{
                    //    var sv = DataFree.sinhVienModels.FirstOrDefault(x => x.Id == IdSv);
                    //    if (ChiTietList.Count == 0)
                    //    {
                    //        MessageBox.Show("Bạn chưa chọn môn học.\n Vui lòng chọn môn học trước khí đăng ký", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    //    }
                    //    else if (ChiTietList.Count == 1&& ChiTietSelect!=null)
                    //    {
                    //        //DataFree.monHocDaDangKyModels.
                    //        //var monhoc = DataFree.monHocModels.FirstOrDefault(x => x.Id == MonHocSelect.Id);
                    //        //monhoc.TrangThaiDangKy = 1;


                    //        sv.IdMonHocs.Add(MonHocSelect.Id);
                    //        sv.MonHocDaDangKyModels.Add(new MonHocDaDangKyModel()
                    //        {
                    //            Id = DataFree.monHocDaDangKyModels.Count + 1,
                    //            GiangVien = ChiTietSelect.GiangVien,
                    //            MaHP = HocPhanSelect.MaLHP,
                    //            SoTC = MonHocSelect.SoTC,
                    //            STT = DataFree.monHocDaDangKyModels.Count + 1,
                    //            TenMonHoc = MonHocSelect.TenMonHoc,
                    //            TrangThai = HocPhanSelect.TrangThai,
                    //            IdMonHoc = MonHocSelect.Id
                    //        });
                    //        MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                    //    }
                    //    else if (NhomTHSelect != null&&ChiTietSelect != null)
                    //    {

                    //        sv.IdMonHocs.Add(MonHocSelect.Id);
                    //        sv.MonHocDaDangKyModels.Add(new MonHocDaDangKyModel()
                    //        {
                    //            Id = DataFree.monHocDaDangKyModels.Count + 1,
                    //            GiangVien = ChiTietSelect.GiangVien,
                    //            MaHP = HocPhanSelect.MaLHP,
                    //            SoTC = MonHocSelect.SoTC,
                    //            STT = DataFree.monHocDaDangKyModels.Count + 1,
                    //            TenMonHoc = MonHocSelect.TenMonHoc,
                    //            TrangThai = HocPhanSelect.TrangThai,
                    //            IdMonHoc = MonHocSelect.Id,
                    //            NhomTH = NhomTHSelect
                    //        });
                    //        //DataFree.monHocDaDangKyModels.Add(new MonHocDaDangKyModel()
                    //        //{
                    //        //    Id = DataFree.monHocDaDangKyModels.Count + 1,
                    //        //    GiangVien = ChiTietSelect.GiangVien,
                    //        //    MaHP = HocPhanSelect.MaLHP,
                    //        //    SoTC = MonHocSelect.SoTC,
                    //        //    STT = DataFree.monHocDaDangKyModels.Count + 1,
                    //        //    TenMonHoc = MonHocSelect.TenMonHoc,
                    //        //    TrangThai = HocPhanSelect.TrangThai,
                    //        //    IdMonHoc = MonHocSelect.Id,
                    //        //    NhomTH = NhomTHSelect
                    //        //});
                    //        //var monhoc = DataFree.monHocModels.FirstOrDefault(x => x.Id == MonHocSelect.Id);
                    //        //monhoc.TrangThaiDangKy = 1;
                    //        MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Bạn chưa chọn Nhóm Thực hành", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    //    }
                    //}
                    //LoadListMonHoc();
                });

            }
        }
        public ICommand HyHocPhan
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (MonHocDaDangKySelect != null)
                    {
                        var a = MessageBox.Show($"Bạn muốn hủy học phần {MonHocDaDangKySelect.TenMonHoc}?", "Hủy học phần", MessageBoxButton.YesNo);
                        if (a == MessageBoxResult.Yes)
                        {


                            if (MonHocDaDangKySelect.TrangThai != "Chấp nhận mở lớp")
                            {
                                MonHocDaDangKyList.Remove(MonHocDaDangKySelect);
                                var r = _context.SinhVien_MonHocHocPhans.FirstOrDefault(x => x.Id == MonHocDaDangKySelect.Id);
                                _context.SinhVien_MonHocHocPhans.Remove(r);
                                _context.SaveChanges();
                                MessageBox.Show("Hủy Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                                LoadListMonHoc();
                            }
                            else
                            {
                                MessageBox.Show($"Môn học đang trong trạng thái chấp nhận mở lớp\n Không thể hủy?", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }



                    }

                    //if (MonHocDaDangKySelect != null)
                    //{
                    //    var sv = DataFree.sinhVienModels.FirstOrDefault(x => x.Id == IdSv);
                    //    var a = MessageBox.Show($"Bạn muốn hủy học phần {MonHocDaDangKySelect.TenMonHoc}?", "Hủy học phần", MessageBoxButton.YesNo);
                    //    if (a == MessageBoxResult.Yes)
                    //    {
                    //        if (MonHocDaDangKySelect.TrangThai != "Chấp nhận mở lớp")
                    //        {
                    //            if(sv!=null)
                    //            sv.IdMonHocs.Remove(MonHocSelect.Id);
                    //            sv.MonHocDaDangKyModels.Remove(MonHocDaDangKySelect);


                    //            //var monhoc = DataFree.monHocModels.FirstOrDefault(x => x.Id == MonHocDaDangKySelect.IdMonHoc);
                    //            //monhoc.TrangThaiDangKy = 0;
                    //            //DataFree.monHocDaDangKyModels.Remove(MonHocDaDangKySelect);
                    //            //MonHocDaDangKyList.Remove(MonHocDaDangKySelect);
                    //            MessageBox.Show("Hủy Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show($"Môn học đang trong trạng thái chấp nhận mở lớp\n Không thể hủy?", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    //        }
                    //    }



                    //}


                });

            }
        }

        //if (ChiTietList != null)
        //    ChiTietList.Clear();
        //ObservableCollection<ChiTietModel> chiTiets = new ObservableCollection<ChiTietModel>();
        ////var chitietlophocphan= _context.

        ////chiTiets.Add(new ChiTietModel() { Stt = 1, GiangVien = "Nguyễn Văn A", LichHoc = "LT-Thứ 2 (T6-T8)", NhomTH = "", Phong = "A1.1", ThoiGian = "15/08/2020-15/11/2020" });
        ////chiTiets.Add(new ChiTietModel() { Stt = 2, GiangVien = "Nguyễn Văn A", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "1", Phong = "B11.1", ThoiGian = "15/08/2020-15/11/2020" });
        ////chiTiets.Add(new ChiTietModel() { Stt = 3, GiangVien = "Nguyễn Văn B", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "2", Phong = "B11.2", ThoiGian = "15/08/2020-15/11/2020" });
        //ChiTietList = chiTiets;
        //LoadNhomThucHanh(hocPhanId);
    }
}
