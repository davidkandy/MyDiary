using System;
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

            var window = this;

            DataContext = new WindowsViewModel(this); // <= this also works.

            var diaryCW = this.DiaryContentWindow;
            var diaryItemWindow = this.ItemContentWindow;

            DiaryContentWindow.DiaryContent += (s, e) =>
            {
                diaryItemWindow.DataContext = e;

                diaryItemWindow.Visibility = Visibility.Visible;
                diaryCW.Visibility = Visibility.Hidden;

            };

            ItemContentWindow.DiaryContent += (s, e) =>
            {
                diaryCW.DataContext = e;

                diaryCW.Visibility = Visibility.Visible;
                diaryItemWindow.Visibility = Visibility.Hidden;
                
            };

        }

    }
}
