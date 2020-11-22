using DangKyHocPhan.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //    LoginWD loginWindow = new LoginWD();
            //    loginWindow.ShowDialog();
            //}
            //  );
        }
    }
}
