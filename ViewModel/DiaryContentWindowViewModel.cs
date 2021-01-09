using Prism.Mvvm;
using System.Windows.Input;

namespace MyDiary
{
    public class DiaryContentWindowViewModel : BindableBase
    {
        #region Properties

        public DiaryPage Page { get; set; }

        /// <summary>
        /// The content in the Edit window
        /// </summary>
        public string Content { get => Page.Content; set => Page.Content = value; }


        /// <summary>
        /// Indicates whether the Editing window is open
        /// </summary>
        public bool isOpen { get; set; }


        #endregion

        #region Commands
        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        #endregion

        #region Constructor

        public DiaryContentWindowViewModel()
        {
            Page = new DiaryPage();

            isOpen = true;

            SaveCommand = new RelayCommand(Save);
            CancelCommand = new RelayCommand(Cancel);
        }   
        #endregion

        #region Methods
        private void Save()
        {
            //contentWindow.Save();
        }
        private void Cancel()
        {
            //contentWindow.CancelButton_Click();
        }
        #endregion
    }
}
