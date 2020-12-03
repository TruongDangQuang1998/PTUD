using DangKyHocPhan.Views;
using System;
using System.Collections.Generic;
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
        #endregion
    }
}
