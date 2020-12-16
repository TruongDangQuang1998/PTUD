using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Models
{
    public class SinhVienModel
    {
        public SinhVienModel()
        {
            IdMonHocs = new List<int>();
            MonHocDaDangKyModels = new ObservableCollection<MonHocDaDangKyModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string MSSV { get; set; }
        public string Khoa { get; set; }
        public string ChuyenNganh { get; set; }
        public string Lop { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public List<int> IdMonHocs { get; set; }
        public ObservableCollection<MonHocDaDangKyModel> MonHocDaDangKyModels { get; set; }
    }
}
