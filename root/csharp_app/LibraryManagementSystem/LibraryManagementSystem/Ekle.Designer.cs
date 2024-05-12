namespace LibraryManagementSystem
{
    partial class Ekle
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
            ekleDataGridView = new DataGridView();
            degisiklikleriKaydet = new Button();
            degisiklikleriSil = new Button();
            ((System.ComponentModel.ISupportInitialize)ekleDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ekleDataGridView
            // 
            ekleDataGridView.BackgroundColor = SystemColors.Control;
            ekleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ekleDataGridView.Location = new Point(1, 1);
            ekleDataGridView.Name = "ekleDataGridView";
            ekleDataGridView.RowHeadersWidth = 51;
            ekleDataGridView.Size = new Size(837, 241);
            ekleDataGridView.TabIndex = 0;
            // 
            // degisiklikleriKaydet
            // 
            degisiklikleriKaydet.Location = new Point(191, 264);
            degisiklikleriKaydet.Name = "degisiklikleriKaydet";
            degisiklikleriKaydet.Size = new Size(179, 42);
            degisiklikleriKaydet.TabIndex = 1;
            degisiklikleriKaydet.Text = "DEĞİŞİKLİKLERİ KAYDET";
            degisiklikleriKaydet.UseVisualStyleBackColor = true;
            degisiklikleriKaydet.Click += degisiklikleriKaydet_Click;
            // 
            // degisiklikleriSil
            // 
            degisiklikleriSil.Location = new Point(474, 264);
            degisiklikleriSil.Name = "degisiklikleriSil";
            degisiklikleriSil.Size = new Size(179, 42);
            degisiklikleriSil.TabIndex = 2;
            degisiklikleriSil.Text = "DEĞİŞİKLİKLERİ SİL";
            degisiklikleriSil.UseVisualStyleBackColor = true;
            degisiklikleriSil.Click += degisiklikleriSil_Click;
            // 
            // Ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 318);
            Controls.Add(degisiklikleriSil);
            Controls.Add(degisiklikleriKaydet);
            Controls.Add(ekleDataGridView);
            Name = "Ekle";
            Text = "Form1";
            Load += Ekle_Load;
            ((System.ComponentModel.ISupportInitialize)ekleDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ekleDataGridView;
        private Button degisiklikleriKaydet;
        private Button degisiklikleriSil;
    }
}
