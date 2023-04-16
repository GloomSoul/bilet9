using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserList;

namespace _9._1
{
    public partial class Form1 : Form
    {
        private UserList.UserList userList;

        public Form1()
        {
            InitializeComponent();
            userList = new UserList.UserList();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = FullNameTextBox.Text;
                string login = LoginTextBox.Text;
                string password = PasswordTextBox.Text;
                string group = GroupTextBox.Text;
                DateTime lastLogin = LastLoginDateTimePicker.Value;
                DateTime created = CreatedDateTimePicker.Value;
                int warnings = int.Parse(WarningsTextBox.Text);

                User user = new User(fullName, login, password, group, lastLogin, created, warnings);

                userList.Add(user);

                MessageBox.Show("Пользователь успешно добавлен.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string login = LoginTextBox.Text;

                userList.Remove(login);

                MessageBox.Show("Пользователь успешно удален.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateListBox()
        {
            UserListBox.Items.Clear();
            foreach (User user in userList.GetUsers())
            {
                UserListBox.Items.Add(user.Login);
            }
        }


    }
}
