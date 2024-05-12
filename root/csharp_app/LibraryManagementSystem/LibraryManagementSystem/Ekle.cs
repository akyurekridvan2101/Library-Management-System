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
    public partial class Ekle : Form
    {
        DataGridView anaDataGridView;
        public Ekle(DataGridView anaDataGridView)
        {
            this.anaDataGridView = anaDataGridView;

            InitializeComponent();
        }

        public void Ekle_Load(object sender, EventArgs e)
        {
            // Verilerimize göre boş bir tablo oluşturuyoruz.
            string query = "SELECT 'full_name' AS full_name, 'position' AS position, 'email' AS email, 'phone_number' AS phone_number WHERE false;";

            DataTable dataTable = new DataTable();// Veri tablosu oluştur

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, Program.databaseManager.GetConnection()))
                dataAdapter.Fill(dataTable);// Verileri veri tablosuna doldur

            ekleDataGridView.DataSource = dataTable;// DataGridView'e veri tablosunu ata
        }

        public void degisiklikleriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in ekleDataGridView.Rows)
                    if (!row.IsNewRow)
                    {
                        string full_name = row.Cells["full_name"].Value?.ToString();
                        string position = row.Cells["position"].Value?.ToString();
                        string email = row.Cells["email"].Value?.ToString();
                        string phone_number = row.Cells["phone_number"].Value?.ToString();

                        string query = "INSERT INTO library_staff (full_name, position, email, phone_number) VALUES (@full_name, @position, @email, @phone_number)";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, Program.databaseManager.GetConnection()))
                        {
                            command.Parameters.AddWithValue("@full_name", full_name);
                            command.Parameters.AddWithValue("@position", position);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@phone_number", phone_number);

                            command.ExecuteNonQuery();
                        }
                    }

                MessageBox.Show("Veriler başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

            // Veri çekme sorgusu
            string komut = "SELECT * FROM library_staff ORDER BY staff_id";

            // Veri tablosu oluştur
            DataTable dataTable = new DataTable();

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(komut, Program.databaseManager.GetConnection()))
                dataAdapter.Fill(dataTable);// Verileri veri tablosuna doldur

            anaDataGridView.DataSource = dataTable;// DataGridView'e veri tablosunu ata

            this.Close();
        }

        public void degisiklikleriSil_Click(object sender, EventArgs e) { this.Close(); }

    }
}
