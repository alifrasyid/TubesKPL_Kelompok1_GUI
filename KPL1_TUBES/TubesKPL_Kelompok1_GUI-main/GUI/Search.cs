﻿using System;
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
        private List<Buku> daftarBuku;

        public Pencarian()
        {
            InitializeComponent();
            InisialisasiDaftarBuku();
        }

        private void InisialisasiDaftarBuku()
        {
            // Menginisialisasi daftar buku dari sumber data
            daftarBuku = new List<Buku>()
            {
                new Buku("123456", "Buku 1", "Penulis 1"),
                new Buku("789012", "Buku 2", "Penulis 2"),
                new Buku("345678", "Buku 3", "Penulis 3")
            };
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string kataKunci = txtPencarian.Text;

            // Melakukan pencarian buku berdasarkan kata kunci
            List<Buku> hasilPencarian = CariBuku(kataKunci);

            // Menampilkan hasil pencarian
            TampilkanHasilPencarian(hasilPencarian);
        }

        private List<Buku> CariBuku(string kataKunci)
        {
            // Melakukan logika pencarian berdasarkan kata kunci
            // Anda dapat menggunakan daftarBuku untuk mencari buku yang sesuai
            // Contoh logika pencarian:
            return daftarBuku.Where(buku => buku.Judul.Contains(kataKunci)).ToList();
        }

        private void TampilkanHasilPencarian(List<Buku> hasilPencarian)
        {
            // Membersihkan hasil pencarian sebelumnya
            lstHasilPencarian.Items.Clear();

            // Menampilkan hasil pencarian dalam ListBox atau kontrol lainnya
            foreach (Buku buku in hasilPencarian)
            {
                lstHasilPencarian.Items.Add(buku.Judul + " oleh " + buku.Penulis);
            }
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
