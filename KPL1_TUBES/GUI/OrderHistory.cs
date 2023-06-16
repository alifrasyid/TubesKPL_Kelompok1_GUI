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
    public partial class OrderHistory : Form
    {
        private List<Order> orderHistory;
        public OrderHistory()
        {
            InitializeComponent();

            // Membuat instance List<Order> untuk menyimpan riwayat pemesanan
            orderHistory = new List<Order>();

            // Pengaturan properti DataGridView
            TabelOrderHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Menambahkan kolom pada DataGridView
            TabelOrderHistory.Columns.Add("Title", "Title");
            TabelOrderHistory.Columns.Add("Author", "Author");
            TabelOrderHistory.Columns.Add("Price", "Price");

        }

        public void AddOrder(string title, string author, decimal price)
        {
            // Membuat instance Order baru
            Order order = new Order(title, author, price);

            // Menambahkan pemesanan ke dalam riwayat
            orderHistory.Add(order);

            // Menampilkan riwayat pemesanan terbaru pada DataGridView
            TabelOrderHistory.Rows.Add(order.Title, order.Author, order.Price);
        }

        private void RefreshDataGridView()
        {
            // Membersihkan DataGridView
            TabelOrderHistory.Rows.Clear();

            // Menampilkan kembali riwayat pemesanan pada DataGridView
            foreach (var order in orderHistory)
            {
                TabelOrderHistory.Rows.Add(order.Title, order.Author, order.Price);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Memperbarui DataGridView
            RefreshDataGridView();
        }

        private void labelAdd_Click(object sender, EventArgs e)
        {
            // Membuat instance form AddBook
            AddBook addBookForm = new AddBook();

            // Menampilkan form AddBook
            addBookForm.Show();

            // Menyembunyikan form OrderHistory
            this.Hide();
        }

        private void labeldelete_Click(object sender, EventArgs e)
        {
            // Membuat instance form DeleteBook
            DeleteBook deleteBookForm = new DeleteBook();

            // Menampilkan form DeleteBook
            deleteBookForm.Show();

            // Menyembunyikan form OrderHistory
            this.Hide();
        }

        private void labelOrder_Click(object sender, EventArgs e)
        {
            // Membuat instance form Order
            Order OrderForm = new Order();

            // Menampilkan form Order
            OrderForm.Show();

            // Menyembunyikan form OrderHistory
            this.Hide();
        }
    }

    public partial class Order
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Order(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
