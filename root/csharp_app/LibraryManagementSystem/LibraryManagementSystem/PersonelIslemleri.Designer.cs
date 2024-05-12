namespace LibraryManagementSystem
{
    partial class PersonelIslemleri
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
            aramaTextbox = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            fullName = new RadioButton();
            position = new RadioButton();
            email = new RadioButton();
            phoneNumber = new RadioButton();
            sil = new Button();
            duzenle = new Button();
            ekle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // aramaTextbox
            // 
            aramaTextbox.Location = new Point(235, 70);
            aramaTextbox.Name = "aramaTextbox";
            aramaTextbox.Size = new Size(357, 27);
            aramaTextbox.TabIndex = 5;
            aramaTextbox.TextChanged += aramaTextbox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(811, 471);
            dataGridView1.TabIndex = 6;
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.Checked = true;
            fullName.Location = new Point(217, 27);
            fullName.Name = "fullName";
            fullName.Size = new Size(94, 24);
            fullName.TabIndex = 8;
            fullName.TabStop = true;
            fullName.Text = "full_name";
            fullName.UseVisualStyleBackColor = true;
            // 
            // position
            // 
            position.AutoSize = true;
            position.Location = new Point(317, 27);
            position.Name = "position";
            position.Size = new Size(84, 24);
            position.TabIndex = 10;
            position.TabStop = true;
            position.Text = "position";
            position.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(407, 27);
            email.Name = "email";
            email.Size = new Size(67, 24);
            email.TabIndex = 9;
            email.TabStop = true;
            email.Text = "email";
            email.UseVisualStyleBackColor = true;
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Location = new Point(480, 27);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(129, 24);
            phoneNumber.TabIndex = 11;
            phoneNumber.TabStop = true;
            phoneNumber.Text = "phone_number";
            phoneNumber.UseVisualStyleBackColor = true;
            // 
            // sil
            // 
            sil.Location = new Point(171, 611);
            sil.Name = "sil";
            sil.Size = new Size(94, 54);
            sil.TabIndex = 12;
            sil.Text = "SİL";
            sil.UseVisualStyleBackColor = true;
            sil.Click += Sil_Click;
            // 
            // duzenle
            // 
            duzenle.Location = new Point(553, 611);
            duzenle.Name = "duzenle";
            duzenle.Size = new Size(94, 54);
            duzenle.TabIndex = 13;
            duzenle.Text = "DÜZENLE";
            duzenle.UseVisualStyleBackColor = true;
            duzenle.Click += Duzenle_Click;
            // 
            // ekle
            // 
            ekle.Location = new Point(355, 611);
            ekle.Name = "ekle";
            ekle.Size = new Size(94, 54);
            ekle.TabIndex = 14;
            ekle.Text = "EKLE";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += Ekle_Click;
            // 
            // PersonelIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 677);
            Controls.Add(ekle);
            Controls.Add(duzenle);
            Controls.Add(sil);
            Controls.Add(phoneNumber);
            Controls.Add(position);
            Controls.Add(email);
            Controls.Add(fullName);
            Controls.Add(dataGridView1);
            Controls.Add(aramaTextbox);
            Name = "PersonelIslemleri";
            Text = "PersonelIslemleri";
            Load += PersonelIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox aramaTextbox;
        private DataGridView dataGridView1;
        private RadioButton fullName;
        private RadioButton position;
        private RadioButton email;
        private RadioButton phoneNumber;
        private Button sil;
        private Button duzenle;
        private Button ekle;
    }
}