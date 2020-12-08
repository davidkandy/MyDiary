using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyDiary
{
    public class DiaryItemContentViewModel : BaseViewModel
    {
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
        #endregion


        #region Constructor
        public DiaryItemContentViewModel()
        {
            SaveCommand = new RelayCommand(Save);
            ClearAllTextCommand = new RelayCommand(ClearAllText);
            EditCommand = new RelayCommand(Edit);
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

    }
}
