using DangKyHocPhan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DangKyHocPhan.Views
{
    /// <summary>
    /// Interaction logic for ChuongTrinhKhungUC.xaml
    /// </summary>
    public partial class ChuongTrinhKhungUC : UserControl
    {
        public ChuongTrinhKhungUC()
        {
            InitializeComponent();
            this.DataContext = new UCModelChuongTrinhKhung();
        }
    }
}
