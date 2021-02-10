using Prism.Mvvm;
using System.Windows;
using System.Windows.Input;

namespace MyDiary
{
    public class RegisterViewModel : BindableBase
    {
        #region Properties

        public string Username { get; set; }
        public string Password { get; set; }

        #endregion

        #region Commands
        public ICommand RegisterCommand { get;  }
        public ICommand SignIntoAccountCommand { get; }

        #endregion

        #region Constructors
        public RegisterViewModel()
        {
            // Thanks for the magic

            RegisterCommand = new RelayCommand(RegisterAsync);
            SignIntoAccountCommand = new RelayCommand(SignIntoAccount);
        }
        #endregion

        #region Methods

        void SignIntoAccount()
        {
            var window = Application.Current.MainWindow as MainWindow;
            window.LoginPage.Visibility = Visibility.Visible;
            window.RegisterPage.Visibility = Visibility.Hidden;
        }

        void RegisterAsync()
        {
            //var user = new AppUser
            //{
            //    Username = Username,
            //    Password = Password
            //};

            var user = DatabaseManager.GetUsers()
                .FindOne(x => x.Username == Username);

            // TODO: User already exists... throw error
            if (user != null) return;

            user = new AppUser
            {
                Username = Username,
                Password = Password
            };

            // TODO: Maybe check to make sure that password is strong enough
            // 6 characters or more, with valid characters...

            DatabaseManager.AddUser(user);
            DatabaseManager.CurrentUser = user;

            // Don't forget to switch views here...
            var window = Application.Current.MainWindow as MainWindow;
            window.DiaryContentWindow.Visibility = Visibility.Visible;
            window.RegisterPage.Visibility = Visibility.Hidden;

            // So something similar to that.
            // I think you can switch views like that for now.
        }
        #endregion
    }
}
