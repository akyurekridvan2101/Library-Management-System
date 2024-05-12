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
            string username = usernameTextbox.Text; // Kullan�c� ad� alan�ndan gelen giri�
            string password = passwordTextbox.Text; // �ifre alan�ndan gelen giri�

            // Parametreize edilmi� sorgu
            string sql = "SELECT COUNT(*) FROM administrators WHERE username = @username AND password = @password";

            using (var cmd = new NpgsqlCommand(sql, Program.databaseManager.GetConnection()))
            {
                // Parametreleri ekleyin
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                    this.Close(); // Kullan�c� do�ruland�, i�lem devam edebilir.Login formu kapat�l�r ve dashboard formu a��l�r.
                else
                    errorMessageLabel.Text = "Kullan�c� ad� veya �ifre hatal�...";
            }
        }

    }
}
