using System.Windows;
using System.Windows.Controls;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Window
    {
        public RegisterPage()
        {
            InitializeComponent();
            this.DataContext = new RegisterViewModel();
        }
    }
}
