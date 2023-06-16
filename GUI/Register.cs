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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = IsiUsename.Text;
            string password = IsiPassword.Text;

            register(username, password);
        }
        private void register(string username, string password)
        {
            User user = new User
            {
                Username = username,
                Password = password
            };

            users.Add(user);

            MessageBox.Show("Registrasi Berhasil!");
        }

    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
