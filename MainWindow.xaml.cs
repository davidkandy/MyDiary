using System.Data.SqlClient;
using System.Windows;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // You don't need this. You can't create a window from thin air...
        // private Window window;
        public MainWindow()
        {
            InitializeComponent();

            var window = this;

            DataContext = new WindowsViewModel(window); // <= this also works.

            //DiaryListContainer.ItemsSource = DatabaseManager.GetPages();

        }

    }
}
