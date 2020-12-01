using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DangKyHocPhan.ViewModels
{
    public class UCModelUserLogin : BaseViewModel
    {
        public UCModelUserLogin()
        {

        }
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }


        #region ICommand
        private ICommand _clickLogin;
        public ICommand ClickLogin
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (Username == "giangvien") 
                    {
                        var mainwindown = new MainWindow();
                        mainwindown.ShowDialog();
                        

                    }
                    else
                    {

                    }

                });

            }
        }
        #endregion
    }
}
