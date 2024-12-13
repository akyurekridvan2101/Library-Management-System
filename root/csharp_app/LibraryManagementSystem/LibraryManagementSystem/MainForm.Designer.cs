namespace LibraryManagementSystem
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            loginPanel = new Panel();
            exitLabel = new Label();
            loginButton = new Button();
            clearFieldsLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            dashboardPanel = new Panel();
            aksiyonlarPaneli = new Panel();
            referansSutun = new ComboBox();
            ekle = new Button();
            duzenle = new Button();
            sil = new Button();
            mainDataGridView = new DataGridView();
            aramaTextbox = new MaskedTextBox();
            tercihlerPaneli = new Panel();
            logoutButton = new Button();
            pictureBox4 = new PictureBox();
            kitapIslemleri = new Button();
            oduncIslemleri = new Button();
            personelIslemleri = new Button();
            adminIslemleri = new Button();
            uyeIslemleri = new Button();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            dashboardPanel.SuspendLayout();
            aksiyonlarPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).BeginInit();
            tercihlerPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(exitLabel);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(clearFieldsLabel);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(usernameTextBox);
            loginPanel.Controls.Add(pictureBox3);
            loginPanel.Controls.Add(panel2);
            loginPanel.Controls.Add(pictureBox2);
            loginPanel.Controls.Add(panel1);
            loginPanel.Controls.Add(pictureBox1);
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(351, 491);
            loginPanel.TabIndex = 0;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exitLabel.ForeColor = Color.DeepSkyBlue;
            exitLabel.Location = new Point(158, 434);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(41, 20);
            exitLabel.TabIndex = 20;
            exitLabel.Text = "Exit";
            exitLabel.Click += exitLabel_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DeepSkyBlue;
            loginButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(30, 375);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(296, 42);
            loginButton.TabIndex = 19;
            loginButton.Text = "LOG IN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // clearFieldsLabel
            // 
            clearFieldsLabel.AutoSize = true;
            clearFieldsLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            clearFieldsLabel.ForeColor = Color.DeepSkyBlue;
            clearFieldsLabel.Location = new Point(215, 341);
            clearFieldsLabel.Name = "clearFieldsLabel";
            clearFieldsLabel.Size = new Size(111, 20);
            clearFieldsLabel.TabIndex = 18;
            clearFieldsLabel.Text = "Clear Fields";
            clearFieldsLabel.Click += clearFieldsLabel_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            passwordTextBox.ForeColor = Color.DeepSkyBlue;
            passwordTextBox.Location = new Point(61, 292);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(265, 34);
            passwordTextBox.TabIndex = 17;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            usernameTextBox.ForeColor = Color.DeepSkyBlue;
            usernameTextBox.Location = new Point(66, 186);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(260, 34);
            usernameTextBox.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 292);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Location = new Point(30, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 1);
            panel2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 186);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Location = new Point(30, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 1);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Controls.Add(aksiyonlarPaneli);
            dashboardPanel.Controls.Add(tercihlerPaneli);
            dashboardPanel.Location = new Point(357, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1339, 776);
            dashboardPanel.TabIndex = 31;
            dashboardPanel.Visible = false;
            // 
            // aksiyonlarPaneli
            // 
            aksiyonlarPaneli.BackColor = SystemColors.Window;
            aksiyonlarPaneli.Controls.Add(referansSutun);
            aksiyonlarPaneli.Controls.Add(ekle);
            aksiyonlarPaneli.Controls.Add(duzenle);
            aksiyonlarPaneli.Controls.Add(sil);
            aksiyonlarPaneli.Controls.Add(mainDataGridView);
            aksiyonlarPaneli.Controls.Add(aramaTextbox);
            aksiyonlarPaneli.Location = new Point(279, 0);
            aksiyonlarPaneli.Name = "aksiyonlarPaneli";
            aksiyonlarPaneli.Size = new Size(1060, 776);
            aksiyonlarPaneli.TabIndex = 15;
            // 
            // referansSutun
            // 
            referansSutun.DropDownStyle = ComboBoxStyle.DropDownList;
            referansSutun.FormattingEnabled = true;
            referansSutun.Location = new Point(295, 37);
            referansSutun.Name = "referansSutun";
            referansSutun.Size = new Size(215, 28);
            referansSutun.TabIndex = 0;
            // 
            // ekle
            // 
            ekle.Location = new Point(511, 699);
            ekle.Name = "ekle";
            ekle.Size = new Size(91, 45);
            ekle.TabIndex = 23;
            ekle.Text = "EKLE";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            // 
            // duzenle
            // 
            duzenle.Location = new Point(709, 699);
            duzenle.Name = "duzenle";
            duzenle.Size = new Size(91, 45);
            duzenle.TabIndex = 22;
            duzenle.Text = "DÜZENLE";
            duzenle.UseVisualStyleBackColor = true;
            duzenle.Click += duzenle_Click;
            // 
            // sil
            // 
            sil.Location = new Point(327, 699);
            sil.Name = "sil";
            sil.Size = new Size(91, 45);
            sil.TabIndex = 21;
            sil.Text = "SİL";
            sil.UseVisualStyleBackColor = true;
            sil.Click += sil_Click;
            // 
            // mainDataGridView
            // 
            mainDataGridView.AllowUserToAddRows = false;
            mainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainDataGridView.BackgroundColor = Color.White;
            mainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainDataGridView.GridColor = Color.Black;
            mainDataGridView.Location = new Point(21, 88);
            mainDataGridView.Name = "mainDataGridView";
            mainDataGridView.ReadOnly = true;
            mainDataGridView.RowHeadersVisible = false;
            mainDataGridView.RowHeadersWidth = 51;
            mainDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainDataGridView.Size = new Size(1021, 582);
            mainDataGridView.TabIndex = 16;
            // 
            // aramaTextbox
            // 
            aramaTextbox.Location = new Point(567, 37);
            aramaTextbox.Name = "aramaTextbox";
            aramaTextbox.Size = new Size(215, 27);
            aramaTextbox.TabIndex = 15;
            aramaTextbox.TextChanged += aramaTextbox_TextChanged;
            // 
            // tercihlerPaneli
            // 
            tercihlerPaneli.BackColor = Color.DeepSkyBlue;
            tercihlerPaneli.Controls.Add(uyeIslemleri);
            tercihlerPaneli.Controls.Add(logoutButton);
            tercihlerPaneli.Controls.Add(pictureBox4);
            tercihlerPaneli.Controls.Add(kitapIslemleri);
            tercihlerPaneli.Controls.Add(oduncIslemleri);
            tercihlerPaneli.Controls.Add(personelIslemleri);
            tercihlerPaneli.Controls.Add(adminIslemleri);
            tercihlerPaneli.Location = new Point(0, 0);
            tercihlerPaneli.Name = "tercihlerPaneli";
            tercihlerPaneli.Size = new Size(281, 776);
            tercihlerPaneli.TabIndex = 29;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.DeepSkyBlue;
            logoutButton.BackgroundImageLayout = ImageLayout.Center;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.ForeColor = SystemColors.ControlText;
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.Location = new Point(12, 706);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(56, 51);
            logoutButton.TabIndex = 30;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(60, 112);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(148, 133);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // kitapIslemleri
            // 
            kitapIslemleri.BackColor = Color.Green;
            kitapIslemleri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kitapIslemleri.Location = new Point(33, 280);
            kitapIslemleri.Name = "kitapIslemleri";
            kitapIslemleri.Size = new Size(215, 45);
            kitapIslemleri.TabIndex = 24;
            kitapIslemleri.Text = "KİTAP İŞLEMLERİ";
            kitapIslemleri.UseVisualStyleBackColor = false;
            kitapIslemleri.Click += kitapIslemleri_Click;
            // 
            // oduncIslemleri
            // 
            oduncIslemleri.BackColor = Color.DeepSkyBlue;
            oduncIslemleri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oduncIslemleri.Location = new Point(33, 360);
            oduncIslemleri.Name = "oduncIslemleri";
            oduncIslemleri.Size = new Size(215, 45);
            oduncIslemleri.TabIndex = 27;
            oduncIslemleri.Text = "ÖDÜNÇ İŞLEMLERİ";
            oduncIslemleri.UseVisualStyleBackColor = false;
            oduncIslemleri.Click += oduncIslemleri_Click;
            // 
            // personelIslemleri
            // 
            personelIslemleri.BackColor = Color.DeepSkyBlue;
            personelIslemleri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            personelIslemleri.Location = new Point(33, 440);
            personelIslemleri.Name = "personelIslemleri";
            personelIslemleri.Size = new Size(215, 45);
            personelIslemleri.TabIndex = 26;
            personelIslemleri.Text = "PERSONEL İŞLEMLERİ";
            personelIslemleri.UseVisualStyleBackColor = false;
            personelIslemleri.Click += personelIslemleri_Click;
            // 
            // adminIslemleri
            // 
            adminIslemleri.BackColor = Color.DeepSkyBlue;
            adminIslemleri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            adminIslemleri.Location = new Point(33, 520);
            adminIslemleri.Name = "adminIslemleri";
            adminIslemleri.Size = new Size(215, 45);
            adminIslemleri.TabIndex = 25;
            adminIslemleri.Text = "YÖNETİCİ İŞLEMLERİ";
            adminIslemleri.UseVisualStyleBackColor = false;
            adminIslemleri.Click += adminIslemleri_Click;
            // 
            // uyeIslemleri
            // 
            uyeIslemleri.BackColor = Color.DeepSkyBlue;
            uyeIslemleri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            uyeIslemleri.Location = new Point(33, 600);
            uyeIslemleri.Name = "uyeIslemleri";
            uyeIslemleri.Size = new Size(215, 45);
            uyeIslemleri.TabIndex = 31;
            uyeIslemleri.Text = "ÜYE İŞLEMLERİ";
            uyeIslemleri.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1750, 826);
            Controls.Add(dashboardPanel);
            Controls.Add(loginPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOG IN";
            SizeChanged += Login_SizeChanged;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            dashboardPanel.ResumeLayout(false);
            aksiyonlarPaneli.ResumeLayout(false);
            aksiyonlarPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).EndInit();
            tercihlerPaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Label exitLabel;
        private Button loginButton;
        private Label clearFieldsLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel dashboardPanel;
        private Panel aksiyonlarPaneli;
        private ComboBox referansSutun;
        private Button ekle;
        private Button duzenle;
        private Button sil;
        private DataGridView mainDataGridView;
        private MaskedTextBox aramaTextbox;
        private Panel tercihlerPaneli;
        private Button logoutButton;
        private PictureBox pictureBox4;
        private Button kitapIslemleri;
        private Button oduncIslemleri;
        private Button personelIslemleri;
        private Button adminIslemleri;
        private Button uyeIslemleri;
    }
}