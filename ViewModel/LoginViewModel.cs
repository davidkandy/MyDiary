using Prism.Mvvm;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Input;

namespace MyDiary
{
    public class LoginViewModel : BindableBase
    {
        public string Username { get; set; }

        // I know this is not that secure, but we're saving the stress for now...
        // Okay, the right thing to use is SecureString right? 
        // Yup, good work with the research....
        public string Password { get; set; }

        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(LoginAsync);
        }
        
        private void LoginAsync()
        {
            //var user = new AppUser
            //{
            //    Username = Username,
            //    Password = Password
            //};

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

        }
    }
}
