namespace Transmitter
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
            this.components = new System.ComponentModel.Container();
            this.openCOM_btn = new System.Windows.Forms.Button();
            this.closeCOM_btn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.com_port_combo = new System.Windows.Forms.ComboBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lat_text = new System.Windows.Forms.TextBox();
            this.long_text = new System.Windows.Forms.TextBox();
            this.yaw_track = new System.Windows.Forms.TrackBar();
            this.roll_track = new System.Windows.Forms.TrackBar();
            this.pitch_track = new System.Windows.Forms.TrackBar();
            this.yaw_value = new System.Windows.Forms.Label();
            this.roll_value = new System.Windows.Forms.Label();
            this.pitch_value = new System.Windows.Forms.Label();
            this.state_num = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yaw_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_num)).BeginInit();
            this.SuspendLayout();
            // 
            // openCOM_btn
            // 
            this.openCOM_btn.Location = new System.Drawing.Point(26, 56);
            this.openCOM_btn.Name = "openCOM_btn";
            this.openCOM_btn.Size = new System.Drawing.Size(75, 23);
            this.openCOM_btn.TabIndex = 0;
            this.openCOM_btn.Text = "OPEN";
            this.openCOM_btn.UseVisualStyleBackColor = true;
            this.openCOM_btn.Click += new System.EventHandler(this.openCOM_btn_Click);
            // 
            // closeCOM_btn
            // 
            this.closeCOM_btn.Location = new System.Drawing.Point(108, 56);
            this.closeCOM_btn.Name = "closeCOM_btn";
            this.closeCOM_btn.Size = new System.Drawing.Size(75, 23);
            this.closeCOM_btn.TabIndex = 1;
            this.closeCOM_btn.Text = "CLOSE";
            this.closeCOM_btn.UseVisualStyleBackColor = true;
            this.closeCOM_btn.Click += new System.EventHandler(this.closeCOM_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(157, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // com_port_combo
            // 
            this.com_port_combo.FormattingEnabled = true;
            this.com_port_combo.Location = new System.Drawing.Point(26, 29);
            this.com_port_combo.Name = "com_port_combo";
            this.com_port_combo.Size = new System.Drawing.Size(157, 21);
            this.com_port_combo.TabIndex = 3;
            // 
            // start_btn
            // 
            this.start_btn.Enabled = false;
            this.start_btn.Location = new System.Drawing.Point(26, 371);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 80);
            this.start_btn.TabIndex = 4;
            this.start_btn.Text = "START sending";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Enabled = false;
            this.stop_btn.Location = new System.Drawing.Point(108, 371);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 80);
            this.stop_btn.TabIndex = 5;
            this.stop_btn.Text = "STOP sending";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "lat.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "long.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "yaw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "roll";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "pitch";
            // 
            // lat_text
            // 
            this.lat_text.Location = new System.Drawing.Point(67, 133);
            this.lat_text.Name = "lat_text";
            this.lat_text.Size = new System.Drawing.Size(142, 20);
            this.lat_text.TabIndex = 11;
            // 
            // long_text
            // 
            this.long_text.Location = new System.Drawing.Point(67, 159);
            this.long_text.Name = "long_text";
            this.long_text.Size = new System.Drawing.Size(142, 20);
            this.long_text.TabIndex = 12;
            // 
            // yaw_track
            // 
            this.yaw_track.Location = new System.Drawing.Point(67, 192);
            this.yaw_track.Maximum = 180;
            this.yaw_track.Minimum = -180;
            this.yaw_track.Name = "yaw_track";
            this.yaw_track.Size = new System.Drawing.Size(104, 45);
            this.yaw_track.TabIndex = 13;
            this.yaw_track.Scroll += new System.EventHandler(this.yaw_track_Scroll);
            // 
            // roll_track
            // 
            this.roll_track.Location = new System.Drawing.Point(67, 233);
            this.roll_track.Maximum = 180;
            this.roll_track.Minimum = -180;
            this.roll_track.Name = "roll_track";
            this.roll_track.Size = new System.Drawing.Size(104, 45);
            this.roll_track.TabIndex = 14;
            this.roll_track.Scroll += new System.EventHandler(this.roll_track_Scroll);
            // 
            // pitch_track
            // 
            this.pitch_track.Location = new System.Drawing.Point(67, 284);
            this.pitch_track.Maximum = 180;
            this.pitch_track.Minimum = -180;
            this.pitch_track.Name = "pitch_track";
            this.pitch_track.Size = new System.Drawing.Size(104, 45);
            this.pitch_track.TabIndex = 15;
            this.pitch_track.Scroll += new System.EventHandler(this.pitch_track_Scroll);
            // 
            // yaw_value
            // 
            this.yaw_value.AutoSize = true;
            this.yaw_value.Location = new System.Drawing.Point(178, 192);
            this.yaw_value.Name = "yaw_value";
            this.yaw_value.Size = new System.Drawing.Size(13, 13);
            this.yaw_value.TabIndex = 16;
            this.yaw_value.Text = "0";
            // 
            // roll_value
            // 
            this.roll_value.AutoSize = true;
            this.roll_value.Location = new System.Drawing.Point(178, 233);
            this.roll_value.Name = "roll_value";
            this.roll_value.Size = new System.Drawing.Size(13, 13);
            this.roll_value.TabIndex = 17;
            this.roll_value.Text = "0";
            // 
            // pitch_value
            // 
            this.pitch_value.AutoSize = true;
            this.pitch_value.Location = new System.Drawing.Point(178, 284);
            this.pitch_value.Name = "pitch_value";
            this.pitch_value.Size = new System.Drawing.Size(13, 13);
            this.pitch_value.TabIndex = 18;
            this.pitch_value.Text = "0";
            // 
            // state_num
            // 
            this.state_num.Location = new System.Drawing.Point(67, 335);
            this.state_num.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.state_num.Name = "state_num";
            this.state_num.Size = new System.Drawing.Size(34, 20);
            this.state_num.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "State";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 463);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.state_num);
            this.Controls.Add(this.pitch_value);
            this.Controls.Add(this.roll_value);
            this.Controls.Add(this.yaw_value);
            this.Controls.Add(this.pitch_track);
            this.Controls.Add(this.roll_track);
            this.Controls.Add(this.yaw_track);
            this.Controls.Add(this.long_text);
            this.Controls.Add(this.lat_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.com_port_combo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.closeCOM_btn);
            this.Controls.Add(this.openCOM_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yaw_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openCOM_btn;
        private System.Windows.Forms.Button closeCOM_btn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox com_port_combo;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lat_text;
        private System.Windows.Forms.TextBox long_text;
        private System.Windows.Forms.TrackBar yaw_track;
        private System.Windows.Forms.TrackBar roll_track;
        private System.Windows.Forms.TrackBar pitch_track;
        private System.Windows.Forms.Label yaw_value;
        private System.Windows.Forms.Label roll_value;
        private System.Windows.Forms.Label pitch_value;
        private System.Windows.Forms.NumericUpDown state_num;
        private System.Windows.Forms.Label label6;
    }
}

