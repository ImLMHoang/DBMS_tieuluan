namespace Sign_in_and_Sign_Up.LoginAdmin
{
    partial class fTicket
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
            dataGridView1 = new DataGridView();
            BookingID = new DataGridViewButtonColumn();
            SeatNumber = new DataGridViewTextBoxColumn();
            ShowtimeID = new DataGridViewTextBoxColumn();
            MovieTitle = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            BookingTime = new DataGridViewTextBoxColumn();
            btReturn2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(219, 29);
            label1.Name = "label1";
            label1.Size = new Size(359, 46);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ TỔNG SỐ VÉ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookingID, SeatNumber, ShowtimeID, MovieTitle, CustomerID, Status, BookingTime });
            dataGridView1.Location = new Point(2, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(933, 188);
            dataGridView1.TabIndex = 1;
            // 
            // BookingID
            // 
            BookingID.DataPropertyName = "BookingID";
            BookingID.HeaderText = "Mã vé";
            BookingID.MinimumWidth = 6;
            BookingID.Name = "BookingID";
            BookingID.Width = 125;
            // 
            // SeatNumber
            // 
            SeatNumber.DataPropertyName = "SeatNumber";
            SeatNumber.HeaderText = "Số ghế";
            SeatNumber.MinimumWidth = 6;
            SeatNumber.Name = "SeatNumber";
            SeatNumber.Width = 125;
            // 
            // ShowtimeID
            // 
            ShowtimeID.DataPropertyName = "ShowtimeID";
            ShowtimeID.HeaderText = "Mã phim";
            ShowtimeID.MinimumWidth = 6;
            ShowtimeID.Name = "ShowtimeID";
            ShowtimeID.Width = 125;
            // 
            // MovieTitle
            // 
            MovieTitle.DataPropertyName = "MovieTitle";
            MovieTitle.HeaderText = "Tên phim";
            MovieTitle.MinimumWidth = 6;
            MovieTitle.Name = "MovieTitle";
            MovieTitle.Width = 125;
            // 
            // CustomerID
            // 
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "Mã khách hàng";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // BookingTime
            // 
            BookingTime.DataPropertyName = "BookingTime";
            BookingTime.HeaderText = "Thời gian đặt";
            BookingTime.MinimumWidth = 6;
            BookingTime.Name = "BookingTime";
            BookingTime.Width = 125;
            // 
            // btReturn2
            // 
            btReturn2.Location = new Point(12, 29);
            btReturn2.Name = "btReturn2";
            btReturn2.Size = new Size(166, 46);
            btReturn2.TabIndex = 5;
            btReturn2.Text = "Quay lại";
            btReturn2.UseVisualStyleBackColor = true;
            btReturn2.Click += btReturn2_Click;
            // 
            // fTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 539);
            Controls.Add(btReturn2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "fTicket";
            Text = "Quanlylichadmin";
            Load += Quanlylvedmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BookingID;
        private DataGridViewTextBoxColumn SeatNumber;
        private DataGridViewTextBoxColumn ShowtimeID;
        private DataGridViewTextBoxColumn MovieTitle;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn BookingTime;
        private Button btReturn2;
    }
}