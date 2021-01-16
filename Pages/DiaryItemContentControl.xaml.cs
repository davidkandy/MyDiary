using System;
using System.Windows.Controls;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for DiaryItemContentControl.xaml
    /// </summary>
    public partial class DiaryItemContentControl : UserControl
    {
        public event EventHandler<DiaryPage> DiaryContent;

        public DiaryItemContentControl()
        {
            InitializeComponent();
        }
    }
}
