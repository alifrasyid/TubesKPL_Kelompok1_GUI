using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        private List<User> users = new List<User>();
        public Login()
        {
            InitializeComponent();
        }

        private void IsiUsename_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = IsiUsename.Text;
            string password = IsiPassword.Text;

            bool isLoggedIn = login(username, password);
            if (isLoggedIn)
            {
                MessageBox.Show("Login berhasil!");
                // Lanjutkan ke MainForm atau tampilan lainnya
            }
        }
        private bool login(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }

            MessageBox.Show("Login gagal. Username atau Password anda salah.");
            return false;
        }
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
