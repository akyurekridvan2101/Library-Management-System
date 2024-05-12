namespace LibraryManagementSystem
{
    partial class Dashboard
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
            label1 = new Label();
            label2 = new Label();
            kitapIslemleri = new Button();
            personelIslemleri = new Button();
            oduncIslemleri = new Button();
            yoneticiIslemleri = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(183, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 35);
            label1.TabIndex = 7;
            label1.Text = "DASHBOARD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 8;
            label2.Text = "admin statüsü";
            // 
            // kitapIslemleri
            // 
            kitapIslemleri.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kitapIslemleri.Location = new Point(58, 98);
            kitapIslemleri.Name = "kitapIslemleri";
            kitapIslemleri.Size = new Size(168, 47);
            kitapIslemleri.TabIndex = 9;
            kitapIslemleri.Text = "Kitap İşlemleri";
            kitapIslemleri.UseVisualStyleBackColor = true;
            // 
            // personelIslemleri
            // 
            personelIslemleri.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            personelIslemleri.Location = new Point(313, 98);
            personelIslemleri.Name = "personelIslemleri";
            personelIslemleri.Size = new Size(171, 47);
            personelIslemleri.TabIndex = 10;
            personelIslemleri.Text = "Personel İşlemleri";
            personelIslemleri.UseVisualStyleBackColor = true;
            personelIslemleri.Click += personelIslemleri_Click;
            // 
            // oduncIslemleri
            // 
            oduncIslemleri.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oduncIslemleri.Location = new Point(58, 185);
            oduncIslemleri.Name = "oduncIslemleri";
            oduncIslemleri.Size = new Size(168, 47);
            oduncIslemleri.TabIndex = 11;
            oduncIslemleri.Text = "Ödünç İşlemleri";
            oduncIslemleri.UseVisualStyleBackColor = true;
            // 
            // yoneticiIslemleri
            // 
            yoneticiIslemleri.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            yoneticiIslemleri.Location = new Point(313, 185);
            yoneticiIslemleri.Name = "yoneticiIslemleri";
            yoneticiIslemleri.Size = new Size(171, 47);
            yoneticiIslemleri.TabIndex = 12;
            yoneticiIslemleri.Text = "Yönetici İşlemleri";
            yoneticiIslemleri.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 269);
            Controls.Add(yoneticiIslemleri);
            Controls.Add(oduncIslemleri);
            Controls.Add(personelIslemleri);
            Controls.Add(kitapIslemleri);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button kitapIslemleri;
        private Button personelIslemleri;
        private Button oduncIslemleri;
        private Button yoneticiIslemleri;
    }
}
