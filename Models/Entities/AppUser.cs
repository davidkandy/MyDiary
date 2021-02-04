using System.Security;

namespace MyDiary
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        //public string Email { get; set; }

        // Perfect, cuz you can't store Securestring in the database.
        // It is designed to securely store sensitive information in the memory.
        public string Password { get; set; }

        public AppUser()
        {

        }
    }
}
