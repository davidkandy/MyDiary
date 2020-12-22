using System;

namespace MyDiary
{
    public class DiaryPage
    {
        public string Id { get; set; }
        public string Content { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; }
    }
}
