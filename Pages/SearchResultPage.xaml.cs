using System.Windows.Controls;

namespace MyDiary
{
    /// <summary>
    /// Interaction logic for SearchResultPage.xaml
    /// </summary>
    public partial class SearchResultPage : UserControl
    {
        public SearchResultPage()
        {
            InitializeComponent();

            DataContext = new WindowsViewModel();

            DiaryListContainer.ItemsSource = DatabaseManager.GetPages();
        }
    }
}
