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
        }

        public void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            lock (this)
            {
                DiaryContentControl.Visibility = Visibility.Hidden;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string content = ContentTextBox.Text;

                if (string.IsNullOrEmpty(content))
                {
                    var input = MessageBox.Show("Are you sure you don't want to write about your day?", "Incomplete Diary", MessageBoxButton.YesNo);
                    if (input == MessageBoxResult.Yes) return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
