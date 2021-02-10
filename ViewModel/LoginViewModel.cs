using Prism.Mvvm;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using System.Windows.Input;

namespace MyDiary
{
    public class LoginViewModel : BindableBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand { get; }
        public ICommand CreateAccountCommand { get; }

        readonly MainWindow window = Application.Current.MainWindow as MainWindow; 

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
            CreateAccountCommand = new RelayCommand(CreateAccount);
        }
        
        private void Login()
        {
            var user = DatabaseManager.GetUsers()
                .FindOne(x => x.Username == Username);

            // TODO: Here throw an error that the user does not exist...Suggest that they are created?...
            if (user == null) return;

            // TODO: Report that the password was incorrect
            if (user.Password != Password)
                return;

            // DatabaseManager.AddUser(user);
            // => Here simply close the Login Page and let the user in...
            // => You could also set the current user somewhere...
            // Maybe in the DatabaseManager class.
            // Follow me, let me show you an example
            
            
            // I forgot to add this :)
            DatabaseManager.CurrentUser = user;

            // Don't forget to switch views here...
            window.LoginPage.Visibility = Visibility.Hidden;
            window.DiaryContentWindow.Visibility = Visibility.Visible;
        }

        void CreateAccount()
        {
            window.LoginPage.Visibility = Visibility.Hidden;
            window.RegisterPage.Visibility = Visibility.Visible;
        }
    }
}
