using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text; // Kullanýcý adý alanýndan gelen giriþ
            string password = passwordTextbox.Text; // Þifre alanýndan gelen giriþ

            // Parametreize edilmiþ sorgu
            string sql = "SELECT COUNT(*) FROM administrators WHERE username = @username AND password = @password";

            using (var cmd = new NpgsqlCommand(sql, Program.databaseManager.GetConnection()))
            {
                // Parametreleri ekleyin
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                    this.Close(); // Kullanýcý doðrulandý, iþlem devam edebilir.Login formu kapatýlýr ve dashboard formu açýlýr.
                else
                    errorMessageLabel.Text = "Kullanýcý adý veya þifre hatalý...";
            }
        }

    }
}
