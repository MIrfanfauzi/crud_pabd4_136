﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_pabd4
{
    public partial class Form1 : Form
    {
        // Ganti "SERVER" sesuai dengan SQL Server Anda
        private string connectionString = "Data Source=LAPTOP-N8SLA3LN\\IRFANFAUZI;Initial Catalog=pabdpert3;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Event saat form pertama kali dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Fungsi untuk mengosongkan semua input pada TextBox
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtEmail.Clear();
            txtTelepon.Clear();
            txtAlamat.Clear();
            txtNIM.Focus();  // Fokus kembali ke NIM agar user siap memasukkan data baru
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void dgvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
