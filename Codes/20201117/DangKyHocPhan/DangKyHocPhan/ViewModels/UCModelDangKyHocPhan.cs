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
            //_dataBaseService = new DataBaseService();
            //_context = new Context();
            //_context = _dataBaseService.GetContext();
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

        #endregion

        #region Methods
        public void LoadHocKi()
        {
            HocKiList = DataFree.hocKiModels;
            HocKiSelect = HocKiList.FirstOrDefault();

            NamHocList = DataFree.namHocModels;
            NamHocSelect = NamHocList.FirstOrDefault();
        }
        
        public void LoadListMonHoc()
        {
            MonHocDaDangKyList = new ObservableCollection<MonHocDaDangKyModel>();
            MonHocList = new ObservableCollection<MonHocModel>();
            if (HocKiSelect != null && NamHocSelect != null)
            {
                if (HocKiSelect.Id == 1 && NamHocSelect.Id == 1)
                    foreach (var item in DataFree.monHocModels)
                    {
                        if (MonHocList != null)
                            if (item.TrangThaiDangKy == 0)
                                MonHocList.Add(item);                    }
            }
            MonHocDaDangKyList = DataFree.monHocDaDangKyModels;
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
        }

        public void LoadChiTietHocPhan()
        {
            ChiTietList = new ObservableCollection<ChiTietModel>();
            NhomTHList = new ObservableCollection<string>();
            if (HocPhanSelect != null)
            {
                foreach (var item in DataFree.chiTietModels)
                {
                    if (HocPhanSelect.Id == item.MaLopHocPhan)
                    {
                        ChiTietList.Add(item);
                    }
                    if (!string.IsNullOrEmpty(item.NhomTH))
                    {
                        NhomTHList.Add(item.NhomTH);
                        NhomTHSelect = NhomTHList.FirstOrDefault();
                    }
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
        public void LoadNhomThucHanh(int hocPhanId)
        {
            //if (NhomTHList != null)
            //    NhomTHList.Clear();
            //var list2 = new ObservableCollection<string>();
            //if(hocPhanId == 1 || hocPhanId == 3 || hocPhanId == 5 || hocPhanId == 5)
            //{
            //    list2.Add("1");
            //    list2.Add("2");
            //}
            //if (hocPhanId == 2 || hocPhanId ==  4|| hocPhanId == 6 || hocPhanId == 8)
            //{
            //    list2.Add("1");
            //}
            //NhomTHList = list2;
            //NhomTHSelect = list2.FirstOrDefault();
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
            
            //ObservableCollection<ChiTietModel> chiTiets = new ObservableCollection<ChiTietModel>();
            //chiTiets.Add(new ChiTietModel() { Stt = 1, GiangVien = "Nguyễn Văn A", LichHoc = "LT-Thứ 2 (T6-T8)", NhomTH = "", Phong = "A1.1", ThoiGian = "15/08/2020-15/11/2020" });
            //chiTiets.Add(new ChiTietModel() { Stt = 2, GiangVien = "Nguyễn Văn A", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "1", Phong = "B11.1", ThoiGian = "15/08/2020-15/11/2020" });
            //chiTiets.Add(new ChiTietModel() { Stt = 3, GiangVien = "Nguyễn Văn B", LichHoc = "TH-Thứ 4 (T1-T6)", NhomTH = "2", Phong = "B11.2", ThoiGian = "15/08/2020-15/11/2020" });
            //ChiTietList = chiTiets;

            //var list2 = new ObservableCollection<string>();
            //list2.Add("1");
            //list2.Add("2");
            //NhomTHList = list2;
            //NhomTHSelect = list2.FirstOrDefault();
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
                    if (MonHocSelect != null && HocPhanSelect != null )
                    {
                        if(ChiTietList.Count == 0)
                        {
                            MessageBox.Show("Bạn chưa chọn môn học.\n Vui lòng chọn môn học trước khí đăng ký", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else if (ChiTietList.Count == 1)
                        {
                            DataFree.monHocDaDangKyModels.Add(new MonHocDaDangKyModel()
                            {
                                Id = DataFree.monHocDaDangKyModels.Count + 1,
                                GiangVien = ChiTietSelect.GiangVien,
                                MaHP = HocPhanSelect.MaLHP,
                                SoTC = MonHocSelect.SoTC,
                                STT = DataFree.monHocDaDangKyModels.Count + 1,
                                TenMonHoc = MonHocSelect.TenMonHoc,
                                TrangThai = HocPhanSelect.TrangThai,
                                IdMonHoc = MonHocSelect.Id
                            });
                            var monhoc = DataFree.monHocModels.FirstOrDefault(x => x.Id == MonHocSelect.Id);
                            monhoc.TrangThaiDangKy = 1;
                            MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                        }
                        else if(NhomTHSelect!=null)
                        {
                            DataFree.monHocDaDangKyModels.Add(new MonHocDaDangKyModel()
                            {
                                Id = DataFree.monHocDaDangKyModels.Count + 1,
                                GiangVien = ChiTietSelect.GiangVien,
                                MaHP = HocPhanSelect.MaLHP,
                                SoTC = MonHocSelect.SoTC,
                                STT = DataFree.monHocDaDangKyModels.Count + 1,
                                TenMonHoc = MonHocSelect.TenMonHoc,
                                TrangThai = HocPhanSelect.TrangThai,
                                IdMonHoc = MonHocSelect.Id,
                                NhomTH = NhomTHSelect
                            }) ;
                            var monhoc = DataFree.monHocModels.FirstOrDefault(x => x.Id == MonHocSelect.Id);
                            monhoc.TrangThaiDangKy = 1;
                            MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn Nhóm Thực hành", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    LoadListMonHoc();


                });

            }
        } 
        public ICommand HyHocPhan
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    
                    if (MonHocDaDangKySelect!=null)
                    {
                        var a = MessageBox.Show($"Bạn muốn hủy học phần {MonHocDaDangKySelect.TenMonHoc}?", "Hủy học phần", MessageBoxButton.YesNo);
                        if(a== MessageBoxResult.Yes)
                        {
                            if (MonHocDaDangKySelect.TrangThai != "Chấp nhận mở lớp")
                            {
                                var monhoc = DataFree.monHocModels.FirstOrDefault(x => x.Id == MonHocDaDangKySelect.IdMonHoc);
                                monhoc.TrangThaiDangKy = 0;
                                DataFree.monHocDaDangKyModels.Remove(MonHocDaDangKySelect);
                                MonHocDaDangKyList.Remove(MonHocDaDangKySelect);
                                MessageBox.Show("Hủy Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                            }
                            else
                            {
                                MessageBox.Show($"Môn học đang trong trạng thái chấp nhận mở lớp\n Không thể hủy?", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                        
                        
                        
                    }


                });

            }
        }
        #endregion
    }
}
