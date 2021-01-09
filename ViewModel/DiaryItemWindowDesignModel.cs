using System;

namespace MyDiary
{
    public class DiaryItemWindowDesignModel : DiaryItemWindowViewModel
    {
        #region Singleton
        /// <summary>
        /// A single instance of the design model 
        /// </summary>
        public static DiaryItemWindowDesignModel Instance = new DiaryItemWindowDesignModel();

        #endregion

        #region Constructor
        public DiaryItemWindowDesignModel()
        {
            Content = "Good Morning Yo!!!";
            TimeSaved = DateTime.Now;
            isOpen = false;
        }
        #endregion

    }
}
