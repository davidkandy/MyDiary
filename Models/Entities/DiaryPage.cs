using LiteDB;
using Prism.Mvvm;
using System;

namespace MyDiary
{
    public class DiaryPage : BindableBase
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        //public string Id { get; set; } = Guid.NewGuid().ToString();

        public ObjectId Id { get; set; }

        /// <summary>
        /// Title of the diary's content 
        /// </summary>
        private string title = "Insert Title...";
        public string Title
        {
            get { return title; }
            set 
            {
                SetProperty(ref title, value); 
            }
        }

        /// <summary>
        /// Content of the diary 
        /// </summary>
        private string content;
        public string Content
        {
            get{ return content; }
            set
            {
                SetProperty(ref content, value);
            }
        }

        /// <summary>
        /// Instance of the DiaryPage class
        /// </summary>
        public DiaryPage DiaryContent { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; }

        //void RaisePropertyChanged([CallerMemberName]string property = "")
        //{
        //    var handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler?.Invoke(this, new PropertyChangedEventArgs(property));
        //    }
        //}
    }
}
