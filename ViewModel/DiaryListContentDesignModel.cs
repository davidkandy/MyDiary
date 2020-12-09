using System;

namespace MyDiary
{
    public class DiaryListContentDesignModel : DiaryListItemContentViewModel
    {
        #region Singleton
        /// <summary>
        /// A single instance of the design model 
        /// </summary>
        public static DiaryListContentDesignModel Instance = new DiaryListContentDesignModel();

        #endregion

        #region Constructor
        public DiaryListContentDesignModel()
        {
            Content = "I woke up by 6am, said my prayer and prepared to go out for work, at work I was given plenty tasks which I completed before days end." +
                " After work, I met up with Sandra at Carter's Lounge";
            TimeSaved = DateTime.Now;
            isOpen = false;
        }
        #endregion

    }
}
