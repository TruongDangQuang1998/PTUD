using DangKyHocPhan.Models;
using DangKyHocPhan.Views;
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
    public class UCModelMoLopHocPhan: BaseViewModel
    {
        public UCModelMoLopHocPhan()
        {

            LoadHocKi();
        }

        #region ICommands
        //MoThemLopCommand
        public ICommand MoThemLopCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    var ucThemMonHocDKHP = new UCThemMonHocDKHP();
                    ucThemMonHocDKHP.ShowDialog();

                    //var b = new MainViewModel();
                    //var c = new MainWindow();
                    //c.
                    //b.UCShow = "ThemMonHocDKHP";
                    //var a = MainWindow.GetWindow(obj);
                    //MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                });

            }
        }
        #region properties
        private ObservableCollection<ThuModel> _thuList;
        public ObservableCollection<ThuModel> ThuList
        {
            get { return _thuList; }
            set
            {
                _thuList = value;
                OnPropertyChanged("ThuList");
            }
        }
        private ThuModel _thuSelect;
        public ThuModel ThuSelect
        {
            get { return _thuSelect; }
            set
            {
                _thuSelect = value;
                OnPropertyChanged("ThuSelect");
                //Load  List Mon Hoc
                LoadListThu();
            }
        }

        private ObservableCollection<TietModel> _tietList;
        public ObservableCollection<TietModel> TietList
        {
            get { return _tietList; }
            set
            {
                _tietList = value;
                OnPropertyChanged("TietList");
            }
        }
        private TietModel _tietSelect;
        public TietModel TietSelect
        {
            get { return _tietSelect; }
            set
            {
                _tietSelect = value;
                OnPropertyChanged("TietSelect");
                //Load  List Mon Hoc
                LoadListTiet();
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

        private ObservableCollection<LopModel> _lopList;
        public ObservableCollection<LopModel> LopList
        {
            get { return _lopList; }
            set
            {
                _lopList = value;
                OnPropertyChanged("LopList");
            }
        }

        private LopModel _lopSelect;
        public LopModel LopSelect
        {
            get { return _lopSelect; }
            set
            {
                _lopSelect = value;
                OnPropertyChanged("LopSelect");
                LoadListLop();
            }
        }

        private ObservableCollection<GiangVienModel> _giangvienList;
        public ObservableCollection<GiangVienModel> GiangVienList
        {
            get { return _giangvienList; }
            set
            {
                _giangvienList = value;
                OnPropertyChanged("GiangVienList");
            }
        }

        private GiangVienModel _giangvienSelect;
        public GiangVienModel GiangVienSelect
        {
            get { return _giangvienSelect; }
            set
            {
                _giangvienSelect = value;
                OnPropertyChanged("GiangVienSelect");
                LoadListGiangVien();
            }
        }
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

        #endregion
        public void LoadHocKi()
        {
            HocKiList = DataFree.hocKiModels;
            HocKiSelect = HocKiList.FirstOrDefault();

            NamHocList = DataFree.namHocModels;
            NamHocSelect = NamHocList.FirstOrDefault();

            //var hockis = _context.HocKys;
            //var namhocs = _context.NamHocs;
            //var listHocKi = new ObservableCollection<HocKiModel>();
            //var listNamHoc = new ObservableCollection<NamHocModel>();
            //foreach (var item in hockis)
            //{
            //    listHocKi.Add(new HocKiModel() { Id = item.MaHocKy, Name = item.TenHocKy });
            //}
            //foreach (var item in namhocs)
            //{
            //    listNamHoc.Add(new NamHocModel() { Id = item.MaNamHoc, Name = item.TenNamHoc });
            //}
            //HocKiList = listHocKi;
            //HocKiSelect = listHocKi.FirstOrDefault();
            //NamHocList = listNamHoc;
            //NamHocSelect = listNamHoc.FirstOrDefault();
        }

        public void LoadListMonHoc()
        {
            //MonHocList = new ObservableCollection<MonHocModel>();
            //if (HocKiSelect != null && NamHocSelect != null)
            //{
            //    if (HocKiSelect.Id == 1 && NamHocSelect.Id == 1)
            //        foreach (var item in DataFree.monHocModels)
            //        {
            //            if (MonHocList != null)
            //                MonHocList.Add(item);
            //        }
            //}
            MonHocList = DataFree.monHocModels;
            MonHocSelect = MonHocList.FirstOrDefault();

           
        }

        public void LoadListHocPhan()
        {
            HocPhanList = new ObservableCollection<HocPhanModel>();
            if (HocPhanList != null)
                HocPhanList.Clear();
            if (MonHocSelect != null)
            {
                foreach (var item in DataFree.hocPhanModels)
                {
                    if (MonHocSelect.Id == item.MaMonHP)
                        HocPhanList.Add(item);
                }
            }


            //if (HocPhanList != null)
            //    HocPhanList.Clear();

            //ObservableCollection<HocPhanModel> hocPhans = new ObservableCollection<HocPhanModel>();
            //var lophocphan = _context.LopHocPhans.Where(x => x.MonHocHocPhan.Id == MonHocSelect.Id);
            //foreach (var item in lophocphan)
            //{
            //    hocPhans.Add(new HocPhanModel()
            //    {
            //        Stt = hocPhans.Count + 1,
            //        DaDangKy = item.SiSoDaDangKy.ToString(),
            //        Lop = item.MaLopHocPhan.ToString(),
            //        MaLHP = item.MaLopHocPhan.ToString(),
            //        Id = item.Id,
            //        SiSoToiDa = item.SiSoToiDa.ToString(),
            //        TenLopHocPhan = item.TenLopHocPhan,
            //        TrangThai = item.TrangThai
            //    }) ;
            //}
            //HocPhanList = hocPhans;
        }

        public void LoadListThu()
        {

            ThuList = DataFree.thuModels;
            ThuSelect = ThuList.FirstOrDefault();
        }

        public void LoadListTiet()
        {

            TietList = DataFree.tietModels;
            TietSelect = TietList.FirstOrDefault();
        }

        public void LoadListLop()
        {

            LopList = DataFree.lopModels;
            LopSelect = LopList.FirstOrDefault();
        }
        public void LoadListGiangVien()
        {

            GiangVienList = DataFree.giangvienModels;
            GiangVienSelect = GiangVienList.FirstOrDefault();
        }
        public void LoadChiTietHocPhan()
        {
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
        #endregion
    }
}
