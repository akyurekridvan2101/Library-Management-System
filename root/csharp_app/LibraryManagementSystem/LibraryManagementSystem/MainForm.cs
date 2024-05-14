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

            this.Size = loginPanel.Size;//default olarak...
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text; // Kullanıcı adı alanından gelen giriş
            string password = passwordTextBox.Text; // Şifre alanından gelen giriş

            string sql = "SELECT COUNT(*) FROM administrators WHERE username = @username AND password = @password";

            using (var cmd = new NpgsqlCommand(sql, Program.databaseManager.GetConnection()))
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
                // aramaTextbox.Text = "";//Her buton değiştirildiğinde arama kısmındaki yazı sıfırlanacak.
                this.yesilButon.BackColor = Color.DeepSkyBlue;
                this.yesilButon = kitapIslemleri;
                this.yesilButon.BackColor = Color.Green;

                //comboboxları da değiştiriyoruz.Alttaki fonksiyonun üstünde olmazsa comboboxtan gelen id diğer tabloda olmadığı için hata verir.
                referansSutun.Items.Clear();//Önceki itemleri siliyoruz.
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
                // aramaTextbox.Text = "";//Her buton değiştirildiğinde arama kısmındaki yazı sıfırlanacak.
                this.yesilButon.BackColor = Color.DeepSkyBlue;
                this.yesilButon = oduncIslemleri;
                this.yesilButon.BackColor = Color.Green;

                //comboboxları da değiştiriyoruz.Alttaki fonksiyonun üstünde olmazsa comboboxtan gelen id diğer tabloda olmadığı için hata verir.
                referansSutun.Items.Clear();//Önceki itemleri siliyoruz.
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
                // aramaTextbox.Text = "";//Her buton değiştirildiğinde arama kısmındaki yazı sıfırlanacak.
                this.yesilButon.BackColor = Color.DeepSkyBlue;
                this.yesilButon = personelIslemleri;
                this.yesilButon.BackColor = Color.Green;

                //comboboxları da değiştiriyoruz.Alttaki fonksiyonun üstünde olmazsa comboboxtan gelen id diğer tabloda olmadığı için hata verir.
                referansSutun.Items.Clear();//Önceki itemleri siliyoruz.
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
                // aramaTextbox.Text = "";//Her buton değiştirildiğinde arama kısmındaki yazı sıfırlanacak.

                this.yesilButon.BackColor = Color.DeepSkyBlue;// eski butonun rengini default yaptık.
                this.yesilButon = adminIslemleri;
                this.yesilButon.BackColor = Color.Green;

                //comboboxları da değiştiriyoruz.Alttaki fonksiyonun üstünde olmazsa comboboxtan gelen id diğer tabloda olmadığı için hata verir.
                referansSutun.Items.Clear();//Önceki itemleri siliyoruz.
                referansSutun.Items.AddRange(new string[] { "admin_id", "username", "password", "full_name", "email", "phone_number", "role" });

                referansSutun.Text = (string)referansSutun.Items[0];

                TabloyuGuncelle();
            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Butonun sağında 10 piksel mesafe bırakarak dinamik olarak bir ContextMenuStrip oluştur ve göster
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Kapat", null, Secenek1_Click);
            contextMenuStrip.Items.Add("Çıkış yap", null, Secenek2_Click);

            // Butonun sağında bir mesafe belirlemek için butonun sağ üst köşesinin X ve Y koordinatlarını kullanın
            int x = 65; // Butonun sağında 10 piksel mesafe
            int y = 660; // Butonun yüksekliği boyunca

            // Belirlediğimiz konumu kullanarak menüyü göster
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

            // Seçili satırların değerlerini topla
            foreach (DataGridViewRow row in mainDataGridView.SelectedRows)
                silineceklerin_IDleri.Add(row.Cells[mainDataGridView.Columns[0].Name].Value);

            try
            {
                // Sorguyu oluştur
                string values = string.Join(",", silineceklerin_IDleri.Select(v => $"'{v}'"));
                string query = $"DELETE FROM {SecilenTablo()} WHERE {mainDataGridView.Columns[0].Name} IN ({values});";

                using (NpgsqlCommand command = new NpgsqlCommand(query, Program.databaseManager.GetConnection()))
                {
                    // Sorguyu yürüt
                    command.ExecuteNonQuery();

                    // Başarılı olanları DataGridView'den kaldır
                    foreach (DataGridViewRow row in mainDataGridView.SelectedRows)
                    {
                        mainDataGridView.Rows.Remove(row);
                    }

                    MessageBox.Show($"Seçili satırlar başarıyla silindi.");
                }
            }
            catch (Npgsql.PostgresException ex)
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

            //Burada boiş ise tümünü getirsin,boştan farklı ise stringe cast edip ILIKE(Dikkat LIKE değil) operatörünü kullanıp veri getirsin dedik.
            if (aramaTextbox.Text == "")
                query = $"SELECT * FROM {SecilenTablo()};";//Boş ise tüm satırlar gelir.
            else
                query = $"SELECT * FROM {SecilenTablo()} WHERE CAST({referansSutun.SelectedItem} AS TEXT) ILIKE '{aramaTextbox.Text}%'";



            // Veri tablosu oluştur
            DataTable dataTable = new DataTable();

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, Program.databaseManager.GetConnection()))
            {
                // Verileri veri tablosuna doldur
                dataAdapter.Fill(dataTable);
            }

            // DataGridView'e veri tablosunu ata
            mainDataGridView.DataSource = dataTable;
            //mainDataGridView.Columns["staff_id"].ReadOnly = true;
        }

        private string SecilenTablo()
        {
            if (kitapIslemleri.BackColor == Color.Green)
                return "books";// Kitaplar tablosu
            else if (oduncIslemleri.BackColor == Color.Green)
                return "loans";// Ödünçler tablosu
            else if (personelIslemleri.BackColor == Color.Green)
                return "library_staff";//Kütüphane Çalışanları tablosu
            else
                return "administrators";
        }
        
    }
}
