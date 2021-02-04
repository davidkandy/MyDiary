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

        #endregion


        #region Constructors
        public RegisterViewModel()
        {
            // Thanks for the magic

            RegisterCommand = new RelayCommand(RegisterAsync);
        }
        #endregion

        #region Methods
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
            //MainWindow diaryContentWindow = new MainWindow();
            //bool? result = diaryContentWindow.ShowDialog();

            // So this is one way you could do it...
            //diaryContentWindow.RegisterPage.Visibility = System.Windows.Visibility.Hidden;

            // "diaryContentWindow" is MainWindow ooh
            // Lol...I know...

            // Let me do it right..
            var window = Application.Current.MainWindow as MainWindow;
            window.RegisterPage.Visibility = Visibility.Hidden;

            // So something similar to that.
            // I think you can switch views like that for now.... 
            // Yup.. this is more straight forward

            // Awesome. What next?...
            // I don't know.. I guess we're done, unless you want to teach me how to do the more complicated passwording technique
            // Nah, that's unnecessary for now...
            // Ok then.. I think our objectives for this app is complete
            // Unless you have something in mind?


            // Don't mind me here, I was just experimenting something 
            // Cool, bruv...All good..
            // I'm actually making you improvise for now, there are smoother solutions around this.
            // I just really want you to understand how it works, cuz there won't always be smooth solutions :)...
            // I'm glad to hear that :)
        }
        #endregion
    }
}
