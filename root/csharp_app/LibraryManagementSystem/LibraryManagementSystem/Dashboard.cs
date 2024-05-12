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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void personelIslemleri_Click(object sender, EventArgs e)
        {
            // Yeni bir PersonelIslemleri formu oluştur
            PersonelIslemleri personelIslemi = new PersonelIslemleri();

            // Oluşturulan formu göster
            personelIslemi.Show();
        }

    }
}
