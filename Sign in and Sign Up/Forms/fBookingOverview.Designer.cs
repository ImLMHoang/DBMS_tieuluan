namespace Sign_in_and_Sign_Up.Forms
{
    partial class fBookingOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.Button btnCancelBooking;

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
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.Size = new System.Drawing.Size(1200, 500);
            this.dataGridViewBookings.TabIndex = 0;

            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Size = new System.Drawing.Size(150, 40);
            this.btnCancelBooking.Location = new System.Drawing.Point(1062, 530);
            this.btnCancelBooking.Text = "Hủy Đặt Vé";
            this.btnCancelBooking.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            this.Controls.Add(this.btnCancelBooking);

            // 
            // fBookingOverview
            // 
            this.Controls.Add(this.btnBack);
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 612);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.dataGridViewBookings);
            this.Name = "fBookingOverview";
            this.Text = "Booking Overview";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.ResumeLayout(false);




            //
            // btnBack back to fMain.cs
            //
            this.btnBack.Location = new System.Drawing.Point(12, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
        }

        #endregion
    }
}
