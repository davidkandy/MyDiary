using System;

namespace MyDiary
{
    public class DiaryListItemContentViewModel : BaseViewModel
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
    }
}
