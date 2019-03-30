namespace TsunamiInformationViewer
{
    partial class TsunamiViewer
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
            this.infoget_timer = new System.Windows.Forms.Timer(this.components);
            this.EqText = new System.Windows.Forms.Label();
            this.type1 = new System.Windows.Forms.Label();
            this.type2 = new System.Windows.Forms.Label();
            this.type3 = new System.Windows.Forms.Label();
            this.type5 = new System.Windows.Forms.Label();
            this.type4 = new System.Windows.Forms.Label();
            this.type6 = new System.Windows.Forms.Label();
            this.location1 = new System.Windows.Forms.Label();
            this.location2 = new System.Windows.Forms.Label();
            this.location3 = new System.Windows.Forms.Label();
            this.location4 = new System.Windows.Forms.Label();
            this.location5 = new System.Windows.Forms.Label();
            this.location6 = new System.Windows.Forms.Label();
            this.arrival_time1 = new System.Windows.Forms.Label();
            this.arrival_time2 = new System.Windows.Forms.Label();
            this.arrival_time3 = new System.Windows.Forms.Label();
            this.arrival_time4 = new System.Windows.Forms.Label();
            this.arrival_time5 = new System.Windows.Forms.Label();
            this.arrival_time6 = new System.Windows.Forms.Label();
            this.height1 = new System.Windows.Forms.Label();
            this.height2 = new System.Windows.Forms.Label();
            this.height3 = new System.Windows.Forms.Label();
            this.height4 = new System.Windows.Forms.Label();
            this.height5 = new System.Windows.Forms.Label();
            this.height6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.message_timer1 = new System.Windows.Forms.Timer(this.components);
            this.message_timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoget_timer
            // 
            this.infoget_timer.Enabled = true;
            this.infoget_timer.Interval = 2000;
            this.infoget_timer.Tick += new System.EventHandler(this.timer1_TickAsync);
            // 
            // EqText
            // 
            this.EqText.AutoSize = true;
            this.EqText.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EqText.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EqText.ForeColor = System.Drawing.Color.White;
            this.EqText.Location = new System.Drawing.Point(390, 18);
            this.EqText.Name = "EqText";
            this.EqText.Size = new System.Drawing.Size(0, 20);
            this.EqText.TabIndex = 0;
            // 
            // type1
            // 
            this.type1.AutoSize = true;
            this.type1.BackColor = System.Drawing.Color.Transparent;
            this.type1.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.type1.ForeColor = System.Drawing.Color.White;
            this.type1.Location = new System.Drawing.Point(19, 100);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(0, 41);
            this.type1.TabIndex = 1;
            // 
            // type2
            // 
            this.type2.AutoSize = true;
            this.type2.BackColor = System.Drawing.Color.Transparent;
            this.type2.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.type2.ForeColor = System.Drawing.Color.White;
            this.type2.Location = new System.Drawing.Point(19, 168);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(0, 41);
            this.type2.TabIndex = 2;
            this.type2.Click += new System.EventHandler(this.type2_Click);
            // 
            // type3
            // 
            this.type3.AutoSize = true;
            this.type3.BackColor = System.Drawing.Color.Transparent;
            this.type3.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.type3.ForeColor = System.Drawing.Color.White;
            this.type3.Location = new System.Drawing.Point(19, 236);
            this.type3.Name = "type3";
            this.type3.Size = new System.Drawing.Size(0, 41);
            this.type3.TabIndex = 3;
            // 
            // type5
            // 
            this.type5.AutoSize = true;
            this.type5.BackColor = System.Drawing.Color.Transparent;
            this.type5.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.type5.ForeColor = System.Drawing.Color.White;
            this.type5.Location = new System.Drawing.Point(19, 370);
            this.type5.Name = "type5";
            this.type5.Size = new System.Drawing.Size(0, 41);
            this.type5.TabIndex = 4;
            // 
            // type4
            // 
            this.type4.AutoSize = true;
            this.type4.BackColor = System.Drawing.Color.Transparent;
            this.type4.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.type4.ForeColor = System.Drawing.Color.White;
            this.type4.Location = new System.Drawing.Point(19, 303);
            this.type4.Name = "type4";
            this.type4.Size = new System.Drawing.Size(0, 41);
            this.type4.TabIndex = 4;
            // 
            // type6
            // 
            this.type6.AutoSize = true;
            this.type6.BackColor = System.Drawing.Color.Transparent;
            this.type6.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.type6.ForeColor = System.Drawing.Color.White;
            this.type6.Location = new System.Drawing.Point(19, 438);
            this.type6.Name = "type6";
            this.type6.Size = new System.Drawing.Size(0, 41);
            this.type6.TabIndex = 5;
            // 
            // location1
            // 
            this.location1.AutoSize = true;
            this.location1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location1.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.location1.ForeColor = System.Drawing.Color.White;
            this.location1.Location = new System.Drawing.Point(220, 100);
            this.location1.Name = "location1";
            this.location1.Size = new System.Drawing.Size(0, 41);
            this.location1.TabIndex = 6;
            // 
            // location2
            // 
            this.location2.AutoSize = true;
            this.location2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location2.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.location2.ForeColor = System.Drawing.Color.White;
            this.location2.Location = new System.Drawing.Point(220, 168);
            this.location2.Name = "location2";
            this.location2.Size = new System.Drawing.Size(0, 41);
            this.location2.TabIndex = 7;
            // 
            // location3
            // 
            this.location3.AutoSize = true;
            this.location3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location3.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.location3.ForeColor = System.Drawing.Color.White;
            this.location3.Location = new System.Drawing.Point(220, 236);
            this.location3.Name = "location3";
            this.location3.Size = new System.Drawing.Size(0, 41);
            this.location3.TabIndex = 8;
            // 
            // location4
            // 
            this.location4.AutoSize = true;
            this.location4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location4.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.location4.ForeColor = System.Drawing.Color.White;
            this.location4.Location = new System.Drawing.Point(220, 303);
            this.location4.Name = "location4";
            this.location4.Size = new System.Drawing.Size(0, 41);
            this.location4.TabIndex = 9;
            // 
            // location5
            // 
            this.location5.AutoSize = true;
            this.location5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location5.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.location5.ForeColor = System.Drawing.Color.White;
            this.location5.Location = new System.Drawing.Point(220, 370);
            this.location5.Name = "location5";
            this.location5.Size = new System.Drawing.Size(0, 41);
            this.location5.TabIndex = 10;
            // 
            // location6
            // 
            this.location6.AutoSize = true;
            this.location6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location6.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.location6.ForeColor = System.Drawing.Color.White;
            this.location6.Location = new System.Drawing.Point(220, 438);
            this.location6.Name = "location6";
            this.location6.Size = new System.Drawing.Size(0, 41);
            this.location6.TabIndex = 11;
            // 
            // arrival_time1
            // 
            this.arrival_time1.AutoSize = true;
            this.arrival_time1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arrival_time1.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.arrival_time1.ForeColor = System.Drawing.Color.Gold;
            this.arrival_time1.Location = new System.Drawing.Point(540, 100);
            this.arrival_time1.Name = "arrival_time1";
            this.arrival_time1.Size = new System.Drawing.Size(0, 41);
            this.arrival_time1.TabIndex = 12;
            // 
            // arrival_time2
            // 
            this.arrival_time2.AutoSize = true;
            this.arrival_time2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arrival_time2.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.arrival_time2.ForeColor = System.Drawing.Color.Gold;
            this.arrival_time2.Location = new System.Drawing.Point(540, 168);
            this.arrival_time2.Name = "arrival_time2";
            this.arrival_time2.Size = new System.Drawing.Size(0, 41);
            this.arrival_time2.TabIndex = 13;
            // 
            // arrival_time3
            // 
            this.arrival_time3.AutoSize = true;
            this.arrival_time3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arrival_time3.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.arrival_time3.ForeColor = System.Drawing.Color.Gold;
            this.arrival_time3.Location = new System.Drawing.Point(540, 236);
            this.arrival_time3.Name = "arrival_time3";
            this.arrival_time3.Size = new System.Drawing.Size(0, 41);
            this.arrival_time3.TabIndex = 14;
            // 
            // arrival_time4
            // 
            this.arrival_time4.AutoSize = true;
            this.arrival_time4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arrival_time4.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.arrival_time4.ForeColor = System.Drawing.Color.Gold;
            this.arrival_time4.Location = new System.Drawing.Point(540, 303);
            this.arrival_time4.Name = "arrival_time4";
            this.arrival_time4.Size = new System.Drawing.Size(0, 41);
            this.arrival_time4.TabIndex = 15;
            // 
            // arrival_time5
            // 
            this.arrival_time5.AutoSize = true;
            this.arrival_time5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arrival_time5.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.arrival_time5.ForeColor = System.Drawing.Color.Gold;
            this.arrival_time5.Location = new System.Drawing.Point(540, 370);
            this.arrival_time5.Name = "arrival_time5";
            this.arrival_time5.Size = new System.Drawing.Size(0, 41);
            this.arrival_time5.TabIndex = 16;
            // 
            // arrival_time6
            // 
            this.arrival_time6.AutoSize = true;
            this.arrival_time6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arrival_time6.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.arrival_time6.ForeColor = System.Drawing.Color.Gold;
            this.arrival_time6.Location = new System.Drawing.Point(540, 438);
            this.arrival_time6.Name = "arrival_time6";
            this.arrival_time6.Size = new System.Drawing.Size(0, 41);
            this.arrival_time6.TabIndex = 17;
            // 
            // height1
            // 
            this.height1.AutoSize = true;
            this.height1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.height1.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.height1.ForeColor = System.Drawing.Color.White;
            this.height1.Location = new System.Drawing.Point(780, 100);
            this.height1.Name = "height1";
            this.height1.Size = new System.Drawing.Size(0, 41);
            this.height1.TabIndex = 18;
            // 
            // height2
            // 
            this.height2.AutoSize = true;
            this.height2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.height2.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.height2.ForeColor = System.Drawing.Color.White;
            this.height2.Location = new System.Drawing.Point(780, 168);
            this.height2.Name = "height2";
            this.height2.Size = new System.Drawing.Size(0, 41);
            this.height2.TabIndex = 19;
            // 
            // height3
            // 
            this.height3.AutoSize = true;
            this.height3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.height3.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.height3.ForeColor = System.Drawing.Color.White;
            this.height3.Location = new System.Drawing.Point(780, 236);
            this.height3.Name = "height3";
            this.height3.Size = new System.Drawing.Size(0, 41);
            this.height3.TabIndex = 20;
            // 
            // height4
            // 
            this.height4.AutoSize = true;
            this.height4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.height4.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.height4.ForeColor = System.Drawing.Color.White;
            this.height4.Location = new System.Drawing.Point(780, 303);
            this.height4.Name = "height4";
            this.height4.Size = new System.Drawing.Size(0, 41);
            this.height4.TabIndex = 21;
            // 
            // height5
            // 
            this.height5.AutoSize = true;
            this.height5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.height5.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.height5.ForeColor = System.Drawing.Color.White;
            this.height5.Location = new System.Drawing.Point(780, 370);
            this.height5.Name = "height5";
            this.height5.Size = new System.Drawing.Size(0, 41);
            this.height5.TabIndex = 22;
            // 
            // height6
            // 
            this.height6.AutoSize = true;
            this.height6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.height6.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.height6.ForeColor = System.Drawing.Color.White;
            this.height6.Location = new System.Drawing.Point(780, 438);
            this.height6.Name = "height6";
            this.height6.Size = new System.Drawing.Size(0, 41);
            this.height6.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TsunamiInformationViewer.Properties.Resources.スライド2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.type1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 530);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Koruri Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(654, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 2;
            this.label1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 4000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 4000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 4000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // message_timer1
            // 
            this.message_timer1.Interval = 2000;
            this.message_timer1.Tick += new System.EventHandler(this.message_timer1_Tick);
            // 
            // message_timer2
            // 
            this.message_timer2.Interval = 2000;
            this.message_timer2.Tick += new System.EventHandler(this.message_timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(587, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 3;
            // 
            // TsunamiViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 530);
            this.Controls.Add(this.height6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.height5);
            this.Controls.Add(this.height4);
            this.Controls.Add(this.height3);
            this.Controls.Add(this.height2);
            this.Controls.Add(this.height1);
            this.Controls.Add(this.arrival_time6);
            this.Controls.Add(this.arrival_time5);
            this.Controls.Add(this.arrival_time4);
            this.Controls.Add(this.arrival_time3);
            this.Controls.Add(this.arrival_time2);
            this.Controls.Add(this.arrival_time1);
            this.Controls.Add(this.location6);
            this.Controls.Add(this.location5);
            this.Controls.Add(this.location4);
            this.Controls.Add(this.location3);
            this.Controls.Add(this.location2);
            this.Controls.Add(this.location1);
            this.Controls.Add(this.type6);
            this.Controls.Add(this.type4);
            this.Controls.Add(this.type5);
            this.Controls.Add(this.type3);
            this.Controls.Add(this.type2);
            this.Controls.Add(this.EqText);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TsunamiViewer";
            this.Text = "津波到達予想表";
            this.Load += new System.EventHandler(this.TsunamiViewer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer infoget_timer;
        public System.Windows.Forms.Label EqText;
        public System.Windows.Forms.Label type1;
        public System.Windows.Forms.Label type2;
        public System.Windows.Forms.Label type3;
        public System.Windows.Forms.Label type5;
        public System.Windows.Forms.Label type4;
        public System.Windows.Forms.Label type6;
        public System.Windows.Forms.Label location1;
        public System.Windows.Forms.Label location2;
        public System.Windows.Forms.Label location3;
        public System.Windows.Forms.Label location4;
        public System.Windows.Forms.Label location5;
        public System.Windows.Forms.Label location6;
        public System.Windows.Forms.Label arrival_time1;
        public System.Windows.Forms.Label arrival_time2;
        public System.Windows.Forms.Label arrival_time3;
        public System.Windows.Forms.Label arrival_time4;
        public System.Windows.Forms.Label arrival_time5;
        public System.Windows.Forms.Label arrival_time6;
        public System.Windows.Forms.Label height1;
        public System.Windows.Forms.Label height2;
        public System.Windows.Forms.Label height3;
        public System.Windows.Forms.Label height4;
        public System.Windows.Forms.Label height5;
        public System.Windows.Forms.Label height6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer message_timer1;
        public System.Windows.Forms.Timer message_timer2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}