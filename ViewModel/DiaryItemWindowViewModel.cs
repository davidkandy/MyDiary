using Prism.Mvvm;
using System;
using System.Windows.Input;

namespace MyDiary
{
    public class DiaryItemWindowViewModel : BindableBase
    {
        /// <summary>
        /// The content of each diary page
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Flag indicating whether the content a content is open
        /// </summary>
        public bool isOpen { get; set; }

        /// <summary>
        /// The time the diary content was saved
        /// </summary>
        public DateTimeOffset TimeSaved { get; set; }

        #region Commands

        public ICommand SaveCommand { get; set; }

        public ICommand CancelCommand { get; set; }

        #endregion

        #region Contructor
        public DiaryItemWindowViewModel()
        {
            var coe = new DiaryContentWindow();

            //SaveCommand = new RelayCommand(coe.Save);

            //CancelCommand = new RelayCommand(coe.Cancel);
        }
        #endregion
    }
}
