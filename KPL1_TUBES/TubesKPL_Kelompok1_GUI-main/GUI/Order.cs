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
    public partial class Pencarian : Form
    {
        private List<Buku> buku;

        public Pencarian()
        {
            InitializeComponent();
            MuatBuku();
        }

        private void MuatBuku()
        {
            // Muat buku dari database atau sumber data lainnya
            buku = new List<Buku>()
            {
                new Buku("123456", "Buku 1", "Penulis 1"),
                new Buku("789012", "Buku 2", "Penulis 2"),
                new Buku("345678", "Buku 3", "Penulis 3")
            };
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string kueriPencarian = txtPencarian.Text;

            // Lakukan logika pencarian berdasarkan kueri pencarian
            List<Buku> hasilPencarian = CariBuku(kueriPencarian);

            // Tampilkan hasil pencarian
            TampilkanHasilPencarian(hasilPencarian);
        }

        private List<Buku> CariBuku(string kueriPencarian)
        {
            // Implementasikan logika pencarian di sini
            // Anda dapat menggunakan daftar buku untuk mencari buku yang sesuai
            // Contoh logika pencarian:
            return buku.Where(buku => buku.Judul.Contains(kueriPencarian)).ToList();
        }

        private void TampilkanHasilPencarian(List<Buku> hasilPencarian)
        {
            // Hapus hasil pencarian sebelumnya
            lstHasilPencarian.Items.Clear();

            // Tampilkan hasil pencarian dalam ListBox atau kontrol lainnya
            foreach (Buku buku in hasilPencarian)
            {
                lstHasilPencarian.Items.Add(buku.Judul + " oleh " + buku.Penulis);
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (lstHasilPencarian.SelectedItem != null)
            {
                string judulBukuTerpilih = lstHasilPencarian.SelectedItem.ToString();

                // Dapatkan buku terpilih berdasarkan judul
                Buku bukuTerpilih = buku.FirstOrDefault(buku => (buku.Judul + " oleh " + buku.Penulis) == judulBukuTerpilih);

                // Lakukan pemesanan untuk buku terpilih
                LakukanPemesanan(bukuTerpilih);
            }
        }

        private void LakukanPemesanan(Buku buku)
        {
            // Implementasikan logika pemesanan di sini
            // Anda dapat menggunakan buku terpilih untuk melakukan pemesanan
            // Contoh logika pemesanan:
            MessageBox.Show("Pemesanan dilakukan untuk " + buku.Judul + " oleh " + buku.Penulis);
        }
    }

    public class Buku
    {
        public string ISBN { get; set; }
        public string Judul { get; set; }
        public string Penulis { get; set; }

        public Buku(string isbn, string judul, string penulis)
        {
            ISBN = isbn;
            Judul = judul;
            Penulis = penulis;
        }
    }
}