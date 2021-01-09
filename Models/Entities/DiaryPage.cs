using System;
using System.ComponentModel;

namespace MyDiary
{
    public class DiaryPage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [LiteDB.BsonId]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        string content;
        public string Content
        {
            get { return content; }
            set 
            { 
                content = value;
                RaisePropertyChanged(Content);
            }
        }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; }

        void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
