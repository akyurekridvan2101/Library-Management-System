using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        Button yesilButon;
        public Login()
        {
            InitializeComponent();
            TabloyuGuncelle();

            for (int i = 0; i < mainDataGridView.Columns.Count; i++)
                referansSutun.Items.Add(mainDataGridView.Columns[i].Name);

            referansSutun.Text = mainDataGridView.Columns[0].Name;
            this.yesilButon = kitapIslemleri;

            this.Size = loginPanel.Size; //default olarak...
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text; // Kullanıcı adı alanından gelen giriş
            string password = passwordTextBox.Text; // Şifre alanından gelen giriş

            string sql = "SELECT COUNT(*) FROM administrators WHERE username = @username AND password = @password";

            using (var cmd = new SqlCommand(sql, Program.databaseManager.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    Program.loginBool = true;
                    loginPanel.Visible = false;
                    dashboardPanel.Visible = true;
                    this.Size = dashboardPanel.Size;
                    dashboardPanel.Location = new Point(0, 0);

                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
                else
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı...");
            }
        }

        private void exitLabel_Click(object sender, EventArgs e) { this.Close(); }

        private void clearFieldsLabel_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void Login_SizeChanged(object sender, EventArgs e) { this.CenterToScreen(); }


        private void kitapIslemleri_Click(object sender, EventArgs e)
        {
            if (kitapIslemleri.BackColor == Color.Green)
                return;
            else
            {
                this.yesilButon.BackColor = Color.DeepSkyBlue;
                this.yesilButon = kitapIslemleri;
                this.yesilButon.BackColor = Color.Green;

                referansSutun.Items.Clear();
                referansSutun.Items.AddRange(new string[] { "book_id", "book_title", "genre", "publisher", "publication_date", "language", "isbn" });

                referansSutun.Text = (string)referansSutun.Items[0];

                TabloyuGuncelle();
            }
        }

        private void oduncIslemleri_Click(object sender, EventArgs e)
        {
            if (oduncIslemleri.BackColor == Color.Green)
                return;
            else
            {
                this.yesilButon.BackColor = Color.DeepSkyBlue;
                this.yesilButon = oduncIslemleri;
                this.yesilButon.BackColor = Color.Green;

                referansSutun.Items.Clear();
                referansSutun.Items.AddRange(new string[] { "loan_id", "book_id", "member_id", "loan_date", "return_date", "fine_amount" });

                referansSutun.Text = (string)referansSutun.Items[0];

                TabloyuGuncelle();
            }
        }

        private void personelIslemleri_Click(object sender, EventArgs e)
        {
            if (personelIslemleri.BackColor == Color.Green)
                return;
            else
            {
                this.yesilButon.BackColor = Color.DeepSkyBlue;
                this.yesilButon = personelIslemleri;
                this.yesilButon.BackColor = Color.Green;

                referansSutun.Items.Clear();
                referansSutun.Items.AddRange(new string[] { "staff_id", "full_name", "position", "email", "phone_number" });

                referansSutun.Text = (string)referansSutun.Items[0];

                TabloyuGuncelle();
            }
        }

        private void adminIslemleri_Click(object sender, EventArgs e)
        {

            if (adminIslemleri.BackColor == Color.Green)
                return;
            else
            {
                this.yesilButon.BackColor = Color.DeepSkyBlue;
                this.yesilButon = adminIslemleri;
                this.yesilButon.BackColor = Color.Green;

                referansSutun.Items.Clear();
                referansSutun.Items.AddRange(new string[] { "admin_id", "username", "password", "full_name", "email", "phone_number", "role" });

                referansSutun.Text = (string)referansSutun.Items[0];

                TabloyuGuncelle();
            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Kapat", null, Secenek1_Click);
            contextMenuStrip.Items.Add("Çıkış yap", null, Secenek2_Click);

            int x = 65;
            int y = 660;

            contextMenuStrip.Show(loginButton.Parent, new Point(x, y));
        }
        private void Secenek1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Secenek2_Click(object sender, EventArgs e)
        {
            dashboardPanel.Visible = false;
            loginPanel.Visible = true;
            this.Size = loginPanel.Size;
            loginPanel.Location = new Point(0, 0);

        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("En az bir satır seçiniz...");
                return;
            }

            DialogResult result = MessageBox.Show("Seçili satırları silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            bool hataVerdiMi = false;
            List<object> silineceklerin_IDleri = new List<object>();

            foreach (DataGridViewRow row in mainDataGridView.SelectedRows)
                silineceklerin_IDleri.Add(row.Cells[mainDataGridView.Columns[0].Name].Value);

            try
            {
                string values = string.Join(",", silineceklerin_IDleri.Select(v => $"'{v}'"));
                string query = $"DELETE FROM {SecilenTablo()} WHERE {mainDataGridView.Columns[0].Name} IN ({values});";

                using (SqlCommand command = new SqlCommand(query, Program.databaseManager.GetConnection()))
                {
                    command.ExecuteNonQuery();

                    foreach (DataGridViewRow row in mainDataGridView.SelectedRows)
                    {
                        mainDataGridView.Rows.Remove(row);
                    }

                    MessageBox.Show($"Seçili satırlar başarıyla silindi.");
                }
            }
            catch (SqlException ex)
            {
                hataVerdiMi = true;
                MessageBox.Show($"Hata oluştu: Bu silme işlemindeki satırlardan bir veya birden fazlası tablolar arasındaki bütünlüğü ihlal ettiği için satırlar silinemedi...");
            }
            catch (Exception ex)
            {
                hataVerdiMi = true;
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {

        }

        private void duzenle_Click(object sender, EventArgs e)
        {

        }

        private void aramaTextbox_TextChanged(object sender, EventArgs e)
        {
            TabloyuGuncelle();
        }

        private void referansSutun_Changed(object sender, EventArgs e)
        {
            TabloyuGuncelle();
        }

        private void TabloyuGuncelle()
        {
            string query;

            if (aramaTextbox.Text == "")
                query = $"SELECT * FROM {SecilenTablo()};";
            else
                query = $"SELECT * FROM {SecilenTablo()} WHERE CAST({referansSutun.SelectedItem} AS VARCHAR) LIKE '{aramaTextbox.Text}%'";

            DataTable dataTable = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Program.databaseManager.GetConnection()))
            {
                dataAdapter.Fill(dataTable);
            }

            mainDataGridView.DataSource = dataTable;
        }

        private string SecilenTablo()
        {
            if (kitapIslemleri.BackColor == Color.Green)
                return "books";
            else if (oduncIslemleri.BackColor == Color.Green)
                return "loans";
            else if (personelIslemleri.BackColor == Color.Green)
                return "library_staff";
            else
                return "administrators";
        }
    }
}
