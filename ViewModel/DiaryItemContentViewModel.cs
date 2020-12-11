using System.Windows;
using System.Windows.Input;

namespace MyDiary
{
    public class DiaryItemContentViewModel : BaseViewModel
    {
        #region Private fields 
        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;

        private WindowResizer mWindowResizer;

        #endregion

        #region Public Properties
        /// <summary>
        /// The title to display 
        /// </summary>
        public string Title { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Command to save the diary content
        /// </summary>
        public ICommand SaveCommand;

        /// <summary>
        /// Command to clear all the text in the content control
        /// </summary>
        public ICommand ClearAllTextCommand;

        /// <summary>
        /// Command to Edit the text in the content control
        /// </summary>
        public ICommand EditCommand;

        /// <summary>
        /// Command to Minimize the window
        /// </summary>
        public ICommand MinimizeCommand;

        /// <summary>
        /// Command to maximize the window 
        /// </summary>
        public ICommand MaximizeCommand;

        /// <summary>
        /// Command to close the window 
        /// </summary>
        public ICommand CloseCommand;

        /// <summary>
        /// Command to show the system menu of the window 
        /// </summary>
        public ICommand MenuCommand;

        #endregion


        #region Constructor
        public DiaryItemContentViewModel()
        {
            SaveCommand = new RelayCommand(Save);
            ClearAllTextCommand = new RelayCommand(ClearAllText);
            EditCommand = new RelayCommand(Edit);

            //Menu Commands
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));
        }
        #endregion

        #region Command Methods

        public void Save()
        {

        }

        public void ClearAllText()
        {

        }

        public void Edit()
        {

        }
        #endregion


        #region Private helpers
        /// <summary>
        /// Gets the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            return mWindowResizer.GetCursorPosition();
        }
        #endregion



    }
}
