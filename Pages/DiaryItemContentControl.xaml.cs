using System;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for DiaryItemContentControl.xaml
    /// </summary>
    public partial class DiaryItemContentControl : UserControl
    {
        DiaryListContentDesignModel model;

        public DiaryItemContentControl()
        {
            InitializeComponent();
        }
        public DiaryItemContentControl(string content, DateTime date, bool isOpen = false)
        {
            var props = model.GetType().GetProperties();
            // props.
        }
    }
}
