namespace Sign_in_and_Sign_Up.LoginAdmin
{
    partial class fCalender
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MovieTitle = new DataGridViewTextBoxColumn();
            StartTime = new DataGridViewTextBoxColumn();
            EndTime = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btReturn1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, MovieTitle, StartTime, EndTime });
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(48, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(1164, 850);
            dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            ID.DataPropertyName = "ShowtimeID";
            ID.HeaderText = "Số thứ tự";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Resizable = DataGridViewTriState.True;
            ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            ID.Width = 76;
            // 
            // MovieTitle
            // 
            MovieTitle.DataPropertyName = "MovieTitle";
            MovieTitle.HeaderText = "Tên phim";
            MovieTitle.MinimumWidth = 6;
            MovieTitle.Name = "MovieTitle";
            MovieTitle.Width = 99;
            // 
            // StartTime
            // 
            StartTime.DataPropertyName = "StartTime";
            StartTime.HeaderText = "Giờ chiếu ";
            StartTime.MinimumWidth = 6;
            StartTime.Name = "StartTime";
            StartTime.Width = 104;
            // 
            // EndTime
            // 
            EndTime.DataPropertyName = "EndTime";
            EndTime.HeaderText = "Giờ kết thúc";
            EndTime.MinimumWidth = 6;
            EndTime.Name = "EndTime";
            EndTime.Width = 117;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(435, 19);
            label1.Name = "label1";
            label1.Size = new Size(340, 46);
            label1.TabIndex = 3;
            label1.Text = "QUẢN LÝ LỊCH CHIẾU";
            // 
            // btReturn1
            // 
            btReturn1.Location = new Point(27, 19);
            btReturn1.Name = "btReturn1";
            btReturn1.Size = new Size(166, 46);
            btReturn1.TabIndex = 4;
            btReturn1.Text = "Quay lại";
            btReturn1.UseVisualStyleBackColor = true;
            btReturn1.Click += btReturn1_Click;
            // 
            // fCalender
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1276, 676);
            Controls.Add(btReturn1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "fCalender";
            Text = "Quanlyveadmin";
            WindowState = FormWindowState.Maximized;
            Load += Quanlylichadmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MovieTitle;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private Button btReturn1;
    }
}