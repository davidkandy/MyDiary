﻿using MyDiary;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace MyDiary
{
    public class WindowsViewModel : BindableBase
    {
        #region Private fields

        private Window mWindow;

        #endregion

        #region Public Properties

        /// <summary>
        /// The title to display 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A new diary content awaiting to be saved and added to the list
        /// </summary>
        public string PendingContent;

        /// <summary>
        /// Pages
        /// </summary>
        public List<DiaryPage> Pages { get; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Command to clear all the text in the content control
        /// </summary>
        public ICommand ClearAllTextCommand { get;}

        /// <summary>
        /// Command to Minimize the window
        /// </summary>
        public ICommand MinimizeCommand { get;}

        /// <summary>
        /// Command to maximize the window 
        /// </summary>
        public ICommand MaximizeCommand { get;}

        /// <summary>
        /// Command to close the window 
        /// </summary>
        public ICommand CloseCommand { get; }

        /// <summary>
        /// Command to show the system menu of the window 
        /// </summary>
        public ICommand MenuCommand { get;}

        /// <summary>
        /// Command that adds a new diary content
        /// </summary>
        public ICommand NewContentCommand { get;}

        /// <summary>
        /// Command to search for a particular diary content 
        /// </summary>
        public ICommand SearchCommand { get; }

        #endregion

        #region Constructor
        public WindowsViewModel(Window window)
        {
            mWindow = window;

            ClearAllTextCommand = new RelayCommand(ClearAllText);
            NewContentCommand = new RelayCommand(NewContent);
            SearchCommand = new RelayCommand(Search);

            //Menu Commands

            MinimizeCommand = new RelayCommand(
                () =>
                {
                    mWindow.WindowState = WindowState.Minimized;

                });

            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            //MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));

            var pages = DatabaseManager.GetPages();
            Pages = new List<DiaryPage>(pages);
        }

        public void Search()
        {
            var window = Application.Current.MainWindow as MainWindow;
            window.SearchResultPage.Visibility ^= Visibility.Hidden;

        }

        public WindowsViewModel()
        {

        }
        #endregion
         
        #region Command Methods
        public void ClearAllText()
        {

        }

        public void NewContent()
        {
            var window = Application.Current.MainWindow as MainWindow;
            window.DiaryContentWindow.Visibility ^= Visibility.Hidden;
        }

        #endregion

    }
}