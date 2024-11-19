namespace Sign_in_and_Sign_Up.Sign_Up
{
    partial class fSignUp
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btSignUp = new Button();
            btReturn = new Button();
            ckShow = new CheckBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            txtFullName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(22, 209);
            label2.Name = "label2";
            label2.Size = new Size(185, 35);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(78, 269);
            label3.Name = "label3";
            label3.Size = new Size(123, 35);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(510, 4);
            label1.Name = "label1";
            label1.Size = new Size(153, 46);
            label1.TabIndex = 4;
            label1.Text = "Đăng Ký";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(248, 209);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(510, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(248, 269);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(510, 27);
            txtPassword.TabIndex = 6;
            // 
            // btSignUp
            // 
            btSignUp.ForeColor = Color.DodgerBlue;
            btSignUp.Location = new Point(487, 433);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(210, 46);
            btSignUp.TabIndex = 7;
            btSignUp.Text = "Đăng ký";
            btSignUp.UseVisualStyleBackColor = true;
            btSignUp.Click += btSignUp_Click;
            // 
            // btReturn
            // 
            btReturn.ForeColor = Color.DodgerBlue;
            btReturn.Location = new Point(134, 441);
            btReturn.Name = "btReturn";
            btReturn.Size = new Size(210, 46);
            btReturn.TabIndex = 8;
            btReturn.Text = "Quay lại";
            btReturn.UseVisualStyleBackColor = true;
            btReturn.Click += btReturn_Click;
            // 
            // ckShow
            // 
            ckShow.AutoSize = true;
            ckShow.Checked = true;
            ckShow.CheckState = CheckState.Checked;
            ckShow.ForeColor = Color.DodgerBlue;
            ckShow.Location = new Point(818, 269);
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
            pictureBox1.Location = new Point(510, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(15, 318);
            label4.Name = "label4";
            label4.Size = new Size(189, 35);
            label4.TabIndex = 11;
            label4.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(248, 326);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(510, 27);
            txtPhoneNumber.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(70, 375);
            label5.Name = "label5";
            label5.Size = new Size(132, 35);
            label5.TabIndex = 13;
            label5.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(248, 383);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(510, 27);
            txtFullName.TabIndex = 14;
            // 
            // fSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 541);
            Controls.Add(txtFullName);
            Controls.Add(label5);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(ckShow);
            Controls.Add(btReturn);
            Controls.Add(btSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "fSignUp";
            Text = "Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        public Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btSignUp;
        private Button btReturn;
        private CheckBox ckShow;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtPhoneNumber;
        private Label label5;
        private TextBox txtFullName;
    }
}