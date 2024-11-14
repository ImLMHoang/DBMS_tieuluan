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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(279, 128);
            label1.Name = "label1";
            label1.Size = new Size(265, 46);
            label1.TabIndex = 0;
            label1.Text = "CINEMA ADMIN";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(88, 222);
            button1.Name = "button1";
            button1.Size = new Size(296, 66);
            button1.TabIndex = 1;
            button1.Text = "Quản lý vé";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(428, 222);
            button2.Name = "button2";
            button2.Size = new Size(295, 66);
            button2.TabIndex = 2;
            button2.Text = "Quản lý lịch chiếu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // fIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}