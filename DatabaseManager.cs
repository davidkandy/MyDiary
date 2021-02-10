using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using MyDiary;

namespace MyDiary
{
    public static class DatabaseManager
    {
        static string DatabasePath { get; set; } = "Diary.db";

        static LiteDatabase Database { get; } = new LiteDatabase(DatabasePath);

        public static AppUser CurrentUser { get; set; }

        public static void AddUser(AppUser user)
        {
            DiaryPage dpage = new DiaryPage();
            var collection = Database.GetCollection<AppUser>(nameof(AppUser));

            var userCollection = Database.GetCollection<AppUser>(nameof(AppUser));

            if (collection.Exists(x => x.Username == user.Username))
                throw new InvalidOperationException("Username already exists");

            //if (!userCollection.Exists(x => x.Id == dpage.UserId))
            //    throw new InvalidOperationException("Failed to locate DiaryOwner");
            
            collection.Insert(user);
        }


        public static void AddPage(DiaryPage diary)
        {
            var collection = Database.GetCollection<DiaryPage>(nameof(DiaryPage));

            //diary.UserId = CurrentUser.Id;

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

            // This is pretty critical. It simply says return only pages created by this user.
            // This is why it's really important to set the UserId of every diary page...
            //DatabaseManager.CurrentUser = user;

            return collection.FindAll().Where(x => x.UserId == CurrentUser?.Id);
        }

        public static ILiteCollection<AppUser> GetUsers()
        {
            var collection = Database.GetCollection<AppUser>(nameof(AppUser));
            return collection;
        }
    }
}
