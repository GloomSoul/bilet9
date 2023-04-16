using System;
using System.Collections.Generic;
using System.Linq;

namespace UserList
{
    public class UserList
    {
        private List<User> userList;

        public UserList()
        {
            userList = new List<User>();
        }

        public void Add(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (userList.Exists(u => u.Login == user.Login))
            {
                throw new ArgumentException("Пользователь с этим логином уже существует.");
            }

            userList.Add(user);
        }

        public void Remove(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new ArgumentException("Логин не может быть нулевым или пустым.");
            }

            if (userList.Count == 0)
            {
                throw new ArgumentException("Список пользователей пуст.");
            }

            int index = userList.FindIndex(u => u.Login == login);

            if (index == -1)
            {
                throw new ArgumentException("Пользователь с таким логином не существует.");
            }

            userList.RemoveAt(index);
        }
        public List<User> GetUsers()
        {
            return new List<User>(userList);
        }

    }
}
