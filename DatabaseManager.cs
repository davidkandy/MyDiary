using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDiary
{
    public static class DatabaseManager
    {
        static string DatabasePath { get; set; } = "Diary.db";

        static LiteDatabase Database { get; } = new LiteDatabase(DatabasePath);

        static DiaryContentWindowViewModel diaryContentVM { get; } = new DiaryContentWindowViewModel();

        public static void AddPage(DiaryPage diary)
        {
            var collection = Database.GetCollection<DiaryPage>(nameof(DiaryPage));
            collection.Upsert(diary);
        }

        public static DiaryPage GetPage(DateTime date)
        {
            var collection = Database.GetCollection<DiaryPage>(nameof(DiaryPage));
            return collection.Find(d => d.Created == date.Date)
                .SingleOrDefault();
        }

        public static IEnumerable<DiaryPage> GetPages()
        {
            var collection = Database.GetCollection<DiaryPage>(nameof(DiaryPage));
            return collection.FindAll();
        }
    }
}
