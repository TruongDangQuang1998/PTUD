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
    public class UCModelThemMonHocDKHP : BaseViewModel
    {
        public Context _context;
        public UCModelThemMonHocDKHP()
        {
            _context = new Context();
            LoadData();
        }

        #region Properties
        private ThuModel _thuLTSelect;
        public ThuModel ThuLTSelect
        {
            get { return _thuLTSelect; }
            set
            {
                _thuLTSelect = value;
                OnPropertyChanged("ThuLTSelect");
            }
        }
        private ObservableCollection<ThuModel> _thuLTList;
        public ObservableCollection<ThuModel> ThuLTList
        {
            get { return _thuLTList; }
            set
            {
                _thuLTList = value;
                OnPropertyChanged("ThuLTList");
            }
        }

        private TietModel _tietLTSelect;
        public TietModel TietLTSelect
        {
            get { return _tietLTSelect; }
            set
            {
                _tietLTSelect = value;
                OnPropertyChanged("TietLTSelect");
            }
        }
        private ObservableCollection<ThuModel> _tietLTList;
        public ObservableCollection<ThuModel> TietLTList
        {
            get { return _tietLTList; }
            set
            {
                _tietLTList = value;
                OnPropertyChanged("TietLTList");
            }
        }

        private TietModel _phongLTSelect;
        public TietModel PhongLTSelect
        {
            get { return _phongLTSelect; }
            set
            {
                _phongLTSelect = value;
                OnPropertyChanged("PhongLTSelect");
            }
        }
        private ObservableCollection<ThuModel> _phongLTList;
        public ObservableCollection<ThuModel> PhongLTList
        {
            get { return _phongLTList; }
            set
            {
                _phongLTList = value;
                OnPropertyChanged("PhongLTList");
            }
        }





        private ThuModel _thuTH1Select;
        public ThuModel ThuTH1Select
        {
            get { return _thuTH1Select; }
            set
            {
                _thuTH1Select = value;
                OnPropertyChanged("ThuTH1Select");
            }
        }
        private ObservableCollection<ThuModel> _thuTH1List;
        public ObservableCollection<ThuModel> ThuTH1List
        {
            get { return _thuTH1List; }
            set
            {
                _thuTH1List = value;
                OnPropertyChanged("ThuTH1List");
            }
        }

        private TietModel _tietTH1Select;
        public TietModel TietTH1Select
        {
            get { return _tietTH1Select; }
            set
            {
                _tietTH1Select = value;
                OnPropertyChanged("TietTH1Select");
            }
        }
        private ObservableCollection<ThuModel> _tietTH1List;
        public ObservableCollection<ThuModel> TietTH1List
        {
            get { return _tietTH1List; }
            set
            {
                _tietTH1List = value;
                OnPropertyChanged("TietTH1List");
            }
        }

        private TietModel _phongTH1Select;
        public TietModel PhongTH1Select
        {
            get { return _phongTH1Select; }
            set
            {
                _phongTH1Select = value;
                OnPropertyChanged("PhongTH1Select");
            }
        }
        private ObservableCollection<ThuModel> _phongTH1List;
        public ObservableCollection<ThuModel> PhongTH1List
        {
            get { return _phongTH1List; }
            set
            {
                _phongTH1List = value;
                OnPropertyChanged("PhongTH1List");
            }
        }
        private ThuModel _thuTH2Select;
        public ThuModel ThuTH2Select
        {
            get { return _thuTH2Select; }
            set
            {
                _thuTH2Select = value;
                OnPropertyChanged("ThuTH2Select");
            }
        }
        private ObservableCollection<ThuModel> _thuTH2List;
        public ObservableCollection<ThuModel> ThuTH2List
        {
            get { return _thuTH2List; }
            set
            {
                _thuTH2List = value;
                OnPropertyChanged("ThuTH2List");
            }
        }

        private TietModel _tietTH2Select;
        public TietModel TietTH2Select
        {
            get { return _tietTH2Select; }
            set
            {
                _tietTH2Select = value;
                OnPropertyChanged("TietTH2Select");
            }
        }
        private ObservableCollection<ThuModel> _tietTH2List;
        public ObservableCollection<ThuModel> TietTH2List
        {
            get { return _tietTH2List; }
            set
            {
                _tietTH2List = value;
                OnPropertyChanged("TietTH2List");
            }
        }

        private TietModel _phongTH2Select;
        public TietModel PhongTH2Select
        {
            get { return _phongTH2Select; }
            set
            {
                _phongTH2Select = value;
                OnPropertyChanged("PhongTH2Select");
            }
        }
        private ObservableCollection<ThuModel> _phongTH2List;
        public ObservableCollection<ThuModel> PhongTH2List
        {
            get { return _phongTH2List; }
            set
            {
                _phongTH2List = value;
                OnPropertyChanged("PhongTH2List");
            }
        }




        private ThuModel _thuTH3Select;
        public ThuModel ThuTH3Select
        {
            get { return _thuTH3Select; }
            set
            {
                _thuTH3Select = value;
                OnPropertyChanged("ThuTH3Select");
            }
        }
        private ObservableCollection<ThuModel> _thuTH3List;
        public ObservableCollection<ThuModel> ThuTH3List
        {
            get { return _thuTH3List; }
            set
            {
                _thuTH3List = value;
                OnPropertyChanged("ThuTH3List");
            }
        }

        private TietModel _tietTH3Select;
        public TietModel TietTH3Select
        {
            get { return _tietTH3Select; }
            set
            {
                _tietTH3Select = value;
                OnPropertyChanged("TietTH3Select");
            }
        }
        private ObservableCollection<ThuModel> _tietTH3List;
        public ObservableCollection<ThuModel> TietTH3List
        {
            get { return _tietTH3List; }
            set
            {
                _tietTH3List = value;
                OnPropertyChanged("TietTH3List");
            }
        }

        private TietModel _phongTH3Select;
        public TietModel PhongTH3Select
        {
            get { return _phongTH3Select; }
            set
            {
                _phongTH3Select = value;
                OnPropertyChanged("PhongTH3Select");
            }
        }
        private ObservableCollection<ThuModel> _phongTH3List;
        public ObservableCollection<ThuModel> PhongTH3List
        {
            get { return _phongTH3List; }
            set
            {
                _phongTH3List = value;
                OnPropertyChanged("PhongTH3List");
            }
        }




        //NamHocList
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
        //    NamHocSelect
        private NamHocModel _namHocSelect;
        public NamHocModel NamHocSelect
        {
            get { return _namHocSelect; }
            set
            {
                _namHocSelect = value;
                OnPropertyChanged("NamHocSelect");
            }
        }
        //    KhoaSelect
        private KhoaModel _khoaSelect;
        public KhoaModel KhoaSelect
        {
            get { return _khoaSelect; }
            set
            {
                _khoaSelect = value;
                OnPropertyChanged("KhoaSelect");
            }
        }
        //    KhoaList
        private ObservableCollection<KhoaModel> _khoaList;
        public ObservableCollection<KhoaModel> KhoaList
        {
            get { return _khoaList; }
            set
            {
                _khoaList = value;
                OnPropertyChanged("KhoaList");
            }
        }
        //    MonHocList
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
        //    MonHocSelect
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
        //    LopSelect
        private LopModel _lopSelect;
        public LopModel LopSelect
        {
            get { return _lopSelect; }
            set
            {
                _lopSelect = value;
                OnPropertyChanged("LopSelect");
            }
        }
        //    LopList
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
        //    ChuyenNganhList
        private ObservableCollection<ChuyenNganhModels> _chuyenNganhList;
        public ObservableCollection<ChuyenNganhModels> ChuyenNganhList
        {
            get { return _chuyenNganhList; }
            set
            {
                _chuyenNganhList = value;
                OnPropertyChanged("ChuyenNganhList");
            }
        }
        //    ChuyenNganhSelect
        private ChuyenNganhModels _chuyenNganhSelect;
        public ChuyenNganhModels ChuyenNganhSelect
        {
            get { return _chuyenNganhSelect; }
            set
            {
                _chuyenNganhSelect = value;
                OnPropertyChanged("ChuyenNganhSelect");
            }
        }
        //    NgayBatDauDangKy
        private DateTime _ngayBatDauDangKy;
        public DateTime NgayBatDauDangKy
        {
            get { return _ngayBatDauDangKy; }
            set
            {
                _ngayBatDauDangKy = value;
                OnPropertyChanged("NgayBatDauDangKy");
            }
        }
        //    NgayKetThuDangKy
        private DateTime _ngayKetThuDangKy;
        public DateTime NgayKetThuDangKy
        {
            get { return _ngayKetThuDangKy; }
            set
            {
                _ngayKetThuDangKy = value;
                OnPropertyChanged("NgayKetThuDangKy");
            }
        }
        //    NgayBatDauHoc
        private DateTime _ngayBatDauHoc;
        public DateTime NgayBatDauHoc
        {
            get { return _ngayBatDauHoc; }
            set
            {
                _ngayBatDauHoc = value;
                OnPropertyChanged("NgayBatDauHoc");
            }
        }
        //    NgayKetThucHoc
        private DateTime _ngayKetThucHoc;
        public DateTime NgayKetThucHoc
        {
            get { return _ngayKetThucHoc; }
            set
            {
                _ngayKetThucHoc = value;
                OnPropertyChanged("NgayKetThucHoc");
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
            }
        }

        
        #endregion

        #region Methods
        public void LoadData()
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

            KhoaList = new ObservableCollection<KhoaModel>();
            foreach (var item in _context.Khoas)
            {
                KhoaList.Add(new KhoaModel() { Id = item.MaKhoa, Name = item.TenKhoa });
            }
            KhoaSelect = KhoaList.FirstOrDefault();

            ChuyenNganhList = new ObservableCollection<ChuyenNganhModels>();
            foreach (var item in _context.ChuyenNganhs)
            {
                if(item.MaKhoa== KhoaSelect.Id)
                    ChuyenNganhList.Add(new ChuyenNganhModels() { Id = item.MaChuyenNganh, Name = item.TenChuyenNganh });
            }
            ChuyenNganhSelect = ChuyenNganhList.FirstOrDefault();

            LopList = new ObservableCollection<LopModel>();
            foreach (var item in _context.Lops)
            {
                if (item.MaChuyenNganh == ChuyenNganhSelect.Id)
                    LopList.Add(new LopModel() { Id = item.IdLop, Name = item.TenLop });
            }
            LopSelect = LopList.FirstOrDefault();

            MonHocList = new ObservableCollection<MonHocModel>();
            foreach (var item in _context.MonHocs)
            {
                foreach (var hocHocPhan in _context.MonHocHocPhans)
                {
                    if (hocHocPhan.HocKiId == HocKiSelect.Id && hocHocPhan.NamHocId == NamHocSelect.Id)
                    {
                    }
                    else
                    {
                        MonHocList.Add(new MonHocModel()
                        {
                            Id = item.MonHocId,
                            MaMH = item.MaMonHoc,
                            TenMonHoc = item.TenMonHoc,

                        });
                    }
                }
            }
            MonHocSelect = MonHocList.FirstOrDefault();
        }
        #endregion

        #region ICommand
        public ICommand MoLopHocPhan
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    

                    //var b = new MainViewModel();
                    //var c = new MainWindow();
                    //c.
                    //b.UCShow = "ThemMonHocDKHP";
                    //var a = MainWindow.GetWindow(obj);
                    //var a=MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                });

            }
        }
        //MoLopHocPhan
        #endregion
    }
}
