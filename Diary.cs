using System;

namespace MyDiary
{
    public class Diary
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }

        public bool IsOpen { get; set; }
    }
}
