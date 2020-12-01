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
                NameUC = t.Name;
                OnPropertyChanged("MenuSelect");
                ChangeUC();
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
            }
        }

        //private Visibility _thongTinSinhVienUCVisibility;
        //public Visibility ThongTinSinhVienUCVisibility
        //{
        //    get { return _thongTinSinhVienUCVisibility; }
        //    set
        //    {
        //        _thongTinSinhVienUCVisibility = value;
        //        OnPropertyChanged("ThongTinSinhVienUCVisibility");
        //    }
        //}

        //private Visibility _dangKyHocPhanUCVisibility = Visibility.Hidden;
        //public Visibility DangKyHocPhanUCVisibility
        //{
        //    get { return _dangKyHocPhanUCVisibility; }
        //    set
        //    {
        //        _dangKyHocPhanUCVisibility = value;
        //        OnPropertyChanged("DangKyHocPhanUCVisibility");
        //    }
        //}

        //private Visibility _lichHocUCVisibility = Visibility.Hidden;
        //public Visibility LichHocUCVisibility
        //{
        //    get { return _lichHocUCVisibility; }
        //    set
        //    {
        //        _lichHocUCVisibility = value;
        //        OnPropertyChanged("LichHocUCVisibility");
        //    }
        //}


        //private Visibility _chuongTrinhKhungUCVisibility = Visibility.Hidden;
        //public Visibility ChuongTrinhKhungUCVisibility
        //{
        //    get { return _chuongTrinhKhungUCVisibility; }
        //    set
        //    {
        //        _chuongTrinhKhungUCVisibility = value;
        //        OnPropertyChanged("ChuongTrinhKhungUCVisibility");
        //    }
        //}

        #endregion

        #region ICommands
        public ICommand ThongTinTaiKhoanCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {


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

    }

}
