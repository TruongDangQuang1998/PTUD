using DangKyHocPhan.ConnectDB;
using DangKyHocPhan.Models;
using DangKyHocPhan.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DangKyHocPhan.ViewModels
{
    public static class test
    {
        public static string User { get; set; }
    }
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public Context _context;

        private IDataBaseService _dataBaseService;
        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            //DataFree.CreateDatas();
            
            _dataBaseService = new DataBaseService();
            _dataBaseService.CreateIfNotExistsDB();
            //LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            //{
            //    Isloaded = true;
            //    LoginWD loginWindow = new LoginWD();
            //    loginWindow.ShowDialog();
            //}
            //  );
            VisibilityLoginMain = "Login";
            _context = new Context();
        }

        #region Properties
        private object _menuSelect;
        public object MenuSelect
        {
            get { return _menuSelect; }
            set
            {
                //var menuSelect = value.  ;
                _menuSelect = value;
                var t = _menuSelect as ListViewItem;
                if(t!=null)
                NameUC = t.Name;
                OnPropertyChanged("MenuSelect");
                //ChangeUC();
            }
        }
        private string _nameUC;
        public string NameUC
        {
            get { return _nameUC; }
            set
            {
                _nameUC = value;
                OnPropertyChanged("NameUC");
                UCShow = NameUC;
                
                //switch (NameUC)
                //{
                //    case "ThongTinTaiKhoan":
                //        ThongTinSinhVienUCVisibility = Visibility.Visible;


                //        MoLopHocPhanUCVisibility = Visibility.Collapsed;
                //        DangKyHocPhanUCVisibility = Visibility.Collapsed;
                //        LichHocUCVisibility = Visibility.Collapsed;
                //        QuanLyDuLieuUCVisibility = Visibility.Collapsed;
                //        break;
                //    case "MoLopHocPhan":
                //        MoLopHocPhanUCVisibility = Visibility.Visible;

                //        ThongTinSinhVienUCVisibility = Visibility.Collapsed;
                //        DangKyHocPhanUCVisibility = Visibility.Collapsed;
                //        LichHocUCVisibility = Visibility.Collapsed;
                //        QuanLyDuLieuUCVisibility = Visibility.Collapsed;
                //        break;
                //    case "DangKyHocPhan":
                //        DangKyHocPhanUCVisibility = Visibility.Visible;

                //        ThongTinSinhVienUCVisibility = Visibility.Collapsed;
                //        MoLopHocPhanUCVisibility = Visibility.Collapsed;
                //        LichHocUCVisibility = Visibility.Collapsed;
                //        QuanLyDuLieuUCVisibility = Visibility.Collapsed;
                //        break;
                //    case "LichHoc":
                //        LichHocUCVisibility = Visibility.Visible;

                //        ThongTinSinhVienUCVisibility = Visibility.Collapsed;
                //        MoLopHocPhanUCVisibility = Visibility.Collapsed;
                //        DangKyHocPhanUCVisibility = Visibility.Collapsed;
                //        QuanLyDuLieuUCVisibility = Visibility.Collapsed;
                //        break;
                //    case "QuanLyDuLieu":
                //        QuanLyDuLieuUCVisibility = Visibility.Visible;

                //        ThongTinSinhVienUCVisibility = Visibility.Collapsed;
                //        MoLopHocPhanUCVisibility = Visibility.Collapsed;
                //        DangKyHocPhanUCVisibility = Visibility.Collapsed;
                //        LichHocUCVisibility = Visibility.Collapsed;
                //        break;
                //}
            }
        }
        private  string _ucShow;
        public  string UCShow
        {
            get { return _ucShow; }
            set
            {
                _ucShow = value;
                OnPropertyChanged("UCShow");
                if (UCShow == "DangXuat")
                {
                    var  dialogResult =MessageBox.Show("Bạn Muốn Đăng Xuất", "Đăng Xuất", MessageBoxButton.YesNo);
                    if(dialogResult == MessageBoxResult.Yes)
                    {
                        VisibilityLoginMain = "Login";
                        Password = "";
                        Username = "";
                    }
                }
            }
        }

        private string _visibilityLoginMain;
        public string VisibilityLoginMain
        {
            get { return _visibilityLoginMain; }
            set
            {
                _visibilityLoginMain = value;
                OnPropertyChanged("VisibilityLoginMain");
            }
        }
        private string _visibilityExpander;
        public string VisibilityExpander
        {
            get { return _visibilityExpander; }
            set
            {
                _visibilityExpander = value;
                OnPropertyChanged("VisibilityExpander");
            }
        }


        private Visibility _thongTinSinhVienUCVisibility = Visibility.Collapsed;
        public Visibility ThongTinSinhVienUCVisibility
        {
            get { return _thongTinSinhVienUCVisibility; }
            set
            {
                _thongTinSinhVienUCVisibility = value;
                OnPropertyChanged("ThongTinSinhVienUCVisibility");
            }
        }
        private Visibility _moLopHocPhanUCVisibility = Visibility.Collapsed;
        public Visibility MoLopHocPhanUCVisibility
        {
            get { return _moLopHocPhanUCVisibility; }
            set
            {
                _moLopHocPhanUCVisibility = value;
                OnPropertyChanged("MoLopHocPhanUCVisibility");
            }
        }

        private Visibility _dangKyHocPhanUCVisibility = Visibility.Hidden;
        public Visibility DangKyHocPhanUCVisibility
        {
            get { return _dangKyHocPhanUCVisibility; }
            set
            {
                _dangKyHocPhanUCVisibility = value;
                OnPropertyChanged("DangKyHocPhanUCVisibility");
            }
        } 

        private Visibility _lichHocUCVisibility = Visibility.Collapsed;
        public Visibility LichHocUCVisibility
        {
            get { return _lichHocUCVisibility; }
            set
            {
                _lichHocUCVisibility = value;
                OnPropertyChanged("LichHocUCVisibility");
            }
        }


        private Visibility _chuongTrinhKhungUCVisibility = Visibility.Collapsed;
        public Visibility ChuongTrinhKhungUCVisibility
        {
            get { return _chuongTrinhKhungUCVisibility; }
            set
            {
                _chuongTrinhKhungUCVisibility = value;
                OnPropertyChanged("ChuongTrinhKhungUCVisibility");
            }
        }
        private Visibility _quanLyDuLieuUCVisibility = Visibility.Collapsed;
        public Visibility QuanLyDuLieuUCVisibility
        {
            get { return _quanLyDuLieuUCVisibility; }
            set
            {
                _quanLyDuLieuUCVisibility = value;
                OnPropertyChanged("QuanLyDuLieuUCVisibility");
            }
        }

        #endregion

        #region ICommands
        public ICommand ThongTinTaiKhoanCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {

                    UCShow = NameUC;
                });

            }
        }
        public ICommand MoLopHocPhanCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {

                    UCShow = "MoLopHocPhan";
                });

            }
        }
        public ICommand DangKyHocPhanCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {

                    UCShow = "DangKyHocPhan";
                });

            }
        }
        public ICommand XemLichHocCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {

                    UCShow = "XemLichDay";
                });

            }
        }
        public ICommand ChenLopHocPhanCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {

                    UCShow = "ChenLopHocPhan";
                });

            }
        }
        #endregion

        #region Methods
        public void ChangeUC()
        {
            switch (NameUC)
            {
                case "ThongTinTaiKhoan":

                    break;
                case "DangKyHocPhan":
                    break;
                case "LichHoc":
                    break;
                case "ChuongTrinhKhung":
                    break;
                case "DangXuat":
                    break;
                    //case "ThongTinTaiKhoan":
                    //    break;
                    //case "ThongTinTaiKhoan":
                    //    break;
                    //case "ThongTinTaiKhoan":
                    //    break;
                    //case "ThongTinTaiKhoan":
                    //    break;
                    //case "ThongTinTaiKhoan":
                    //    break;

            }
        }
        #endregion



        #region Login
        private string _username = "quanly";
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }


        public ICommand ClickLogin
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    var tk = _context.TaiKhoans;
                    var user = tk.FirstOrDefault(x => x.TenTaiKhoan == Username);
                    //PhongDaoTao
                    //SinhVien
                    //GiangVien
                    //Admin
                    if (user != null)
                    {
                        test.User = user.TenTaiKhoan;
                        if (user.TenQuyen == "SinhVien")
                        {
                            VisibilityExpander = "SinhVien";
                            VisibilityLoginMain = "Main";
                        }
                        else if (user.TenQuyen == "GiangVien")
                        {
                            VisibilityExpander = "GiangVien";
                            VisibilityLoginMain = "Main";
                        }
                        else if (user.TenQuyen == "PhongDaoTao")
                        {
                            VisibilityExpander = "PhongDaoTao";
                            VisibilityLoginMain = "Main";
                        }
                        else if (user.TenQuyen == "Admin")
                        {
                            VisibilityExpander = "QuanLy";
                            VisibilityLoginMain = "Main";
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                });

            }
        }
        #endregion       
    }
    public static class DataFree
    {
        
        //#region Datas
        //public static ObservableCollection<HocKiModel> hocKiModels = new ObservableCollection<HocKiModel>();
        //public static ObservableCollection<NamHocModel> namHocModels = new ObservableCollection<NamHocModel>();
        //public static ObservableCollection<MonHocModel> monHocModels = new ObservableCollection<MonHocModel>();
        //public static ObservableCollection<HocPhanModel> hocPhanModels = new ObservableCollection<HocPhanModel>();
        //public static ObservableCollection<ChiTietModel> chiTietModels = new ObservableCollection<ChiTietModel>();
        //public static ObservableCollection<SinhVienModel> sinhVienModels = new ObservableCollection<SinhVienModel>();
        //public static ObservableCollection<MonHocDaDangKyModel> monHocDaDangKyModels = new ObservableCollection<MonHocDaDangKyModel>();
        //public static ObservableCollection<LopModel> lopModels = new ObservableCollection<LopModel>();
        //public static ObservableCollection<GiangVienModel> giangvienModels = new ObservableCollection<GiangVienModel>();
        //public static ObservableCollection<ThuModel> thuModels = new ObservableCollection<ThuModel>();
        //public static ObservableCollection<TietModel> tietModels = new ObservableCollection<TietModel>();
        //public static ObservableCollection<PhongModel> phongModels = new ObservableCollection<PhongModel>();

        //public static void CreateDatas()
        //{
        //    hocKiModels.Add(new HocKiModel() { Id = 1, Name = "Học kì 1" });
        //    hocKiModels.Add(new HocKiModel() { Id = 2, Name = "Học kì 2" });
        //    hocKiModels.Add(new HocKiModel() { Id = 3, Name = "Học kì 3" });

        //    namHocModels.Add(new NamHocModel() { Id = 1, Name = "2020-2021" });
        //    namHocModels.Add(new NamHocModel() { Id = 2, Name = "2019-2020" });
        //    namHocModels.Add(new NamHocModel() { Id = 3, Name = "2018-2019" });
        //    namHocModels.Add(new NamHocModel() { Id = 4, Name = "2017-2018" });



        //    monHocModels.Add(new MonHocModel() { TrangThaiDangKy=0, Id = 1, Stt = 1, MaMH = "42030000505", TenMonHoc = "Vật lí A1", SoTC = 2 });
        //    monHocModels.Add(new MonHocModel() { TrangThaiDangKy=0,Id = 2, Stt = 2, MaMH = "42030000506", TenMonHoc = "Logic học", SoTC = 2 });
        //    monHocModels.Add(new MonHocModel() { TrangThaiDangKy=0,Id = 3, Stt = 3, MaMH = "42030000507", TenMonHoc = "Tâm lý học đại cương", SoTC = 2 });
        //    monHocModels.Add(new MonHocModel() { TrangThaiDangKy=0,Id = 4, Stt = 4, MaMH = "42030000508", TenMonHoc = "Quản lý dự án CNTT", SoTC = 3 });
        //    monHocModels.Add(new MonHocModel() { TrangThaiDangKy=0,Id = 5, Stt = 5, MaMH = "42030000509", TenMonHoc = "Xây dựn phần mềm", SoTC = 3 });
        //    monHocModels.Add(new MonHocModel() { TrangThaiDangKy=0,Id = 6, Stt = 6, MaMH = "42030000500", TenMonHoc = "Lập trình Phân tán với công nghệ Java", SoTC = 3 });
        //    monHocModels.Add(new MonHocModel() { TrangThaiDangKy=0,Id = 7, Stt = 7, MaMH = "42030000511", TenMonHoc = "Lập trình Phân tán với công nghệ .NET", SoTC = 3 });
        //    monHocModels.Add(new MonHocModel() { TrangThaiDangKy=0,Id = 8, Stt = 8, MaMH = "42030000512", TenMonHoc = "Kiếm trúc hướng dịch vụ và Điện toán đám mây", SoTC = 4 });
        //    monHocModels.Add(new MonHocModel() { TrangThaiDangKy = 0, Id = 9, Stt = 9, MaMH = "42030000513", TenMonHoc = "Công nghệ mới trong phát triển ứng dụng CNTT", SoTC = 3 });


        //    hocPhanModels.Add(new HocPhanModel()
        //    {
        //        Id = 1,
        //        Stt = 1,
        //        MaLHP = "4203000050501",
        //        TenLopHocPhan = "Vật lý A1",
        //        Lop = "DHKTPM13B",
        //        SiSoToiDa = "80",
        //        DaDangKy = "50",
        //        TrangThai = "Chấp nhận mở lớp",
        //        MaMonHP = 1
        //    });
        //    hocPhanModels.Add(new HocPhanModel()
        //    {
        //        Id = 2,
        //        Stt = 2,
        //        MaLHP = "4203000050502",
        //        TenLopHocPhan = "Vật lý A1",
        //        Lop = "DHKTPM13A",
        //        SiSoToiDa = "80",
        //        DaDangKy = "35",
        //        TrangThai = "Chờ sinh viên đăng ký",
        //        MaMonHP = 1
        //    });
        //    hocPhanModels.Add(new HocPhanModel()
        //    {
        //        Id = 3,
        //        Stt = 4,
        //        MaLHP = "4203000050602",
        //        TenLopHocPhan = "Logic học",
        //        Lop = "DHKTPM13B",
        //        SiSoToiDa = "80",
        //        DaDangKy = "20",
        //        TrangThai = "Chờ sinh viên đăng ký",
        //        MaMonHP = 2
        //    });
        //    hocPhanModels.Add(new HocPhanModel()
        //    {
        //        Id = 4,
        //        Stt = 4,
        //        MaLHP = "4203000050602",
        //        TenLopHocPhan = "Logic học",
        //        Lop = "DHKTPM13A",
        //        SiSoToiDa = "80",
        //        DaDangKy = "60",
        //        TrangThai = "Chấp nhận mở lớp",
        //        MaMonHP = 2
        //    });

        //    hocPhanModels.Add(new HocPhanModel()
        //    {
        //        Id = 5,
        //        Stt = 5,
        //        MaLHP = "4203000050701",
        //        TenLopHocPhan = "Quản lý dự án CNTT",
        //        Lop = "DHKTPM13A",
        //        SiSoToiDa = "80",
        //        DaDangKy = "40",
        //        TrangThai = "Chấp nhận mở lớp",
        //        MaMonHP = 3
        //    });
        //    hocPhanModels.Add(new HocPhanModel()
        //    {
        //        Id = 6,
        //        Stt = 6,
        //        MaLHP = "4203000050702",
        //        TenLopHocPhan = "Quản lý dự án CNTT",
        //        Lop = "DHKTPM13A",
        //        SiSoToiDa = "80",
        //        DaDangKy = "15",
        //        TrangThai = "Chờ sinh viên đăng ký",
        //        MaMonHP = 3
        //    });

        //    hocPhanModels.Add(new HocPhanModel()
        //    {
        //        Id = 7,
        //        Stt = 7,
        //        MaLHP = "4203000051301",
        //        TenLopHocPhan = "Công nghệ mới trong phát triển ứng dụng CNTT",
        //        Lop = "DHKTPM13A",
        //        SiSoToiDa = "80",
        //        DaDangKy = "15",
        //        TrangThai = "Chờ sinh viên đăng ký",
        //        MaMonHP = 9
        //    });



        //    chiTietModels.Add(new ChiTietModel()
        //    {
        //        Id = 1,
        //        Stt = 1,
        //        GiangVien = "Nguyễn Văn A",
        //        LichHoc = "LT-Thứ 2 (T6-T8)",
        //        NhomTH = "",
        //        Phong = "A1.1",
        //        ThoiGian = "01/01/2021-01/05/2021",
        //        MaLopHocPhan = 1
        //    });
        //    chiTietModels.Add(new ChiTietModel()
        //    {
        //        Id = 2,
        //        Stt = 2,
        //        GiangVien = "Nguyễn Văn B",
        //        LichHoc = "LT-Thứ 2 (T6-T8)",
        //        NhomTH = "",
        //        Phong = "A1.1",
        //        ThoiGian = "01/01/2021-01/05/2021",
        //        MaLopHocPhan = 2
        //    });
        //    chiTietModels.Add(new ChiTietModel()
        //    {
        //        Id = 3,
        //        Stt = 3,
        //        GiangVien = "Nguyễn Văn B",
        //        LichHoc = "LT-Thứ 2 (T6-T8)",
        //        NhomTH = "",
        //        Phong = "A1.1",
        //        ThoiGian = "01/01/2021-01/05/2021",
        //        MaLopHocPhan = 3
        //    });
        //    chiTietModels.Add(new ChiTietModel()
        //    {
        //        Id = 4,
        //        Stt = 4,
        //        GiangVien = "Nguyễn Thị C",
        //        LichHoc = "LT-Thứ 2 (T6-T8)",
        //        NhomTH = "",
        //        Phong = "A1.1",
        //        ThoiGian = "01/01/2021-01/05/2021",
        //        MaLopHocPhan = 4
        //    });
        //    chiTietModels.Add(new ChiTietModel()
        //    {
        //        Id = 5,
        //        Stt = 5,
        //        GiangVien = "Nguyễn Thị C",
        //        LichHoc = "LT-Thứ 2 (T6-T8)",
        //        NhomTH = "",
        //        Phong = "A1.1",
        //        ThoiGian = "01/01/2021-01/05/2021",
        //        MaLopHocPhan = 5
        //    });
        //    chiTietModels.Add(new ChiTietModel()
        //    {
        //        Id = 6,
        //        Stt = 6,
        //        GiangVien = "Nguyễn Thị C",
        //        LichHoc = "LT-Thứ 2 (T6-T8)",
        //        NhomTH = "",
        //        Phong = "A1.1",
        //        ThoiGian = "01/01/2021-01/05/2021",
        //        MaLopHocPhan = 6
        //    });

        //    chiTietModels.Add(new ChiTietModel()
        //    {
        //        Id = 7,
        //        Stt = 7,
        //        GiangVien = "Thầy Lý Thuyết",
        //        LichHoc = "LT-Thứ 2 (T6-T8)",
        //        NhomTH = "",
        //        Phong = "A1.1",
        //        ThoiGian = "01/01/2021-01/05/2021",
        //        MaLopHocPhan = 7
        //    });
        //    chiTietModels.Add(new ChiTietModel()
        //    {
        //        Id = 8,
        //        Stt = 8,
        //        GiangVien = "Thầy Thực Hành 1",
        //        LichHoc = "TH-Thứ 2 (T9-T11)",
        //        NhomTH = "1",
        //        Phong = "B1.11",
        //        ThoiGian = "01/01/2021-01/05/2021",
        //        MaLopHocPhan = 7
        //    });
        //    chiTietModels.Add(new ChiTietModel()
        //    {
        //        Id = 9,
        //        Stt = 9,
        //        GiangVien = "Thầy Thực Hành 2",
        //        LichHoc = "TH-Thứ 3 (T1-T3)",
        //        NhomTH = "2",
        //        Phong = "H5.02",
        //        ThoiGian = "01/01/2021-01/05/2021",
        //        MaLopHocPhan = 7
        //    });


        //    sinhVienModels.Add(new SinhVienModel() { Id = 1, MSSV = "11111111", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn A", Khoa="Công nghệ Thông tin", Lop="DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 2, MSSV = "11111112", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn B", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 3, MSSV = "11111113", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn C", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 4, MSSV = "11111114", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn D", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 5, MSSV = "11111115", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn R", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 6, MSSV = "11111116", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn F", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 7, MSSV = "11111117", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn G", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 8, MSSV = "11111118", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn H", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 9, MSSV = "11111119", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn J", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 10, MSSV = "11111120", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn K", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 11, MSSV = "11111121", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn L", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });
        //    sinhVienModels.Add(new SinhVienModel() { Id = 12, MSSV = "11111122", ChuyenNganh = "Kỹ thuật Phần mềm", Name = "Nguyễn Văn M", Khoa = "Công nghệ Thông tin", Lop = "DHKTPM13B" });

        //}




        //#endregion
    }
}
