using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DangKyHocPhan.ViewModels
{
    public class UCModelThemMonHocDKHP : BaseViewModel
    {
        public UCModelThemMonHocDKHP()
        {

        }

        #region Properties
        #endregion

        #region Methods
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
                    //MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                });

            }
        }
        //MoLopHocPhan
        #endregion
    }
}
