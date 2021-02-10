using System.Security;
using System.Windows;
using System.Windows.Controls;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }

        public SecureString SecurePassword => PasswordText.SecurePassword;

        void NavigateBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DiaryContentWindow());
        }
    }
}
