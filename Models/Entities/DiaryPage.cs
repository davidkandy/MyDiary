using Prism.Mvvm;
using System;

namespace MyDiary.Models.Entities
{
    public class DiaryPage : BindableBase
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        //public ObjectId Id { get; set; }

        public int UserId { get; set; }

        public string Id { get; set; } = Guid.NewGuid().ToString();

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

        // <summary>
        // Instance of the DiaryPage class
        // </summary>
        // public DiaryPage DiaryContent { get; set; } // <= Still declaring a David Kandy inside of a David Kandy...You realize that this creates an infinite set of David Kandys right?
        // All good, move AppUser to the Entities folder.

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
