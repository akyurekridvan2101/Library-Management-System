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
    public partial class Duzenle : Form
    {
        List<int> id_list;
        DataGridView anaDataGridView;

        public Duzenle(List<int> id_list, DataGridView anaDataGridView)
        {
            this.id_list = id_list; // id'leri id_list'e atadık...

            InitializeComponent();
            this.anaDataGridView = anaDataGridView;
        }

        private void Duzenle_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string connectionString = "Host=localhost;Username=postgres;Password=Rdvn212121.;Database=Library";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Parametreli sorgu kullanarak SQL injection saldırılarından korunun
                string query = "SELECT staff_id , full_name , position , email , phone_number FROM library_staff WHERE staff_id = ANY(@idList)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // @idList parametresini tanımlayın ve değerini id_list'ten alın
                    command.Parameters.AddWithValue("@idList", id_list.ToArray());

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            duzenleDataGridView.DataSource = dataTable;
        }

        private void degisiklikleriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in duzenleDataGridView.Rows)
                {
                    string staffID = row.Cells["staff_id"].Value.ToString();

                    // Düzenleme sorgusu
                    string query = "UPDATE library_staff SET full_name = @full_name, position = @position, email = @email, phone_number = @phone_number WHERE staff_id = @staff_id";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, Program.databaseManager.GetConnection()))
                    {
                        // Parametreleri ayarla
                        command.Parameters.AddWithValue("@full_name", row.Cells["full_name"].Value?.ToString());
                        command.Parameters.AddWithValue("@position", row.Cells["position"].Value?.ToString());
                        command.Parameters.AddWithValue("@email", row.Cells["email"].Value?.ToString());
                        command.Parameters.AddWithValue("@phone_number", row.Cells["phone_number"].Value?.ToString());
                        command.Parameters.AddWithValue("@staff_id", Convert.ToInt32(staffID));

                        // Komutu yürüt
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Veri başarıyla güncellendi.");
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

        private void degisiklikleriSil_Click(object sender, EventArgs e) { this.Close(); }

    }
}
