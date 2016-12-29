﻿namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Speed_tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Volume_Bar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Marker = new System.Windows.Forms.Button();
            this.folder_open = new System.Windows.Forms.Button();
            this.Camera = new System.Windows.Forms.Button();
            this.icons_save = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.audio_step_forward = new System.Windows.Forms.Button();
            this.audio_stop = new System.Windows.Forms.Button();
            this.audio_play = new System.Windows.Forms.Button();
            this.audio_step_back = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.LeftRight = new System.Windows.Forms.TrackBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.UpDown = new System.Windows.Forms.TrackBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.time_tbox = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("문체부 제목 돋음체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEWER";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(12, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "x 0.2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(78, 677);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "x 0.5";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(144, 677);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "x 1.0";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(210, 677);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "x 1.5";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(276, 677);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "x 2.0";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Speed_tbox
            // 
            this.Speed_tbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Speed_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Speed_tbox.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Speed_tbox.Location = new System.Drawing.Point(7, 59);
            this.Speed_tbox.Name = "Speed_tbox";
            this.Speed_tbox.Size = new System.Drawing.Size(68, 41);
            this.Speed_tbox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(81, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "km/h";
            // 
            // Volume_Bar
            // 
            this.Volume_Bar.LargeChange = 1;
            this.Volume_Bar.Location = new System.Drawing.Point(193, 59);
            this.Volume_Bar.Name = "Volume_Bar";
            this.Volume_Bar.Size = new System.Drawing.Size(153, 45);
            this.Volume_Bar.TabIndex = 18;
            this.Volume_Bar.Value = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "G 센서";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(900, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 20);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "상시";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(975, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 20);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "이벤트";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton3.Location = new System.Drawing.Point(1065, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 20);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "주차";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton4.Location = new System.Drawing.Point(1146, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 20);
            this.radioButton4.TabIndex = 32;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "사진";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.map;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(888, 358);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(324, 313);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Audio;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(162, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 45);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.testimage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 378);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Marker
            // 
            this.Marker.BackColor = System.Drawing.Color.Transparent;
            this.Marker.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Marker;
            this.Marker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Marker.Location = new System.Drawing.Point(888, 677);
            this.Marker.Name = "Marker";
            this.Marker.Size = new System.Drawing.Size(60, 40);
            this.Marker.TabIndex = 14;
            this.Marker.UseVisualStyleBackColor = false;
            // 
            // folder_open
            // 
            this.folder_open.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.folder_open;
            this.folder_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.folder_open.Location = new System.Drawing.Point(954, 677);
            this.folder_open.Name = "folder_open";
            this.folder_open.Size = new System.Drawing.Size(60, 40);
            this.folder_open.TabIndex = 13;
            this.folder_open.UseVisualStyleBackColor = true;
            // 
            // Camera
            // 
            this.Camera.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Camera;
            this.Camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Camera.Location = new System.Drawing.Point(1020, 677);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(60, 40);
            this.Camera.TabIndex = 12;
            this.Camera.UseVisualStyleBackColor = true;
            // 
            // icons_save
            // 
            this.icons_save.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons_save;
            this.icons_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icons_save.Location = new System.Drawing.Point(1086, 677);
            this.icons_save.Name = "icons_save";
            this.icons_save.Size = new System.Drawing.Size(60, 40);
            this.icons_save.TabIndex = 11;
            this.icons_save.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Settings;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.Location = new System.Drawing.Point(1152, 677);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(60, 40);
            this.Settings.TabIndex = 10;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // audio_step_forward
            // 
            this.audio_step_forward.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.audio_step_forward;
            this.audio_step_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audio_step_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audio_step_forward.ForeColor = System.Drawing.SystemColors.Control;
            this.audio_step_forward.Location = new System.Drawing.Point(670, 677);
            this.audio_step_forward.Name = "audio_step_forward";
            this.audio_step_forward.Size = new System.Drawing.Size(60, 40);
            this.audio_step_forward.TabIndex = 9;
            this.audio_step_forward.UseVisualStyleBackColor = true;
            // 
            // audio_stop
            // 
            this.audio_stop.BackColor = System.Drawing.SystemColors.Control;
            this.audio_stop.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.audio_stop;
            this.audio_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audio_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audio_stop.ForeColor = System.Drawing.SystemColors.Control;
            this.audio_stop.Location = new System.Drawing.Point(604, 677);
            this.audio_stop.Name = "audio_stop";
            this.audio_stop.Size = new System.Drawing.Size(60, 40);
            this.audio_stop.TabIndex = 8;
            this.audio_stop.UseVisualStyleBackColor = true;
            // 
            // audio_play
            // 
            this.audio_play.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.audio_play;
            this.audio_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audio_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audio_play.ForeColor = System.Drawing.SystemColors.Control;
            this.audio_play.Location = new System.Drawing.Point(538, 677);
            this.audio_play.Name = "audio_play";
            this.audio_play.Size = new System.Drawing.Size(60, 40);
            this.audio_play.TabIndex = 7;
            this.audio_play.UseVisualStyleBackColor = true;
            // 
            // audio_step_back
            // 
            this.audio_step_back.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.audio_step_back;
            this.audio_step_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audio_step_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audio_step_back.ForeColor = System.Drawing.SystemColors.Control;
            this.audio_step_back.Location = new System.Drawing.Point(472, 677);
            this.audio_step_back.Name = "audio_step_back";
            this.audio_step_back.Size = new System.Drawing.Size(60, 40);
            this.audio_step_back.TabIndex = 6;
            this.audio_step_back.UseVisualStyleBackColor = true;
            this.audio_step_back.Click += new System.EventHandler(this.audio_step_back_Click);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(888, 51);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(324, 301);
            this.listView.TabIndex = 33;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // LeftRight
            // 
            this.LeftRight.Location = new System.Drawing.Point(423, 59);
            this.LeftRight.Maximum = 1;
            this.LeftRight.Name = "LeftRight";
            this.LeftRight.Size = new System.Drawing.Size(104, 45);
            this.LeftRight.TabIndex = 34;
            this.LeftRight.Scroll += new System.EventHandler(this.LeftRight_Scroll);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.UnitedArrowUpDown_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(376, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 46);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // UpDown
            // 
            this.UpDown.Location = new System.Drawing.Point(600, 59);
            this.UpDown.Maximum = 1;
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(104, 45);
            this.UpDown.TabIndex = 36;
            this.UpDown.Scroll += new System.EventHandler(this.UpDown_Scroll);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.UnitedArrowUpDown;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(555, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 45);
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // time_tbox
            // 
            this.time_tbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.time_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_tbox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time_tbox.Location = new System.Drawing.Point(702, 6);
            this.time_tbox.Name = "time_tbox";
            this.time_tbox.Size = new System.Drawing.Size(176, 28);
            this.time_tbox.TabIndex = 39;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(0, 6);
            this.trackBar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(704, 45);
            this.trackBar.TabIndex = 40;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.time_tbox);
            this.groupBox1.Controls.Add(this.Speed_tbox);
            this.groupBox1.Controls.Add(this.trackBar);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.UpDown);
            this.groupBox1.Controls.Add(this.Volume_Bar);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.LeftRight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 110);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Marker);
            this.Controls.Add(this.folder_open);
            this.Controls.Add(this.Camera);
            this.Controls.Add(this.icons_save);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.audio_step_forward);
            this.Controls.Add(this.audio_stop);
            this.Controls.Add(this.audio_play);
            this.Controls.Add(this.audio_step_back);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "BB Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button audio_step_back;
        private System.Windows.Forms.Button audio_play;
        private System.Windows.Forms.Button audio_stop;
        private System.Windows.Forms.Button audio_step_forward;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button icons_save;
        private System.Windows.Forms.Button Camera;
        private System.Windows.Forms.Button folder_open;
        private System.Windows.Forms.Button Marker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Speed_tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Volume_Bar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TrackBar LeftRight;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar UpDown;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox time_tbox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
