using System.Windows;
using System.Windows.Controls;
using System;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for DiaryContentWindow.xaml
    /// </summary>
    public partial class DiaryContentWindow : UserControl
    {
        public event EventHandler<DiaryPage> DiaryContent;

        public DiaryContentWindow()
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                Console.WriteLine(this);
                DataContext = new DiaryContentWindowViewModel();
            };
        }

        public void Save(DiaryPage page)
        {
            DatabaseManager.AddPage(page);
        }

    }
}
