namespace Sign_in_and_Sign_Up.LoginAdmin
{
    partial class fIndex
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
            button1 = new Button();
            button2 = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(250, 47);
            label1.Name = "label1";
            label1.Size = new Size(327, 57);
            label1.TabIndex = 0;
            label1.Text = "CINEMA ADMIN";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(264, 149);
            button1.Name = "button1";
            button1.Size = new Size(300, 80);
            button1.TabIndex = 1;
            button1.Text = "Quản lý vé";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(264, 249);
            button2.Name = "button2";
            button2.Size = new Size(300, 80);
            button2.TabIndex = 2;
            button2.Text = "Quản lý lịch chiếu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DodgerBlue;
            btnLogout.Location = new Point(339, 388);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(152, 37);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // fIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "fIndex";
            Text = "Index";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button btnLogout;
    }
}