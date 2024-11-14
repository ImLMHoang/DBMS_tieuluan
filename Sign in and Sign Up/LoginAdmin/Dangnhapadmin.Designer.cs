namespace Sign_in_and_Sign_Up
{
    partial class Dangnhapadmin
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtAdminName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            btLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(320, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 153);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 250);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // txtAdminName
            // 
            txtAdminName.Location = new Point(351, 243);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(295, 27);
            txtAdminName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(167, 235);
            label2.Name = "label2";
            label2.Size = new Size(88, 35);
            label2.TabIndex = 3;
            label2.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(156, 300);
            label3.Name = "label3";
            label3.Size = new Size(120, 35);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(351, 309);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(295, 27);
            txtPassword.TabIndex = 5;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.DodgerBlue;
            btLogin.Location = new Point(320, 375);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(181, 42);
            btLogin.TabIndex = 6;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // Dangnhapadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAdminName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Dangnhapadmin";
            Text = "Trangchuadmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtAdminName;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Button btLogin;
    }
}