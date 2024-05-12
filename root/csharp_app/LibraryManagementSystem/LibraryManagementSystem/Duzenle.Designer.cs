namespace LibraryManagementSystem
{
    partial class Duzenle
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
            degisiklikleriSil = new Button();
            degisiklikleriKaydet = new Button();
            duzenleDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)duzenleDataGridView).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            degisiklikleriSil.Location = new Point(473, 264);
            degisiklikleriSil.Name = "degisiklikleriSil";
            degisiklikleriSil.Size = new Size(179, 42);
            degisiklikleriSil.TabIndex = 5;
            degisiklikleriSil.Text = "DEĞİŞİKLİKLERİ SİL";
            degisiklikleriSil.UseVisualStyleBackColor = true;
            degisiklikleriSil.Click += degisiklikleriSil_Click;
            // 
            // button1
            // 
            degisiklikleriKaydet.Location = new Point(190, 264);
            degisiklikleriKaydet.Name = "degisiklikleriKaydet";
            degisiklikleriKaydet.Size = new Size(179, 42);
            degisiklikleriKaydet.TabIndex = 4;
            degisiklikleriKaydet.Text = "DEĞİŞİKLİKLERİ KAYDET";
            degisiklikleriKaydet.UseVisualStyleBackColor = true;
            degisiklikleriKaydet.Click += degisiklikleriKaydet_Click;
            // 
            // dataGridView1
            // 
            duzenleDataGridView.AllowUserToAddRows = false;
            duzenleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            duzenleDataGridView.BackgroundColor = SystemColors.Control;
            duzenleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            duzenleDataGridView.Location = new Point(0, 1);
            duzenleDataGridView.Name = "duzenleDataGridView";
            duzenleDataGridView.RowHeadersVisible = false;
            duzenleDataGridView.RowHeadersWidth = 51;
            duzenleDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            duzenleDataGridView.Size = new Size(837, 241);
            duzenleDataGridView.TabIndex = 3;
            // 
            // Duzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 327);
            Controls.Add(degisiklikleriSil);
            Controls.Add(degisiklikleriKaydet);
            Controls.Add(duzenleDataGridView);
            Name = "Duzenle";
            Text = "Form1";
            Load += Duzenle_Load;
            ((System.ComponentModel.ISupportInitialize)duzenleDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button degisiklikleriSil;
        private Button degisiklikleriKaydet;
        private DataGridView duzenleDataGridView;
    }
}
