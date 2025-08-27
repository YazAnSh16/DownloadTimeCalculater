namespace DownloadTimeCalculator
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
            ComboSpeed = new ComboBox();
            label1 = new Label();
            btnPspeed = new Button();
            BtnMspeed = new Button();
            txtSize = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            comboSize = new ComboBox();
            btnCalc = new Button();
            txtSpeed = new TextBox();
            piza = new Label();
            lbltime = new Label();
            pizaaa = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ComboSpeed
            // 
            ComboSpeed.Font = new Font("Segoe UI", 30F);
            ComboSpeed.FormattingEnabled = true;
            ComboSpeed.ImeMode = ImeMode.NoControl;
            ComboSpeed.Items.AddRange(new object[] { "Mbps", "Gbps", "Kbps" });
            ComboSpeed.Location = new Point(876, 122);
            ComboSpeed.Name = "ComboSpeed";
            ComboSpeed.Size = new Size(151, 75);
            ComboSpeed.TabIndex = 8;
            ComboSpeed.Text = "Mbps";
            ComboSpeed.SelectedIndexChanged += ComboSpeed_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(446, 74);
            label1.Name = "label1";
            label1.Size = new Size(358, 32);
            label1.TabIndex = 0;
            label1.Text = "How fast is your internet speed?";
            // 
            // btnPspeed
            // 
            btnPspeed.Font = new Font("Segoe UI", 30F);
            btnPspeed.Location = new Point(388, 122);
            btnPspeed.Name = "btnPspeed";
            btnPspeed.Size = new Size(81, 74);
            btnPspeed.TabIndex = 1;
            btnPspeed.Text = "+";
            btnPspeed.UseVisualStyleBackColor = true;
            btnPspeed.Click += btnPspeed_Click;
            // 
            // BtnMspeed
            // 
            BtnMspeed.Font = new Font("Segoe UI", 30F);
            BtnMspeed.Location = new Point(789, 122);
            BtnMspeed.Name = "BtnMspeed";
            BtnMspeed.Size = new Size(81, 74);
            BtnMspeed.TabIndex = 2;
            BtnMspeed.Text = "-";
            BtnMspeed.UseVisualStyleBackColor = true;
            BtnMspeed.Click += BtnMspeed_Click;
            // 
            // txtSize
            // 
            txtSize.Font = new Font("Segoe UI", 30F);
            txtSize.Location = new Point(475, 269);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(308, 74);
            txtSize.TabIndex = 7;
            txtSize.Text = "0.00";
            txtSize.TextAlign = HorizontalAlignment.Center;
            txtSize.TextChanged += txtSize_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(789, 269);
            button1.Name = "button1";
            button1.Size = new Size(81, 74);
            button1.TabIndex = 6;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 30F);
            button2.Location = new Point(388, 269);
            button2.Name = "button2";
            button2.Size = new Size(81, 74);
            button2.TabIndex = 5;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 221);
            label2.Name = "label2";
            label2.Size = new Size(573, 32);
            label2.TabIndex = 4;
            label2.Text = "What is the size of the thing you want to download?";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 493);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // comboSize
            // 
            comboSize.Font = new Font("Segoe UI", 30F);
            comboSize.FormattingEnabled = true;
            comboSize.Items.AddRange(new object[] { "Kb", "Mb", "Gb" });
            comboSize.Location = new Point(876, 270);
            comboSize.Name = "comboSize";
            comboSize.Size = new Size(151, 75);
            comboSize.TabIndex = 10;
            comboSize.Text = "Mb";
            comboSize.SelectedIndexChanged += comboSize_SelectedIndexChanged;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.Green;
            btnCalc.Font = new Font("Segoe UI", 20F);
            btnCalc.ForeColor = SystemColors.ControlLight;
            btnCalc.Location = new Point(464, 386);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(319, 69);
            btnCalc.TabIndex = 11;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // txtSpeed
            // 
            txtSpeed.Font = new Font("Segoe UI", 30F);
            txtSpeed.Location = new Point(475, 122);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(314, 74);
            txtSpeed.TabIndex = 12;
            txtSpeed.Text = "0.00";
            txtSpeed.TextAlign = HorizontalAlignment.Center;
            txtSpeed.TextChanged += txtSpeed_TextChanged;
            txtSpeed.KeyPress += txtSpeed_KeyPress;
            // 
            // piza
            // 
            piza.AutoSize = true;
            piza.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            piza.ForeColor = Color.FromArgb(0, 192, 0);
            piza.Location = new Point(1033, 90);
            piza.Name = "piza";
            piza.Size = new Size(286, 40);
            piza.TabIndex = 13;
            piza.Text = "Download time is :";
            // 
            // lbltime
            // 
            lbltime.AutoSize = true;
            lbltime.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltime.Location = new Point(1082, 171);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(0, 43);
            lbltime.TabIndex = 14;
            // 
            // pizaaa
            // 
            pizaaa.AutoSize = true;
            pizaaa.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            pizaaa.Location = new Point(896, 411);
            pizaaa.Name = "pizaaa";
            pizaaa.Size = new Size(267, 28);
            pizaaa.TabIndex = 15;
            pizaaa.Text = "copy right saved for yazan sh";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1316, 489);
            Controls.Add(pizaaa);
            Controls.Add(lbltime);
            Controls.Add(piza);
            Controls.Add(txtSpeed);
            Controls.Add(btnCalc);
            Controls.Add(comboSize);
            Controls.Add(pictureBox1);
            Controls.Add(ComboSpeed);
            Controls.Add(txtSize);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(BtnMspeed);
            Controls.Add(btnPspeed);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Download time calculator v1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPspeed;
        private Button BtnMspeed;
        private TextBox txtSize;
        private Button button1;
        private Button button2;
        private Label label2;
        private ComboBox ComboSpeed;
        private PictureBox pictureBox1;
        private ComboBox comboSize;
        private Button btnCalc;
        private TextBox txtSpeed;
        private Label piza;
        private Label lbltime;
        private Label pizaaa;
    }
}
