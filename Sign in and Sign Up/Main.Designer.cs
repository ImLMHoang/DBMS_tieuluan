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
            STT = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            SeatNumber = new DataGridViewTextBoxColumn();
            BookingTime = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            pnlHangGhe = new Panel();
            textBoxName = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBoxShowtime = new ComboBox();
            textBoxSeatNumber = new TextBox();
            buttonSave = new Button();
            labelName = new Label();
            labelTime = new Label();
            labelGhe = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.Width = 50;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Người mua";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 150;
            // 
            // SeatNumber
            // 
            SeatNumber.HeaderText = "Số ghế";
            SeatNumber.MinimumWidth = 6;
            SeatNumber.Name = "SeatNumber";
            SeatNumber.Width = 125;
            // 
            // BookingTime
            // 
            BookingTime.HeaderText = "Giờ đặt";
            BookingTime.MinimumWidth = 6;
            BookingTime.Name = "BookingTime";
            BookingTime.Width = 150;
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
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
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
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 15F);
            textBoxName.Location = new Point(1228, 395);
            textBoxName.Margin = new Padding(4);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(419, 54);
            textBoxName.TabIndex = 3;
            textBoxName.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { STT, CustomerName, SeatNumber, BookingTime });
            dataGridView1.Location = new Point(989, 96);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(712, 235);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1009, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(272, 25);
            label2.TabIndex = 9;
            label2.Text = "Danh sách người dùng đã đặt vé";
            // 
            // comboBoxShowtime
            // 
            comboBoxShowtime.FormattingEnabled = true;
            comboBoxShowtime.Location = new Point(1228, 478);
            comboBoxShowtime.Margin = new Padding(4);
            comboBoxShowtime.Name = "comboBoxShowtime";
            comboBoxShowtime.Size = new Size(419, 33);
            comboBoxShowtime.TabIndex = 10;
            comboBoxShowtime.Visible = false;
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
            textBoxSeatNumber.Visible = false;
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
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(1082, 414);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(89, 25);
            labelName.TabIndex = 13;
            labelName.Text = "Nhập tên:";
            labelName.Visible = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(972, 481);
            labelTime.Margin = new Padding(4, 0, 4, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(202, 25);
            labelTime.TabIndex = 14;
            labelTime.Text = "Chọn phim và thời gian:";
            labelTime.Visible = false;
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
            labelGhe.Visible = false;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1716, 816);
            Controls.Add(labelGhe);
            Controls.Add(labelTime);
            Controls.Add(labelName);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSeatNumber);
            Controls.Add(comboBoxShowtime);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxName);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Panel pnlHangGhe;
        private TextBox textBoxName;
        private DataGridView dataGridView1;
        private Label label2;

        // Định nghĩa sự kiện trống để tránh lỗi
        private void pnlHangGhe_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn SeatNumber;
        private DataGridViewTextBoxColumn BookingTime;
        private ComboBox comboBoxShowtime;
        private TextBox textBoxSeatNumber;
        private Button buttonSave;
        private Label labelName;
        private Label labelTime;
        private Label labelGhe;
    }
}