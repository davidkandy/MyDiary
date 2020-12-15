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


        public MainWindow()
        {
            InitializeComponent();


            string connectionString = ConfigurationManager.ConnectionStrings["MyDiary.Properties.Settings.MyDiaryDBConnectionString"].ConnectionString;

        }

        private void SaveSpecificContent()
        {
            string query = "select * from User a  inner join UserContent uc on a.Id = uc.ContentId where uc.UserId = @UserId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

            using (dataAdapter)
            {
                //sqlCommand.Parameters.AddWithValue("@UserId",);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
