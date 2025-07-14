namespace 连连看
{
    partial class Form1
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
            this.Continue = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.HighestScore = new System.Windows.Forms.Label();
            this.CurScore = new System.Windows.Forms.Label();
            this.RestTime = new System.Windows.Forms.Label();
            this.CurDifficluty = new System.Windows.Forms.Label();
            this.CurLevel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选择难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一般ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.困难ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择关卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.End = new System.Windows.Forms.Button();
            this.MusicOnOff = new System.Windows.Forms.CheckBox();
            this.pBar = new 连连看.NewProgressBar();
            this.Chart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.LightYellow;
            this.Continue.Location = new System.Drawing.Point(900, 330);
            this.Continue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(112, 30);
            this.Continue.TabIndex = 1;
            this.Continue.Text = "继续";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.LightBlue;
            this.Pause.Location = new System.Drawing.Point(900, 230);
            this.Pause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(112, 30);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "暂停";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.YellowGreen;
            this.Start.Location = new System.Drawing.Point(900, 130);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 30);
            this.Start.TabIndex = 3;
            this.Start.Text = "开始";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // HighestScore
            // 
            this.HighestScore.BackColor = System.Drawing.Color.LemonChiffon;
            this.HighestScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HighestScore.Font = new System.Drawing.Font("宋体", 9F);
            this.HighestScore.Location = new System.Drawing.Point(56, 156);
            this.HighestScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HighestScore.Name = "HighestScore";
            this.HighestScore.Size = new System.Drawing.Size(112, 30);
            this.HighestScore.TabIndex = 4;
            this.HighestScore.Text = "最高分：";
            this.HighestScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurScore
            // 
            this.CurScore.BackColor = System.Drawing.Color.PaleGreen;
            this.CurScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurScore.Location = new System.Drawing.Point(56, 276);
            this.CurScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurScore.Name = "CurScore";
            this.CurScore.Size = new System.Drawing.Size(112, 30);
            this.CurScore.TabIndex = 5;
            this.CurScore.Text = "当前得分：";
            this.CurScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RestTime
            // 
            this.RestTime.BackColor = System.Drawing.Color.PaleTurquoise;
            this.RestTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RestTime.Font = new System.Drawing.Font("宋体", 12F);
            this.RestTime.Location = new System.Drawing.Point(56, 36);
            this.RestTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestTime.Name = "RestTime";
            this.RestTime.Size = new System.Drawing.Size(140, 63);
            this.RestTime.TabIndex = 6;
            this.RestTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurDifficluty
            // 
            this.CurDifficluty.BackColor = System.Drawing.Color.Thistle;
            this.CurDifficluty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurDifficluty.Location = new System.Drawing.Point(56, 400);
            this.CurDifficluty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurDifficluty.Name = "CurDifficluty";
            this.CurDifficluty.Size = new System.Drawing.Size(112, 30);
            this.CurDifficluty.TabIndex = 7;
            this.CurDifficluty.Text = "难度：简单";
            this.CurDifficluty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurLevel
            // 
            this.CurLevel.BackColor = System.Drawing.Color.DarkKhaki;
            this.CurLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurLevel.Location = new System.Drawing.Point(56, 516);
            this.CurLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurLevel.Name = "CurLevel";
            this.CurLevel.Size = new System.Drawing.Size(112, 30);
            this.CurLevel.TabIndex = 8;
            this.CurLevel.Text = "当前关卡：1";
            this.CurLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择难度ToolStripMenuItem,
            this.选择关卡ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1069, 32);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选择难度ToolStripMenuItem
            // 
            this.选择难度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简单ToolStripMenuItem,
            this.一般ToolStripMenuItem,
            this.困难ToolStripMenuItem});
            this.选择难度ToolStripMenuItem.Name = "选择难度ToolStripMenuItem";
            this.选择难度ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.选择难度ToolStripMenuItem.Text = "选择难度";
            // 
            // 简单ToolStripMenuItem
            // 
            this.简单ToolStripMenuItem.Name = "简单ToolStripMenuItem";
            this.简单ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.简单ToolStripMenuItem.Text = "简单";
            this.简单ToolStripMenuItem.Click += new System.EventHandler(this.简单ToolStripMenuItem_Click);
            // 
            // 一般ToolStripMenuItem
            // 
            this.一般ToolStripMenuItem.Name = "一般ToolStripMenuItem";
            this.一般ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.一般ToolStripMenuItem.Text = "一般";
            this.一般ToolStripMenuItem.Click += new System.EventHandler(this.一般ToolStripMenuItem_Click);
            // 
            // 困难ToolStripMenuItem
            // 
            this.困难ToolStripMenuItem.Name = "困难ToolStripMenuItem";
            this.困难ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.困难ToolStripMenuItem.Text = "困难";
            this.困难ToolStripMenuItem.Click += new System.EventHandler(this.困难ToolStripMenuItem_Click);
            // 
            // 选择关卡ToolStripMenuItem
            // 
            this.选择关卡ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.选择关卡ToolStripMenuItem.Name = "选择关卡ToolStripMenuItem";
            this.选择关卡ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.选择关卡ToolStripMenuItem.Text = "选择关卡";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 34);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 34);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(121, 34);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(121, 34);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(121, 34);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.Color.Red;
            this.End.Location = new System.Drawing.Point(900, 415);
            this.End.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(112, 30);
            this.End.TabIndex = 10;
            this.End.Text = "结束";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // MusicOnOff
            // 
            this.MusicOnOff.Location = new System.Drawing.Point(56, 602);
            this.MusicOnOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MusicOnOff.Name = "MusicOnOff";
            this.MusicOnOff.Size = new System.Drawing.Size(112, 30);
            this.MusicOnOff.TabIndex = 11;
            this.MusicOnOff.Text = "开启音效";
            this.MusicOnOff.UseVisualStyleBackColor = true;
            this.MusicOnOff.CheckedChanged += new System.EventHandler(this.MusicOnOff_CheckedChanged);
            // 
            // pBar
            // 
            this.pBar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pBar.Location = new System.Drawing.Point(221, 36);
            this.pBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBar.Maximum = 180;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(675, 30);
            this.pBar.Step = 0;
            this.pBar.TabIndex = 0;
            this.pBar.Value = 180;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.SystemColors.Info;
            this.Chart.Location = new System.Drawing.Point(900, 542);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(112, 90);
            this.Chart.TabIndex = 12;
            this.Chart.Text = "排行榜";
            this.Chart.UseVisualStyleBackColor = false;
            this.Chart.Click += new System.EventHandler(this.Chart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 904);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.MusicOnOff);
            this.Controls.Add(this.End);
            this.Controls.Add(this.CurLevel);
            this.Controls.Add(this.CurDifficluty);
            this.Controls.Add(this.RestTime);
            this.Controls.Add(this.CurScore);
            this.Controls.Add(this.HighestScore);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "连连看小游戏-吉伊卡哇版";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选择难度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一般ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 困难ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择关卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        public System.Windows.Forms.CheckBox MusicOnOff;
        public NewProgressBar pBar;
        public System.Windows.Forms.Button Continue;
        public System.Windows.Forms.Button Pause;
        public System.Windows.Forms.Button Start;
        public System.Windows.Forms.Label HighestScore;
        public System.Windows.Forms.Label CurScore;
        public System.Windows.Forms.Label RestTime;
        public System.Windows.Forms.Label CurDifficluty;
        public System.Windows.Forms.Label CurLevel;
        public System.Windows.Forms.Button End;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button Chart;
    }
}

