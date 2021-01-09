using System;
using System.Windows;
using System.Windows.Controls;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for DiaryContentWindow.xaml
    /// </summary>
    public partial class DiaryContentWindow : UserControl
    {
        public DiaryContentWindow()
        {
            InitializeComponent();

            DataContext = new DiaryContentWindowDesignModel();
        }

        public void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            lock (this)
            {
                DiaryContentControl.Visibility = Visibility.Hidden;
            }
        }

        public void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var page = new DiaryPage();
            DatabaseManager.AddPage(page);
        }

    }
}
