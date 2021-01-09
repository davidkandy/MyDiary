using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        // You don't need this. You can't create a window from thin air...
        // private Window window;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDiary.Properties.Settings.MyDiaryDBConnectionString"].ConnectionString;

            var window = this;

            var diaryCW = this.DiaryContentDisplay;
            var diaryItemWindow = this.ItemContentWindow;

            DataContext = new WindowsViewModel(this); // <= this also works.
        }

        private void SaveSpecificContent(object sender, RoutedEventArgs e)
        {
            string query = "select * from User a  inner join UserContent uc on a.Id = uc.ContentId where uc.UserId = @UserId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

            using (dataAdapter)
            {
                //sqlCommand.Parameters.AddWithValue("@UserId",);
            }
        }


    }
}
