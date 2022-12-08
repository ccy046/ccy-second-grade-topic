namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.PictureBox();
            this.plate = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Select = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.plate);
            this.panel1.Controls.Add(this.Ball);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.Select);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 517);
            this.panel1.TabIndex = 0;
            this.panel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(77, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 44);
            this.label3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.save;
            this.pictureBox1.Location = new System.Drawing.Point(527, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // help
            // 
            this.help.Image = global::WindowsFormsApp1.Properties.Resources.說明;
            this.help.Location = new System.Drawing.Point(853, 365);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(236, 128);
            this.help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.help.TabIndex = 9;
            this.help.TabStop = false;
            this.help.Click += new System.EventHandler(this.Help_Click);
            // 
            // plate
            // 
            this.plate.BackColor = System.Drawing.Color.Gray;
            this.plate.Location = new System.Drawing.Point(68, 440);
            this.plate.Name = "plate";
            this.plate.Size = new System.Drawing.Size(160, 25);
            this.plate.TabIndex = 8;
            this.plate.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.Image = global::WindowsFormsApp1.Properties.Resources.ball;
            this.Ball.Location = new System.Drawing.Point(38, 211);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(75, 75);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 7;
            this.Ball.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(248, 78);
            this.trackBar1.Maximum = 6;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(632, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TabStop = false;
            this.trackBar1.Value = 3;
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.Color.White;
            this.Select.Image = global::WindowsFormsApp1.Properties.Resources.難度_1;
            this.Select.Location = new System.Drawing.Point(337, 167);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(475, 161);
            this.Select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Select.TabIndex = 1;
            this.Select.TabStop = false;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            this.Select.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Select_MouseDown);
            this.Select.MouseLeave += new System.EventHandler(this.Select_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(494, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 120);
            this.label1.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.Image = global::WindowsFormsApp1.Properties.Resources.結束_1;
            this.Exit.Location = new System.Drawing.Point(337, 334);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(475, 159);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.Image = global::WindowsFormsApp1.Properties.Resources.開始_1;
            this.Start.Location = new System.Drawing.Point(337, 3);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(475, 158);
            this.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Start.TabIndex = 0;
            this.Start.TabStop = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Start_MouseEnter);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 950;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 517);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "打磚塊";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Exit;
        private new System.Windows.Forms.PictureBox Select;
        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox plate;
        private System.Windows.Forms.PictureBox help;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

