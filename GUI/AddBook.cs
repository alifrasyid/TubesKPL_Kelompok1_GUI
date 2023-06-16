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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void labelAdd_Click(object sender, EventArgs e)
        {
            
        }

        private string button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = "\nBuku " + textBox1.Text + ", \nTahun Terbitnya adalah " + textBox2.Text + ", \nPenulisnya adalah " + textBox3.Text ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
        }
    }
}
