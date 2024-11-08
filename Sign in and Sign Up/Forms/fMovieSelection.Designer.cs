namespace Sign_in_and_Sign_Up.Forms
{
    partial class fMovieSelection
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private PictureBox[] pictureBoxes;
        private Button[] buttons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.SuspendLayout();

            // Label
            this.label1.AutoSize = true;
            this.label1.BackColor = SystemColors.GradientInactiveCaption;
            this.label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            this.label1.ForeColor = Color.Sienna;
            this.label1.Location = new Point(304, 25);
            this.label1.Name = "label1";
            this.label1.Size = new Size(158, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "LIST MOVIE";

            // Initialize PictureBox and Button arrays
            int movieCount = 10;
            pictureBoxes = new PictureBox[movieCount];
            buttons = new Button[movieCount];
            SetupMovieButtonsAndPictures();

            // Add controls to form
            this.Controls.Add(this.label1);
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ActiveCaption;
            this.ClientSize = new Size(800, 650);
            this.Name = "fMovieSelection";
            this.Text = "Select Movie";
            this.Load += new EventHandler(this.fMovieSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupMovieButtonsAndPictures()
        {
            int x = 50, y = 100;
            int pictureWidth = 100, pictureHeight = 150;
            int buttonHeight = 30, padding = 20;

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                // Create PictureBox
                pictureBoxes[i] = new PictureBox
                {
                    Location = new Point(x, y),
                    Size = new Size(pictureWidth, pictureHeight),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    TabStop = false
                };
                this.Controls.Add(pictureBoxes[i]);

                // Create Button
                buttons[i] = new Button
                {
                    Location = new Point(x, y + pictureHeight + 5),
                    Size = new Size(pictureWidth, buttonHeight),
                    Text = "Movie " + (i + 1)
                };
                this.Controls.Add(buttons[i]);

                x += pictureWidth + padding;
                if ((i + 1) % 5 == 0)
                {
                    x = 50;
                    y += pictureHeight + buttonHeight + padding;
                }
            }
        }
    }
}
