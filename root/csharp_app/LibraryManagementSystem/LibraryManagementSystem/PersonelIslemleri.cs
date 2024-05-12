using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            // Veri çekme sorgusu
            string query = "SELECT * FROM library_staff";

            // Veri tablosu oluştur
            DataTable dataTable = new DataTable();

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, Program.databaseManager.GetConnection()))
            {
                // Verileri veri tablosuna doldur
                dataAdapter.Fill(dataTable);
            }

            // DataGridView'e veri tablosunu ata
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["staff_id"].ReadOnly = true;
        }

        private void aramaTextbox_TextChanged(object sender, EventArgs e)
        {
            string query = ""; // Aşağıda atanmamış diyip hata vermemesi için.

            // DİKKAT EDERSEN LIKE YERİNE ILIKE KULLANDIK ÇÜNKÜ ARAMALARDA BÜYÜK-KÜÇÜK HARF FARKETMEZ.
            if (fullName.Checked)
                query = $"SELECT * FROM library_staff WHERE full_name ILIKE '{aramaTextbox.Text}%'";
            else if (position.Checked)
                query = $"SELECT * FROM library_staff WHERE position ILIKE '{aramaTextbox.Text}%'";
            else if (email.Checked)
                query = $"SELECT * FROM library_staff WHERE email ILIKE '{aramaTextbox.Text}%'";
            else if (phoneNumber.Checked)
                query = $"SELECT * FROM library_staff WHERE phone_number ILIKE '{aramaTextbox.Text}%'";


            // Veri tablosu oluştur
            DataTable dataTable = new DataTable();

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, Program.databaseManager.GetConnection()))
            {
                // Verileri veri tablosuna doldur
                dataAdapter.Fill(dataTable);
            }

            // DataGridView'e veri tablosunu ata
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["staff_id"].ReadOnly = true;
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("En az bir satır seçiniz...");
            else
            {
                DialogResult result = MessageBox.Show("Seçili satırları silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Seçili tüm satırları döngü ile sil
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        string query = $"DELETE FROM library_staff WHERE staff_id = {row.Cells["staff_id"].Value};";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, Program.databaseManager.GetConnection()))
                        {
                            // Sorguyu yürüt
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                                // DataGridView'den seçili satırı kaldır
                                dataGridView1.Rows.Remove(row);
                            else
                                MessageBox.Show($"Satır silinemedi: {row.Cells["staff_id"].Value}");
                        }
                    }

                    MessageBox.Show("Seçili satırlar başarıyla silindi.");
                }
                else return;
            }
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            Ekle eklemeFormu = new Ekle(dataGridView1);
            
            eklemeFormu.Show();
        }

        private void Duzenle_Click(object sender, EventArgs e)
        {
            // Seçilen satırların ID'lerini tutmak için bir liste oluştur
            List<int> selectedIds = new List<int>();

            // DataGridView'de seçilen satırları döngü ile kontrol et
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                // DataGridView'de her satırın ID'sini alıp listeye ekle
                int id = Convert.ToInt32(row.Cells["staff_id"].Value);
                selectedIds.Add(id);
            }

            // Seçilen ID'leri içeren Duzenle formunu oluştur ve göster
            Duzenle duzenle = new Duzenle(selectedIds , dataGridView1);
            duzenle.Show();
        }




    }
}
