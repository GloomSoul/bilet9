using System;

namespace UserList
{
    public class User
    {
        public string FullName { get; }
        public string Login { get; }
        public string Password { get; }
        public string Group { get; }
        public DateTime LastLogin { get; }
        public DateTime Created { get; }
        public int Warnings { get; }

        public User(string fullName, string login, string password, string group, DateTime lastLogin, DateTime created, int warnings)
        {
            FullName = fullName;
            Login = login;
            Password = password;
            Group = group;
            LastLogin = lastLogin;
            Created = created;
            Warnings = warnings;
        }
    }
}
