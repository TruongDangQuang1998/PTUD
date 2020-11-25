using DangKyHocPhan.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.ViewModels
{
    public class ChuongTrinhKhungUCModel:BaseViewModel
    {
        public ChuongTrinhKhungUCModel()
        {
            LoadData();
        }
        #region Properties
        private ObservableCollection<ChuongTrinhKhungModel> _hocKi1;
        public ObservableCollection<ChuongTrinhKhungModel> HocKi1
        {
            get { return _hocKi1; }
            set
            {
                _hocKi1 = value;
                OnPropertyChanged("HocKi1");
            }
        }
        private ObservableCollection<ChuongTrinhKhungModel> _hocKi2;
        public ObservableCollection<ChuongTrinhKhungModel> HocKi2
        {
            get { return _hocKi2; }
            set
            {
                _hocKi2 = value;
                OnPropertyChanged("HocKi2");
            }
        }
        private ObservableCollection<ChuongTrinhKhungModel> _hocKi3;
        public ObservableCollection<ChuongTrinhKhungModel> HocKi3
        {
            get { return _hocKi3; }
            set
            {
                _hocKi3 = value;
                OnPropertyChanged("HocKi3");
            }
        }
        private ObservableCollection<ChuongTrinhKhungModel> _hocKi4;
        public ObservableCollection<ChuongTrinhKhungModel> HocKi4
        {
            get { return _hocKi4; }
            set
            {
                _hocKi4 = value;
                OnPropertyChanged("HocKi4");
            }
        }
        private ObservableCollection<ChuongTrinhKhungModel> _hocKi5;
        public ObservableCollection<ChuongTrinhKhungModel> HocKi5
        {
            get { return _hocKi5; }
            set
            {
                _hocKi5 = value;
                OnPropertyChanged("HocKi5");
            }
        }
        private ObservableCollection<ChuongTrinhKhungModel> _hocKi6;
        public ObservableCollection<ChuongTrinhKhungModel> HocKi6
        {
            get { return _hocKi6; }
            set
            {
                _hocKi6 = value;
                OnPropertyChanged("HocKi6");
            }
        }
        private ObservableCollection<ChuongTrinhKhungModel> _hocKi7;
        public ObservableCollection<ChuongTrinhKhungModel> HocKi7
        {
            get { return _hocKi7; }
            set
            {
                _hocKi7 = value;
                OnPropertyChanged("HocKi7");
            }
        }
        private ObservableCollection<ChuongTrinhKhungModel> _hocKi8;
        public ObservableCollection<ChuongTrinhKhungModel> HocKi8
        {
            get { return _hocKi8; }
            set
            {
                _hocKi8 = value;
                OnPropertyChanged("HocKi8");
            }
        }
        #endregion

        #region Methods
        public void LoadData()
        {
            var hocki = new ObservableCollection<ChuongTrinhKhungModel>();
            hocki.Add(new ChuongTrinhKhungModel() { Stt = 1, MaMonHoc = "123456789", TenMonHoc = "Môn học ABC", SoTC = 4, SoTCLT = 3, SoTCTH = 1, TienQuyet = "123456543" });
            hocki.Add(new ChuongTrinhKhungModel() { Stt = 2, MaMonHoc = "123456789", TenMonHoc = "Môn học ABC", SoTC = 4, SoTCLT = 3, SoTCTH = 1, TienQuyet = "123456543" });
            hocki.Add(new ChuongTrinhKhungModel() { Stt = 3, MaMonHoc = "123456789", TenMonHoc = "Môn học ABC", SoTC = 4, SoTCLT = 3, SoTCTH = 1, TienQuyet = "123456543" });
            hocki.Add(new ChuongTrinhKhungModel() { Stt = 4, MaMonHoc = "123456789", TenMonHoc = "Môn học ABC", SoTC = 4, SoTCLT = 3, SoTCTH = 1, TienQuyet = "123456543" });
            hocki.Add(new ChuongTrinhKhungModel() { Stt = 5, MaMonHoc = "123456789", TenMonHoc = "Môn học ABC", SoTC = 4, SoTCLT = 3, SoTCTH = 1, TienQuyet = "123456543" });
            hocki.Add(new ChuongTrinhKhungModel() { Stt = 6, MaMonHoc = "123456789", TenMonHoc = "Môn học ABC", SoTC = 4, SoTCLT = 3, SoTCTH = 1, TienQuyet = "123456543" });
            hocki.Add(new ChuongTrinhKhungModel() { Stt = 7, MaMonHoc = "123456789", TenMonHoc = "Môn học ABC", SoTC = 4, SoTCLT = 3, SoTCTH = 1, TienQuyet = "123456543" });
            HocKi1 = hocki;
            HocKi2 = hocki;
            HocKi3 = hocki;
            HocKi4 = hocki;
            HocKi5 = hocki;
            HocKi6 = hocki;
            HocKi7 = hocki;
            HocKi8 = hocki;
        }
        #endregion

    }
}
