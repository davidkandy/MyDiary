using System.Configuration;
using System.Windows;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDiary.Properties.Settings.MyDiaryDBConnectionString"].ConnectionString;
        }
    }
}
