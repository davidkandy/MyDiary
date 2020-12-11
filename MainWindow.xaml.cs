using System.Configuration;
using System.Windows;
using System.Data.SqlClient;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDiary.Properties.Settings.MyDiaryDBConnectionString"].ConnectionString;

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
