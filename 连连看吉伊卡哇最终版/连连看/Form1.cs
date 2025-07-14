using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Media;
using Microsoft.DirectX.DirectSound;

namespace 连连看
{
    
    public partial class Form1 : Form
    {
        private GameData gameData;
        private EliminationRule eliminationRule;
        private ButtonManager buttonManager;
        

        #region 定义难度等级，关卡等级，剩余时间，当前得分，最高分
        public int Difficulty
        {
            get
            {
                return gameData.difficulty;
            }
            set
            {
                if (value != gameData.difficulty)
                {
                    gameData.difficulty = value;
                    this.CurDifficluty.Text = "难度：" + gameData.sdifficulty[gameData.difficulty];
                    buttonManager.RemoveButton(gameData, this);
                    buttonManager.GenerateButton(gameData, this);
                    buttonManager.DisableButton(gameData, this);
                }
            }
        }
        
        public int Level
        {
            get
            {
                return gameData.level;
            }
            set
            {
                if (value != gameData.level)
                {
                    gameData.level = value;
                    this.pBar.Maximum = 180 - 20 * gameData.level;
                    this.CurLevel.Text = "当前关卡：" + (gameData.level + 1);
                    buttonManager.RemoveButton(gameData, this);
                    buttonManager.GenerateButton(gameData, this);
                    buttonManager.DisableButton(gameData, this);
                }
            }
        }
        
        public int Time
        {
            get
            {
                return gameData.time;
            }
            set
            {
                gameData.time = value;
                this.RestTime.Text = "剩余时间：" + gameData.time + "s";
                this.pBar.Value = gameData.time;
            }
        }
        
        public int Score
        {
            get
            {
                return gameData.score;
            }
            set
            {
                if (value != gameData.score)
                    gameData.initialed = false;
                gameData.score = value;
                this.CurScore.Text = "当前得分：" + gameData.score;
                if (gameData.score > MaxScore)
                {
                    MaxScore = gameData.score;
                }
            }
        }
        
        public int MaxScore
        {
            get
            {
                return gameData.maxScore;
            }
            set
            {
                gameData.maxScore = value;
                this.HighestScore.Text = "最高分：" + gameData.maxScore;
            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
            gameData = new GameData();
            buttonManager = new ButtonManager(); // 初始化按钮管理器
            eliminationRule = new EliminationRule();
        }
        #region 窗体事件
        private void Form1_Load(object sender, EventArgs e)
        {
            GameInitializer.InitializeGame(this, gameData); // 传入gameData进行初始化游戏           
            buttonManager.GenerateButton(gameData, this); // 传入gameData和form1进行按钮生成
            buttonManager.DisableButton(gameData, this);

            选择游戏难度 form3 = new 选择游戏难度(this);
            form3.ShowDialog(); // 显示 Form3 窗体并等待用户选择完成
            int selectedDifficulty = form3.selectedDifficulty; // 获取用户选择的难度值
            if (selectedDifficulty >= 0 && selectedDifficulty <= 2)
            {
                Difficulty = selectedDifficulty;
            }
            form3.Dispose(); // 释放 Form3 窗体资源




            if (File.Exists("maxScore.txt"))
            {
                using (StreamReader sr = new StreamReader("maxScore.txt"))
                {
                    if (int.TryParse(sr.ReadLine(), out int maxScore))
                        MaxScore = maxScore;
                    else
                        MaxScore = 0;
                }
            }
            else
            {
                MaxScore = 0;
            }
            // 创建无敌模式按钮并添加到菜单栏
            ToolStripButton godModeButton = new ToolStripButton("无敌模式");
            godModeButton.Click += new EventHandler(GodModeButton_Click);
            menuStrip1.Items.Add(godModeButton);

            // 初始化无敌模式按钮的状态
            godModeButton.Checked = gameData.godMode;

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!gameData.initialed)
            {
                buttonManager.RemoveButton(gameData, this);
                buttonManager.GenerateButton(gameData, this);
            }
            gameData.totalNumber = gameData.number[Difficulty] * gameData.number[Difficulty];
            gameData.removedNumber = 0;
            Time = 180 - Level * 20;
            Score = 0;
            buttonManager.EnableButton(gameData, this);
            timer1.Enabled = true;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            buttonManager.DisableButton(gameData, this);
            timer1.Enabled = false;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            buttonManager.EnableButton(gameData, this);
            timer1.Enabled = true;
        }

        private void End_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("您的最终得分为" + Score + "!", "游戏结束");
            gameData.initialed = false;
            Level = 0;
            Score = 0;
            Time = 180 - 20 * Level;
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time > 0 && gameData.removedNumber < gameData.totalNumber)
            {
                --Time;
            }
            else if (gameData.removedNumber == gameData.totalNumber && Level < 4)
            {
                if (MusicOnOff.Checked)
                {
                    SecondaryBuffer secBuffer;//缓冲区对象    
                    Device secDev;//设备对象    
                    secDev = new Device();
                    secDev.SetCooperativeLevel(this, CooperativeLevel.Normal);//设置设备协作级别    
                    secBuffer = new SecondaryBuffer(global::连连看.Properties.Resources.通关音效, secDev);//创建辅助缓冲区    
                    secBuffer.Play(0, BufferPlayFlags.Default);//设置缓冲区为默认播放   
                }
                Score += (Difficulty + Level + 1) * Time;//奖励剩余时间对应的分数
                timer1.Enabled = false;
                DialogResult dr = MessageBox.Show("恭喜您通过本关，点击确定进入下一关，点击取消将退出本局游戏", "通关啦！分数加成" + (Difficulty + Level + 1) * Time, MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    ++Level;
                    buttonManager.EnableButton(gameData, this);
                    gameData.totalNumber = gameData.number[Difficulty] * gameData.number[Difficulty];
                    gameData.removedNumber = 0;
                    Time = 180 - Level * 20;
                    timer1.Enabled = true;
                }
                else if (dr == DialogResult.Cancel)
                {
                    End.PerformClick();
                }
            }
            else
            {
                End.PerformClick();
            }
        }

        private void 简单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Difficulty = 0;
        }

        private void 一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Difficulty = 1;
        }

        private void 困难ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Difficulty = 2;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Level = 0;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Level = 1;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Level = 2;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Level = 3;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Level = 4;
        }
        private void MusicOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (MusicOnOff.Checked)
            {
                gameData.backGround.PlayLooping();
            }
            else
            {
                gameData.backGround.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists("maxScore.txt"))
                File.Create("maxScore.txt");
            using (StreamWriter sw = new StreamWriter("maxScore.txt"))
            {
                sw.WriteLine(MaxScore);
            }
        }
        public void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (gameData.choosedButton == null)
            {
                gameData.choosedButton = btn;
                btn.Focus();
            }
            else
            {
                int n = gameData.number[Difficulty];
                int tag1 = int.Parse(gameData.choosedButton.Tag.ToString());
                int tag2 = int.Parse(btn.Tag.ToString());
                int x1 = tag1 / n, y1 = tag1 % n;
                int x2 = tag2 / n, y2 = tag2 % n;
                if (gameData.godMode)
                {
                    // 在无敌模式下，允许消除任意两个不同的图片
                    if (!(x1 == x2 && y1 == y2))
                    {
                        if (MusicOnOff.Checked)
                        {
                            SecondaryBuffer secBuffer;//缓冲区对象    
                            Device secDev;//设备对象    
                            secDev = new Device();
                            secDev.SetCooperativeLevel(this, CooperativeLevel.Normal);//设置设备协作级别    
                            secBuffer = new SecondaryBuffer(global::连连看.Properties.Resources.消除音效, secDev);//创建辅助缓冲区    
                            secBuffer.Play(0, BufferPlayFlags.Default);//设置缓冲区为默认播放   
                        }
                        gameData.choosedButton.Visible = false;
                        btn.Visible = false;
                        gameData.visible[x1 + 1, y1 + 1] = false;
                        gameData.visible[x2 + 1, y2 + 1] = false;
                        gameData.removedNumber += 2;
                        Score += (Difficulty + Level + 1) * 2;
                        gameData.choosedButton = null;
                    }
                }

                if(!gameData.godMode)
                {
                    if (!(x1 == x2 && y1 == y2) && gameData.imageIndex[x1, y1] == gameData.imageIndex[x2, y2] && eliminationRule.IsArrivable(x1, y1, x2, y2, gameData, this))
                    {
                        if (MusicOnOff.Checked)
                        {
                            SecondaryBuffer secBuffer;//缓冲区对象    
                            Device secDev;//设备对象    
                            secDev = new Device();
                            secDev.SetCooperativeLevel(this, CooperativeLevel.Normal);//设置设备协作级别    
                            secBuffer = new SecondaryBuffer(global::连连看.Properties.Resources.消除音效, secDev);//创建辅助缓冲区    
                            secBuffer.Play(0, BufferPlayFlags.Default);//设置缓冲区为默认播放   
                        }
                        gameData.choosedButton.Visible = false;
                        btn.Visible = false;
                        gameData.visible[x1 + 1, y1 + 1] = false;
                        gameData.visible[x2 + 1, y2 + 1] = false;
                        gameData.removedNumber += 2;
                        Score += (Difficulty + Level + 1) * 2;
                        gameData.choosedButton = null;
                    }
                    else
                    {
                        if (MusicOnOff.Checked)
                        {
                            SecondaryBuffer secBuffer;//缓冲区对象    
                            Device secDev;//设备对象    
                            secDev = new Device();
                            secDev.SetCooperativeLevel(this, CooperativeLevel.Normal);//设置设备协作级别    
                            secBuffer = new SecondaryBuffer(global::连连看.Properties.Resources.消除失败音效, secDev);//创建辅助缓冲区    
                            secBuffer.Play(0, BufferPlayFlags.Default);//设置缓冲区为默认播放   
                        }
                        gameData.choosedButton = null;
                    }
                }
            }
        }
        private void Chart_Click(object sender, EventArgs e)
        {
            排行榜 form2 = new 排行榜();
            form2.Tag = Score;
            form2.ShowDialog();
        }
        #endregion
        private void ToggleGodMode()
        {
            gameData.godMode = !gameData.godMode;
            if (gameData.godMode)
            {
                // 开启无敌模式
                MessageBox.Show("无敌模式已开启！");
            }
            else
            {
                // 关闭无敌模式
                MessageBox.Show("无敌模式已关闭！");
            }

        }

        private void GodModeButton_Click(object sender, EventArgs e)
        {
            ToggleGodMode();
        }

    }
}
