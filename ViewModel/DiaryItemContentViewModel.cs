using Prism.Mvvm;
using System;
using System.Windows.Input;
using MyDiary.Models.Entities;

namespace MyDiary
{
    public class DiaryItemContentViewModel : BindableBase
    {
        public DiaryPage Page { get; set; }


        /// <summary>
        /// Title of the diary 
        /// </summary>
        public string Title
        {
            get { return Page.Title; }
            set { Page.Title = value; }
        }

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
        public DiaryItemContentViewModel()
        {
            var coe = new DiaryContentWindow();

            //SaveCommand = new RelayCommand(coe.Save);

            //CancelCommand = new RelayCommand(coe.Cancel);
        }
        #endregion
    }
}
