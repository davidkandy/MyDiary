using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace MyDiary
{
    public class DiaryItemContentViewModel : DiaryListItemContentViewModel
    {
        #region Private fields 
        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;

        private WindowResizer mWindowResizer;

        /// <summary>
        /// The content thread items for the list
        /// </summary>
        protected ObservableCollection<DiaryListItemContentViewModel> mItems;

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
        /// The content thread items for the list
        /// NOTE: Do not call Items.Add to add messages to this list
        ///       as it will make the FilteredItems out of sync
        /// </summary>
        public ObservableCollection<DiaryListItemContentViewModel> Items 
        {
            get => mItems;

            set
            {
                //Make sure the list has changed
                if (mItems == value) return;

                //Update the value
                mItems = value;
                //Update filtered list to match
                FilteredItems = new ObservableCollection<DiaryListItemContentViewModel>(mItems);
            }
        }

        /// <summary>
        /// The Content thread that includes any search filtering
        /// </summary>
        public ObservableCollection<DiaryListItemContentViewModel> FilteredItems { get; set; }

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

        /// <summary>
        /// Command that adds a new diary content to the list of contents
        /// </summary>
        public ICommand AddContentCommand;

        #endregion

        #region Constructor
        public DiaryItemContentViewModel()
        {
            SaveCommand = new RelayCommand(Save);
            ClearAllTextCommand = new RelayCommand(ClearAllText);
            EditCommand = new RelayCommand(Edit);
            AddContentCommand = new RelayCommand(AddContent);

            //Menu Commands
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));
        }
        #endregion

        #region Command Methods

        public void AddContent()
        {
            // Don't send a blank message
            if (string.IsNullOrEmpty(PendingContent)) return;

            // Ensure lists are not null
            if (Items == null)
                Items = new ObservableCollection<DiaryListItemContentViewModel>();

            if (FilteredItems == null)
                FilteredItems = new ObservableCollection<DiaryListItemContentViewModel>();

            var content = new DiaryListItemContentViewModel
            {
                Content = PendingContent,
                isOpen = false,
                TimeSaved = DateTime.Today
            };

            // Add content to both lists
            Items.Add(content);
            FilteredItems.Add(content);

            // Clear the Pending content 
            PendingContent = string.Empty;

        }

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

        #region Private helper
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
