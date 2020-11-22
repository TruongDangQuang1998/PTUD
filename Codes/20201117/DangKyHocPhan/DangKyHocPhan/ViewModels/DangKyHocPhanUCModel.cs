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
            var liststring = new ObservableCollection<string>();
            liststring.Add("Học kì 1(2020 - 2021)");
            liststring.Add("Học kì 3(2019 - 2020)");
            liststring.Add("Học kì 2(2019 - 2020)");
            liststring.Add("Học kì 1(2019 - 2020)");
            liststring.Add("Học kì 3(2018 - 2019)");
            liststring.Add("Học kì 2(2018 - 2019)");
            liststring.Add("Học kì 1(2018 - 2019)");
            HocKiList = liststring;
        }
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
    }
}
