using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 连连看
{
    internal class GameInitializer
    {
        public static void InitializeGame(Form1 form,GameData gameData)
        {
            form.Width = 1000;
            form.Height = 800;

            gameData.number = new int[3] { 10, 12, 14 };
            gameData.imageNumber = new int[5] { 9, 10, 11, 12, 13 };
            gameData.sdifficulty = new string[3] { "简单", "一般", "困难" };

            form.Difficulty = 0;
            form.Level = 0;
            form.Time = 180 - form.Level * 20;
            form.pBar.Maximum = 180 - form.Level * 20;

            DirectoryInfo dir = new DirectoryInfo(string.Format(Application.StartupPath));
            string[] path = Directory.GetFiles(dir.Parent.Parent.GetDirectories("images")[0].FullName, "*.png");
            int len = path.Length;
            gameData.images = new Image[len];
            for (int i = 0; i < len; ++i)
            {
                gameData.images[i] = Image.FromFile(path[i]);
            }

            form.timer1.Enabled = false;
            form.RestTime.SetBounds(50, 30, 143, 63);
            form.pBar.SetBounds(200, 30, 600, 25);
            form.HighestScore.SetBounds(50, 130, 100, 25);
            form.CurScore.SetBounds(50, 230, 100, 25);
            form.CurDifficluty.SetBounds(50, 330, 100, 25);
            form.CurLevel.SetBounds(50, 430, 100, 25);
            form.MusicOnOff.SetBounds(50, 530, 100, 25);
            form.Start.SetBounds(850, 130, 100, 25);
            form.Pause.SetBounds(850, 230, 100, 25);
            form.Continue.SetBounds(850, 330, 100, 25);
            form.End.SetBounds(850, 430, 100, 25);
            form.Chart.SetBounds(850, 542, 112, 90);

            gameData.backGround = new SoundPlayer(global::连连看.Properties.Resources.背景音效);
            if (form.MusicOnOff.Checked)
                gameData.backGround.PlayLooping();
            gameData.godMode = false;//默认关闭无敌模式
        }
    }
}
