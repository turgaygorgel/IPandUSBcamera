namespace CAMERAPROJECT
{
    partial class Form1
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
            this.START = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RESET = new System.Windows.Forms.Button();
            this.PAUSE = new System.Windows.Forms.Button();
            this.CAPTURE = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SAVE = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.STOP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.STOP_US_CAMERA_2 = new System.Windows.Forms.Button();
            this.WATCH_US_CAMERA_2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(9, 20);
            this.START.Margin = new System.Windows.Forms.Padding(4);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(144, 28);
            this.START.TabIndex = 0;
            this.START.Text = "START CAMERA";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(495, 20);
            this.RESET.Margin = new System.Windows.Forms.Padding(4);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(151, 28);
            this.RESET.TabIndex = 2;
            this.RESET.Text = "RESET CAMERA";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // PAUSE
            // 
            this.PAUSE.Location = new System.Drawing.Point(682, 20);
            this.PAUSE.Margin = new System.Windows.Forms.Padding(4);
            this.PAUSE.Name = "PAUSE";
            this.PAUSE.Size = new System.Drawing.Size(100, 28);
            this.PAUSE.TabIndex = 3;
            this.PAUSE.Text = "PAUSE";
            this.PAUSE.UseVisualStyleBackColor = true;
            this.PAUSE.Click += new System.EventHandler(this.PAUSE_Click);
            // 
            // CAPTURE
            // 
            this.CAPTURE.Location = new System.Drawing.Point(816, 20);
            this.CAPTURE.Margin = new System.Windows.Forms.Padding(4);
            this.CAPTURE.Name = "CAPTURE";
            this.CAPTURE.Size = new System.Drawing.Size(100, 28);
            this.CAPTURE.TabIndex = 4;
            this.CAPTURE.Text = "CAPTURE";
            this.CAPTURE.UseVisualStyleBackColor = true;
            this.CAPTURE.Click += new System.EventHandler(this.CAPTURE_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(1249, 30);
            this.EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(100, 28);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.EXIT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 126);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(958, 20);
            this.SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(100, 28);
            this.SAVE.TabIndex = 6;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.imgCapture);
            this.panel2.Controls.Add(this.imgVideo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1373, 525);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 467);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1373, 58);
            this.panel3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // imgCapture
            // 
            this.imgCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgCapture.Location = new System.Drawing.Point(469, 25);
            this.imgCapture.Margin = new System.Windows.Forms.Padding(4);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(363, 455);
            this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCapture.TabIndex = 16;
            this.imgCapture.TabStop = false;
            // 
            // imgVideo
            // 
            this.imgVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgVideo.Location = new System.Drawing.Point(40, 25);
            this.imgVideo.Margin = new System.Windows.Forms.Padding(4);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(363, 455);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVideo.TabIndex = 15;
            this.imgVideo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(856, -400);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(232, 900);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(232, 900);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 900);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1094, 7);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(232, 800);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(232, 800);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 800);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.START);
            this.groupBox1.Controls.Add(this.SAVE);
            this.groupBox1.Controls.Add(this.PAUSE);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.RESET);
            this.groupBox1.Controls.Add(this.CAPTURE);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USB CAMERA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.STOP_US_CAMERA_2);
            this.groupBox2.Controls.Add(this.STOP);
            this.groupBox2.Controls.Add(this.WATCH_US_CAMERA_2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(3, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1365, 53);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IP CAMERA";
            // 
            // STOP
            // 
            this.STOP.Location = new System.Drawing.Point(994, 17);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(75, 23);
            this.STOP.TabIndex = 4;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "EURO CAME START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // STOP_US_CAMERA_2
            // 
            this.STOP_US_CAMERA_2.Location = new System.Drawing.Point(1246, 17);
            this.STOP_US_CAMERA_2.Name = "STOP_US_CAMERA_2";
            this.STOP_US_CAMERA_2.Size = new System.Drawing.Size(75, 23);
            this.STOP_US_CAMERA_2.TabIndex = 6;
            this.STOP_US_CAMERA_2.Text = "STOP";
            this.STOP_US_CAMERA_2.UseVisualStyleBackColor = true;
            this.STOP_US_CAMERA_2.Click += new System.EventHandler(this.STOP_US_CAMERA_2_Click);
            // 
            // WATCH_US_CAMERA_2
            // 
            this.WATCH_US_CAMERA_2.Location = new System.Drawing.Point(1109, 17);
            this.WATCH_US_CAMERA_2.Name = "WATCH_US_CAMERA_2";
            this.WATCH_US_CAMERA_2.Size = new System.Drawing.Size(122, 23);
            this.WATCH_US_CAMERA_2.TabIndex = 5;
            this.WATCH_US_CAMERA_2.Text = "US CAMERA START";
            this.WATCH_US_CAMERA_2.UseVisualStyleBackColor = true;
            this.WATCH_US_CAMERA_2.Click += new System.EventHandler(this.WATCH_US_CAMERA_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " AForge Usage for Camera and  how to capture at C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button START;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button PAUSE;
        private System.Windows.Forms.Button CAPTURE;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button STOP_US_CAMERA_2;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Button WATCH_US_CAMERA_2;
        private System.Windows.Forms.Button button2;
    }
}

