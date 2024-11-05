namespace Sign_in_and_Sign_Up
{
    partial class fLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btLogin = new Button();
            label4 = new Label();
            lkSignUp = new LinkLabel();
            ckShow = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(12, 208);
            label2.Name = "label2";
            label2.Size = new Size(185, 35);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(71, 276);
            label3.Name = "label3";
            label3.Size = new Size(123, 35);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(216, 216);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(510, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(216, 284);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(510, 27);
            txtPassword.TabIndex = 4;
            // 
            // btLogin
            // 
            btLogin.ForeColor = Color.DodgerBlue;
            btLogin.Location = new Point(298, 348);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(210, 46);
            btLogin.TabIndex = 5;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(216, 413);
            label4.Name = "label4";
            label4.Size = new Size(217, 28);
            label4.TabIndex = 6;
            label4.Text = "Bạn chưa có tài khoản ?";
            // 
            // lkSignUp
            // 
            lkSignUp.AutoSize = true;
            lkSignUp.Font = new Font("Segoe UI", 12F);
            lkSignUp.ForeColor = Color.DodgerBlue;
            lkSignUp.LinkColor = Color.DodgerBlue;
            lkSignUp.Location = new Point(486, 413);
            lkSignUp.Name = "lkSignUp";
            lkSignUp.Size = new Size(85, 28);
            lkSignUp.TabIndex = 7;
            lkSignUp.TabStop = true;
            lkSignUp.Text = "Đăng Ký";
            lkSignUp.Click += lkSignUp_Click;
            // 
            // ckShow
            // 
            ckShow.AutoSize = true;
            ckShow.Checked = true;
            ckShow.CheckState = CheckState.Checked;
            ckShow.ForeColor = Color.DodgerBlue;
            ckShow.Location = new Point(568, 317);
            ckShow.Name = "ckShow";
            ckShow.Size = new Size(126, 24);
            ckShow.TabIndex = 9;
            ckShow.Text = "Xem mật khẩu";
            ckShow.UseVisualStyleBackColor = true;
            ckShow.CheckedChanged += ckShow_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hello_2488_256;
            pictureBox1.Location = new Point(336, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(ckShow);
            Controls.Add(lkSignUp);
            Controls.Add(label4);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fLogin";
            Text = "Đăng Nhập";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btLogin;
        private Label label4;
        private LinkLabel lkSignUp;
        private CheckBox ckShow;
        private PictureBox pictureBox1;
    }
}
