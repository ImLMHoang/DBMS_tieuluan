using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sign_in_and_Sign_Up
{
    partial class fMain
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
        private void InitializeComponent()
        {
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            pnlHangGhe = new Panel();
            comboBoxShowtime = new ComboBox();
            textBoxSeatNumber = new TextBox();
            buttonSave = new Button();
            labelTime = new Label();
            labelGhe = new Label();
            btnViewBookingDetails = new Button();
            btnBack = new Button();

            //TextBox CHỈ HIỂN THỊ TÊN PHIM
            txtMovieTitle = new TextBox();
            txtMovieTitle.Location = new Point(20, 20);
            txtMovieTitle.Size = new Size(300, 30);
            txtMovieTitle.ReadOnly = true;
            Controls.Add(txtMovieTitle);

            SuspendLayout();

            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(15, 15);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(930, 104);
            tableLayoutPanel2.TabIndex = 1;

            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(922, 104);
            label1.TabIndex = 0;
            label1.Text = "MÀN ẢNH";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // pnlHangGhe
            // 
            pnlHangGhe.Location = new Point(19, 122);
            pnlHangGhe.Margin = new Padding(4);
            pnlHangGhe.Name = "pnlHangGhe";
            pnlHangGhe.Size = new Size(926, 494);
            pnlHangGhe.TabIndex = 2;
            pnlHangGhe.Paint += pnlHangGhe_Paint;

            // 
            // comboBoxShowtime
            // 
            comboBoxShowtime.FormattingEnabled = true;
            comboBoxShowtime.Location = new Point(1228, 478);
            comboBoxShowtime.Margin = new Padding(4);
            comboBoxShowtime.Name = "comboBoxShowtime";
            comboBoxShowtime.Size = new Size(419, 33);
            comboBoxShowtime.TabIndex = 10;
            comboBoxShowtime.Visible = true;

            // 
            // textBoxSeatNumber
            // 
            textBoxSeatNumber.Font = new Font("Segoe UI", 15F);
            textBoxSeatNumber.Location = new Point(1228, 540);
            textBoxSeatNumber.Margin = new Padding(4);
            textBoxSeatNumber.Multiline = true;
            textBoxSeatNumber.Name = "textBoxSeatNumber";
            textBoxSeatNumber.ReadOnly = true;
            textBoxSeatNumber.Size = new Size(113, 56);
            textBoxSeatNumber.TabIndex = 11;
            textBoxSeatNumber.Visible = true;

            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Location = new Point(1228, 650);
            buttonSave.Margin = new Padding(4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(290, 50);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Lưu";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;

            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(972, 481);
            labelTime.Margin = new Padding(4, 0, 4, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(202, 25);
            labelTime.TabIndex = 14;
            labelTime.Text = "Chọn suất chiếu và thời gian:";
            labelTime.Visible = true;

            // 
            // labelGhe
            // 
            labelGhe.AutoSize = true;
            labelGhe.Location = new Point(1045, 559);
            labelGhe.Margin = new Padding(4, 0, 4, 0);
            labelGhe.Name = "labelGhe";
            labelGhe.Size = new Size(126, 25);
            labelGhe.TabIndex = 15;
            labelGhe.Text = "Ghế bạn chọn:";
            labelGhe.Visible = true;

            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 650);
            btnBack.Size = new Size(100, 30);
            btnBack.Text = "Quay về";
            btnBack.Click += BtnBack_Click;
            Controls.Add(btnBack);

            // 
            // btnViewBookingDetails
            // 
            btnViewBookingDetails.Size = new Size(290, 50);
            btnViewBookingDetails.Location = new Point(1228, 20);
            btnViewBookingDetails.Text = "Xem Chi Tiết Đặt Vé";
            btnViewBookingDetails.Click += BtnViewBookingDetails_Click;
            Controls.Add(btnViewBookingDetails);

            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1716, 816);
            Controls.Add(labelGhe);
            Controls.Add(labelTime);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSeatNumber);
            Controls.Add(comboBoxShowtime);
            Controls.Add(pnlHangGhe);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fMain";
            Text = "Form1";
            Load += fMain_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Panel pnlHangGhe;
        private ComboBox comboBoxShowtime;
        private TextBox textBoxSeatNumber;
        private Button buttonSave;
        private Label labelTime;
        private Label labelGhe;
        private TextBox txtMovieTitle;
        private Button btnViewBookingDetails;
        private Button btnBack;

        //Vẽ bảng ghế
        private void pnlHangGhe_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
