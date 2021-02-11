using System.Windows.Controls;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : UserControl
    {
        public RegisterPage()
        {
            InitializeComponent();
            this.DataContext = new RegisterViewModel();
        }
    }
}
