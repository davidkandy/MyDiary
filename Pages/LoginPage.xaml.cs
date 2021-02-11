using System.Security;
using System.Windows.Controls;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }

        public SecureString SecurePassword => PasswordText.SecurePassword;

    }
}
