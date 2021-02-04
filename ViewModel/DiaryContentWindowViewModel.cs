using LiteDB;
using Prism.Mvvm;
using System;
using System.Windows.Input;
using MyDiary.Models.Entities;

using static System.Net.Mime.MediaTypeNames;

namespace MyDiary
{
    public class DiaryContentWindowViewModel : BindableBase
    {
        #region Public Properties

        // Instance of the 
        public DiaryPage Page { get; set; }

        /// <summary>
        /// Title of the diary
        /// </summary>
        public string Title 
        {
            get => Page.Title;
            set => Page.Title = value;
        }

        /// <summary>
        /// The content in the Edit window
        /// </summary>
        public string Content
        {
            get => Page.Content;
            set => Page.Content = value;
        }

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
        public DiaryContentWindowViewModel(DiaryPage page, ObjectId id, string title, string content, DateTime dateTime)
        {
            Page = page;

            // Page.Id = id;
            Page.Title = title;
            Page.Content = content;
            Page.Created = dateTime;

            isOpen = true;

            SaveCommand = new RelayCommand(Save);
            CancelCommand = new RelayCommand(Cancel);
        }

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
            DatabaseManager.AddPage(Page);
        }
        private void Cancel()
        {

        }
        #endregion
    }
}
