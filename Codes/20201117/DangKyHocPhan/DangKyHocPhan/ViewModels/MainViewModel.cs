using DangKyHocPhan.ConnectDB;
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
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }


        
        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            //LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            //{
            //    Isloaded = true;
            //LoginWD loginWindow = new LoginWD();
            //loginWindow.ShowDialog();
            //}
            //  );
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
            }


            VisibilityLoginMain = "Login";
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
        private string _username;
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


        #region ICommand
        public ICommand ClickLogin
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (true)
                    {
                        VisibilityLoginMain = "Main";
                    }
                    //if (Username == "giangvien")
                    //{
                    //    //var mainwindown = new MainWindow();
                    //    //mainwindown.ShowDialog();
                    //}
                    //else
                    //{

                    //}

                });

            }
        }
        #endregion
        #endregion
    }

}
