using System.Windows;
using System.Windows.Controls;
using System;
using MyDiary.Models.Entities;


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

            DataContext = new DiaryContentWindowViewModel();

            //Loaded += (s, e) =>
            //{
            //    Console.WriteLine(this);
            //    DataContext = new DiaryContentWindowViewModel();
            //};
        }

        public void Save(DiaryPage page)
        {
            DatabaseManager.AddPage(page);
        }

    }
}
