namespace MoveControl
{
    partial class BasicMove
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_BackHome = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox_Slg = new System.Windows.Forms.GroupBox();
            this.textBox_sspeed = new System.Windows.Forms.TextBox();
            this.textBox_sdist2 = new System.Windows.Forms.TextBox();
            this.textBox_sdist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_ChangePos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ChangeVel = new System.Windows.Forms.Button();
            this.button_Sstart = new System.Windows.Forms.Button();
            this.groupBox_Ipl = new System.Windows.Forms.GroupBox();
            this.textBox_ixdist = new System.Windows.Forms.TextBox();
            this.textBox_iydist = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button_Istart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_accTime = new System.Windows.Forms.TextBox();
            this.textBox_runSpd = new System.Windows.Forms.TextBox();
            this.textBox_begSpd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.button_SlowStop = new System.Windows.Forms.Button();
            this.button_ImdStop = new System.Windows.Forms.Button();
            this.button_ZeroPos = new System.Windows.Forms.Button();
            this.timer_watching = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_Y = new System.Windows.Forms.Label();
            this.groupBox_Slg.SuspendLayout();
            this.groupBox_Ipl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_BackHome
            // 
            this.button_BackHome.Location = new System.Drawing.Point(654, 201);
            this.button_BackHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_BackHome.Name = "button_BackHome";
            this.button_BackHome.Size = new System.Drawing.Size(87, 31);
            this.button_BackHome.TabIndex = 2;
            this.button_BackHome.Text = "回原点";
            this.button_BackHome.UseVisualStyleBackColor = true;
            this.button_BackHome.Click += new System.EventHandler(this.button_BackHome_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "X Axis",
            "Y Axis"});
            this.checkedListBox1.Location = new System.Drawing.Point(554, 34);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(78, 36);
            this.checkedListBox1.TabIndex = 3;
            // 
            // groupBox_Slg
            // 
            this.groupBox_Slg.Controls.Add(this.textBox_sspeed);
            this.groupBox_Slg.Controls.Add(this.textBox_sdist2);
            this.groupBox_Slg.Controls.Add(this.textBox_sdist);
            this.groupBox_Slg.Controls.Add(this.label5);
            this.groupBox_Slg.Controls.Add(this.button_ChangePos);
            this.groupBox_Slg.Controls.Add(this.label4);
            this.groupBox_Slg.Controls.Add(this.label3);
            this.groupBox_Slg.Controls.Add(this.button_ChangeVel);
            this.groupBox_Slg.Controls.Add(this.button_Sstart);
            this.groupBox_Slg.Location = new System.Drawing.Point(282, 111);
            this.groupBox_Slg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Slg.Name = "groupBox_Slg";
            this.groupBox_Slg.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Slg.Size = new System.Drawing.Size(362, 160);
            this.groupBox_Slg.TabIndex = 4;
            this.groupBox_Slg.TabStop = false;
            this.groupBox_Slg.Text = "SingleAxis";
            // 
            // textBox_sspeed
            // 
            this.textBox_sspeed.Location = new System.Drawing.Point(85, 109);
            this.textBox_sspeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_sspeed.Name = "textBox_sspeed";
            this.textBox_sspeed.Size = new System.Drawing.Size(116, 23);
            this.textBox_sspeed.TabIndex = 15;
            this.textBox_sspeed.Text = "3000";
            // 
            // textBox_sdist2
            // 
            this.textBox_sdist2.Location = new System.Drawing.Point(85, 68);
            this.textBox_sdist2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_sdist2.Name = "textBox_sdist2";
            this.textBox_sdist2.Size = new System.Drawing.Size(116, 23);
            this.textBox_sdist2.TabIndex = 14;
            this.textBox_sdist2.Text = "5000";
            // 
            // textBox_sdist
            // 
            this.textBox_sdist.Location = new System.Drawing.Point(85, 31);
            this.textBox_sdist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_sdist.Name = "textBox_sdist";
            this.textBox_sdist.Size = new System.Drawing.Size(116, 23);
            this.textBox_sdist.TabIndex = 13;
            this.textBox_sdist.Text = "4000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "改变速度";
            // 
            // button_ChangePos
            // 
            this.button_ChangePos.Location = new System.Drawing.Point(241, 65);
            this.button_ChangePos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ChangePos.Name = "button_ChangePos";
            this.button_ChangePos.Size = new System.Drawing.Size(87, 31);
            this.button_ChangePos.TabIndex = 11;
            this.button_ChangePos.Text = "修改位置";
            this.button_ChangePos.UseVisualStyleBackColor = true;
            this.button_ChangePos.Click += new System.EventHandler(this.button_ChangePos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "改变终点";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "定长位移";
            // 
            // button_ChangeVel
            // 
            this.button_ChangeVel.Location = new System.Drawing.Point(241, 107);
            this.button_ChangeVel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ChangeVel.Name = "button_ChangeVel";
            this.button_ChangeVel.Size = new System.Drawing.Size(87, 31);
            this.button_ChangeVel.TabIndex = 3;
            this.button_ChangeVel.Text = "修改速度";
            this.button_ChangeVel.UseVisualStyleBackColor = true;
            this.button_ChangeVel.Click += new System.EventHandler(this.button_ChangeVel_Click);
            // 
            // button_Sstart
            // 
            this.button_Sstart.Location = new System.Drawing.Point(241, 28);
            this.button_Sstart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Sstart.Name = "button_Sstart";
            this.button_Sstart.Size = new System.Drawing.Size(87, 31);
            this.button_Sstart.TabIndex = 3;
            this.button_Sstart.Text = "启动";
            this.button_Sstart.UseVisualStyleBackColor = true;
            this.button_Sstart.Click += new System.EventHandler(this.button_Sstart_Click);
            // 
            // groupBox_Ipl
            // 
            this.groupBox_Ipl.Controls.Add(this.textBox_ixdist);
            this.groupBox_Ipl.Controls.Add(this.textBox_iydist);
            this.groupBox_Ipl.Controls.Add(this.label7);
            this.groupBox_Ipl.Controls.Add(this.label6);
            this.groupBox_Ipl.Controls.Add(this.button5);
            this.groupBox_Ipl.Controls.Add(this.button_Istart);
            this.groupBox_Ipl.Location = new System.Drawing.Point(282, 279);
            this.groupBox_Ipl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Ipl.Name = "groupBox_Ipl";
            this.groupBox_Ipl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Ipl.Size = new System.Drawing.Size(362, 160);
            this.groupBox_Ipl.TabIndex = 5;
            this.groupBox_Ipl.TabStop = false;
            this.groupBox_Ipl.Text = "Interpolation";
            // 
            // textBox_ixdist
            // 
            this.textBox_ixdist.Location = new System.Drawing.Point(85, 48);
            this.textBox_ixdist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ixdist.Name = "textBox_ixdist";
            this.textBox_ixdist.Size = new System.Drawing.Size(116, 23);
            this.textBox_ixdist.TabIndex = 15;
            this.textBox_ixdist.Text = "10000";
            // 
            // textBox_iydist
            // 
            this.textBox_iydist.Location = new System.Drawing.Point(85, 97);
            this.textBox_iydist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_iydist.Name = "textBox_iydist";
            this.textBox_iydist.Size = new System.Drawing.Size(116, 23);
            this.textBox_iydist.TabIndex = 14;
            this.textBox_iydist.Text = "10000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y轴位移";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "X轴位移";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(241, 93);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button_Istart
            // 
            this.button_Istart.Location = new System.Drawing.Point(241, 44);
            this.button_Istart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Istart.Name = "button_Istart";
            this.button_Istart.Size = new System.Drawing.Size(87, 31);
            this.button_Istart.TabIndex = 3;
            this.button_Istart.Text = "启动";
            this.button_Istart.UseVisualStyleBackColor = true;
            this.button_Istart.Click += new System.EventHandler(this.button_Istart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_accTime);
            this.groupBox3.Controls.Add(this.textBox_runSpd);
            this.groupBox3.Controls.Add(this.textBox_begSpd);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(752, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameter set";
            // 
            // textBox_accTime
            // 
            this.textBox_accTime.Location = new System.Drawing.Point(355, 47);
            this.textBox_accTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_accTime.Name = "textBox_accTime";
            this.textBox_accTime.Size = new System.Drawing.Size(116, 23);
            this.textBox_accTime.TabIndex = 16;
            this.textBox_accTime.Text = "0.025";
            // 
            // textBox_runSpd
            // 
            this.textBox_runSpd.Location = new System.Drawing.Point(208, 47);
            this.textBox_runSpd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_runSpd.Name = "textBox_runSpd";
            this.textBox_runSpd.Size = new System.Drawing.Size(116, 23);
            this.textBox_runSpd.TabIndex = 15;
            this.textBox_runSpd.Text = "400000";
            // 
            // textBox_begSpd
            // 
            this.textBox_begSpd.Location = new System.Drawing.Point(61, 47);
            this.textBox_begSpd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_begSpd.Name = "textBox_begSpd";
            this.textBox_begSpd.Size = new System.Drawing.Size(116, 23);
            this.textBox_begSpd.TabIndex = 14;
            this.textBox_begSpd.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.Location = new System.Drawing.Point(508, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 43);
            this.label11.TabIndex = 13;
            this.label11.Text = "维度启用";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "变速时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "运行速度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "起始速度";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(6, 19);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(39, 16);
            this.label_X.TabIndex = 7;
            this.label_X.Text = "label1";
            // 
            // button_SlowStop
            // 
            this.button_SlowStop.Location = new System.Drawing.Point(654, 279);
            this.button_SlowStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_SlowStop.Name = "button_SlowStop";
            this.button_SlowStop.Size = new System.Drawing.Size(87, 31);
            this.button_SlowStop.TabIndex = 9;
            this.button_SlowStop.Text = "减速停";
            this.button_SlowStop.UseVisualStyleBackColor = true;
            this.button_SlowStop.Click += new System.EventHandler(this.button_SlowStop_Click);
            // 
            // button_ImdStop
            // 
            this.button_ImdStop.Location = new System.Drawing.Point(654, 318);
            this.button_ImdStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ImdStop.Name = "button_ImdStop";
            this.button_ImdStop.Size = new System.Drawing.Size(87, 31);
            this.button_ImdStop.TabIndex = 10;
            this.button_ImdStop.Text = "急停";
            this.button_ImdStop.UseVisualStyleBackColor = true;
            this.button_ImdStop.Click += new System.EventHandler(this.button_ImdStop_Click);
            // 
            // button_ZeroPos
            // 
            this.button_ZeroPos.Location = new System.Drawing.Point(654, 240);
            this.button_ZeroPos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ZeroPos.Name = "button_ZeroPos";
            this.button_ZeroPos.Size = new System.Drawing.Size(87, 31);
            this.button_ZeroPos.TabIndex = 11;
            this.button_ZeroPos.Text = "位置清零";
            this.button_ZeroPos.UseVisualStyleBackColor = true;
            this.button_ZeroPos.Click += new System.EventHandler(this.button_ZeroPos_Click);
            // 
            // timer_watching
            // 
            this.timer_watching.Tick += new System.EventHandler(this.timer_watching_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_X);
            this.groupBox4.Location = new System.Drawing.Point(14, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 160);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "X Axis status";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_Y);
            this.groupBox5.Location = new System.Drawing.Point(14, 279);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 160);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Y Axis status";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(6, 19);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(39, 16);
            this.label_Y.TabIndex = 7;
            this.label_Y.Text = "label2";
            // 
            // BasicMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 481);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button_ZeroPos);
            this.Controls.Add(this.button_ImdStop);
            this.Controls.Add(this.button_SlowStop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Ipl);
            this.Controls.Add(this.groupBox_Slg);
            this.Controls.Add(this.button_BackHome);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BasicMove";
            this.Text = "LS2410";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BasicMove_FormClosed);
            this.Load += new System.EventHandler(this.BasicMove_Load);
            this.groupBox_Slg.ResumeLayout(false);
            this.groupBox_Slg.PerformLayout();
            this.groupBox_Ipl.ResumeLayout(false);
            this.groupBox_Ipl.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_BackHome;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox_Slg;
        private System.Windows.Forms.GroupBox groupBox_Ipl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Button button_ChangeVel;
        private System.Windows.Forms.Button button_Sstart;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_Istart;
        private System.Windows.Forms.Button button_SlowStop;
        private System.Windows.Forms.Button button_ImdStop;
        private System.Windows.Forms.TextBox textBox_sspeed;
        private System.Windows.Forms.TextBox textBox_sdist2;
        private System.Windows.Forms.TextBox textBox_sdist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_ChangePos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_ZeroPos;
        private System.Windows.Forms.TextBox textBox_ixdist;
        private System.Windows.Forms.TextBox textBox_iydist;
        private System.Windows.Forms.TextBox textBox_accTime;
        private System.Windows.Forms.TextBox textBox_runSpd;
        private System.Windows.Forms.TextBox textBox_begSpd;
        private System.Windows.Forms.Timer timer_watching;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_Y;
    }
}

