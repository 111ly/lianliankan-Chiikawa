namespace 连连看
{
    partial class 选择游戏难度
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
            this.Hard = new System.Windows.Forms.Button();
            this.General = new System.Windows.Forms.Button();
            this.Sample = new System.Windows.Forms.Button();
            this.GameDifficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Hard.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Hard.Location = new System.Drawing.Point(346, 419);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(215, 62);
            this.Hard.TabIndex = 6;
            this.Hard.Text = "困难";
            this.Hard.UseVisualStyleBackColor = false;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.General.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.General.Location = new System.Drawing.Point(346, 300);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(215, 62);
            this.General.TabIndex = 5;
            this.General.Text = "一般";
            this.General.UseVisualStyleBackColor = false;
            this.General.Click += new System.EventHandler(this.General_Click);
            // 
            // Sample
            // 
            this.Sample.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Sample.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sample.Location = new System.Drawing.Point(346, 197);
            this.Sample.Name = "Sample";
            this.Sample.Size = new System.Drawing.Size(215, 62);
            this.Sample.TabIndex = 4;
            this.Sample.Text = "简单";
            this.Sample.UseVisualStyleBackColor = false;
            this.Sample.Click += new System.EventHandler(this.Sample_Click);
            // 
            // GameDifficulty
            // 
            this.GameDifficulty.AutoSize = true;
            this.GameDifficulty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameDifficulty.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameDifficulty.Location = new System.Drawing.Point(229, 37);
            this.GameDifficulty.Name = "GameDifficulty";
            this.GameDifficulty.Size = new System.Drawing.Size(472, 96);
            this.GameDifficulty.TabIndex = 7;
            this.GameDifficulty.Text = "选择游戏难度";
            // 
            // 选择游戏难度
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 617);
            this.Controls.Add(this.GameDifficulty);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.General);
            this.Controls.Add(this.Sample);
            this.Name = "选择游戏难度";
            this.Text = "连连看小游戏-吉伊卡哇版";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Button General;
        private System.Windows.Forms.Button Sample;
        private System.Windows.Forms.Label GameDifficulty;
    }
}