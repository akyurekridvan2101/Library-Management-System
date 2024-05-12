namespace LibraryManagementSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginButton = new Button();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            errorMessageLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 35);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(45, 167);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(45, 82);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 2;
            label3.Text = "USER NAME";
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            loginButton.Location = new Point(210, 227);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(102, 38);
            loginButton.TabIndex = 3;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(264, 82);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(185, 27);
            usernameTextbox.TabIndex = 4;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(264, 168);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(185, 27);
            passwordTextbox.TabIndex = 5;
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            errorMessageLabel.ForeColor = Color.Red;
            errorMessageLabel.Location = new Point(45, 208);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(0, 20);
            errorMessageLabel.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 292);
            Controls.Add(errorMessageLabel);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button loginButton;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Label errorMessageLabel;
    }
}
