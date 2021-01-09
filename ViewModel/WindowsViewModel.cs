﻿using Prism.Mvvm;
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

        #endregion

        #region Public Commands

        /// <summary>
        /// Command to save the diary content
        /// </summary>
        public ICommand SaveCommand { get;}

        /// <summary>
        /// Command to clear all the text in the content control
        /// </summary>
        public ICommand ClearAllTextCommand { get;}

        /// <summary>
        /// Command to Edit the text in the content control
        /// </summary>
        public ICommand EditCommand { get;}

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
        /// Command that adds a new diary content to the list of contents
        /// </summary>
        public ICommand AddContentCommand { get;}

        #endregion

        #region Constructor
        public WindowsViewModel(Window window)
        {
            mWindow = window;

            SaveCommand = new RelayCommand(Save);
            ClearAllTextCommand = new RelayCommand(ClearAllText);
            EditCommand = new RelayCommand(Edit);

            //Menu Commands
            
            MinimizeCommand = new RelayCommand(
                () =>
                {
                    mWindow.WindowState = WindowState.Minimized;

                    // It's not hitting the breakpoint

                });

            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            //MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));
        }
        #endregion

        #region Command Methods
        public void Save()
        {
            var page = new DiaryPage();
            DatabaseManager.AddPage(page);
        }

        public void ClearAllText()
        {

        }

        public void Edit()
        {

        }

        #endregion

        #region Private helper
        /// <summary>
        /// Gets the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        /*private Point GetMousePosition()
        {
            return mWindowResizer.GetCursorPosition();
        }
        */

        #endregion

    }
}