namespace XuLiAnhSo1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_addPicture = new Button();
            pictureBox1 = new PictureBox();
            btnShowHistogram = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBoxHistogram = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            trackBar3 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistogram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_addPicture
            // 
            btn_addPicture.BackColor = Color.FromArgb(35, 32, 39);
            btn_addPicture.FlatAppearance.BorderSize = 0;
            btn_addPicture.FlatStyle = FlatStyle.Flat;
            btn_addPicture.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addPicture.ForeColor = Color.LightGray;
            btn_addPicture.ImageAlign = ContentAlignment.TopRight;
            btn_addPicture.Location = new Point(6, 17);
            btn_addPicture.Name = "btn_addPicture";
            btn_addPicture.Padding = new Padding(45, 0, 0, 0);
            btn_addPicture.RightToLeft = RightToLeft.No;
            btn_addPicture.Size = new Size(201, 48);
            btn_addPicture.TabIndex = 0;
            btn_addPicture.Text = "Thêm ảnh";
            btn_addPicture.TextAlign = ContentAlignment.MiddleLeft;
            btn_addPicture.UseVisualStyleBackColor = false;
            btn_addPicture.Click += btn_addPicture_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(8, 9);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(2);
            pictureBox1.Size = new Size(432, 239);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnShowHistogram
            // 
            btnShowHistogram.BackColor = Color.FromArgb(35, 32, 39);
            btnShowHistogram.FlatAppearance.BorderSize = 0;
            btnShowHistogram.FlatStyle = FlatStyle.Flat;
            btnShowHistogram.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowHistogram.ForeColor = Color.LightGray;
            btnShowHistogram.Location = new Point(6, 71);
            btnShowHistogram.Name = "btnShowHistogram";
            btnShowHistogram.Padding = new Padding(45, 0, 0, 0);
            btnShowHistogram.Size = new Size(201, 47);
            btnShowHistogram.TabIndex = 2;
            btnShowHistogram.Text = "Histogram";
            btnShowHistogram.TextAlign = ContentAlignment.MiddleLeft;
            btnShowHistogram.UseVisualStyleBackColor = false;
            btnShowHistogram.Click += btnShowHistogram_Click;
            // 
            // pictureBoxHistogram
            // 
            pictureBoxHistogram.BackColor = Color.WhiteSmoke;
            pictureBoxHistogram.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxHistogram.Location = new Point(670, 81);
            pictureBoxHistogram.Name = "pictureBoxHistogram";
            pictureBoxHistogram.Size = new Size(239, 241);
            pictureBoxHistogram.TabIndex = 3;
            pictureBoxHistogram.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(110, 195, 201);
            label1.Font = new Font("Times", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(190, 25);
            label1.Name = "label1";
            label1.Size = new Size(318, 31);
            label1.TabIndex = 4;
            label1.Text = "Cân bằng biểu đồ Histogram";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 166, 173);
            pictureBox2.Image = Properties.Resources.VLU_Logo_Final_VLU_logo_ngang_Eng_280x60;
            pictureBox2.Location = new Point(6, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(11, 7, 17);
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(222, 329);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 32, 39);
            panel1.Controls.Add(trackBar3);
            panel1.Controls.Add(trackBar2);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnShowHistogram);
            panel1.Controls.Add(btn_addPicture);
            panel1.Location = new Point(6, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 244);
            panel1.TabIndex = 9;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(6, 199);
            trackBar3.Maximum = 100;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(173, 45);
            trackBar3.TabIndex = 7;
            trackBar3.Scroll += trackBar3_Scroll;
            trackBar3.MouseUp += trackBar3_MouseUp;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(6, 160);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(173, 45);
            trackBar2.TabIndex = 6;
            trackBar2.Scroll += trackBar2_Scroll;
            trackBar2.MouseUp += trackBar2_MouseUp;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(6, 125);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(173, 45);
            trackBar1.TabIndex = 5;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.MouseUp += trackBar1_MouseUp;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 71);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ControlDark;
            pictureBox6.Location = new Point(6, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(216, 50);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(110, 195, 201);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(222, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 75);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(222, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 253);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 166, 173);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 75);
            panel4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(911, 329);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(pictureBoxHistogram);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox6);
            Controls.Add(panel2);
            Controls.Add(panel3);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistogram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_addPicture;
        private PictureBox pictureBox1;
        private Button btnShowHistogram;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.CodeDom.CodeTypeReference chart1;
        private PictureBox pictureBoxHistogram;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel2;
        private Panel panel3;
        private TrackBar trackBar1;
        private TrackBar trackBar3;
        private TrackBar trackBar2;
        private Panel panel4;
    }
}