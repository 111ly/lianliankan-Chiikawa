using Microsoft.DirectX.DirectSound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 连连看
{
    internal class ButtonManager
    {
        private GameData gameData;
        private Form1 form1;
        private EliminationRule eliminationRule;
        public void DisableButton(GameData gameData, Form1 form1)
        {
            foreach (Button btn in gameData.buttons)
            {
                btn.Enabled = false;
            }
        }

        public void EnableButton(GameData gameData, Form1 form1)
        {
            foreach (Button btn in gameData.buttons)
            {
                btn.Enabled = true;
            }
        }

        public void GenerateButton(GameData gameData, Form1 form1)
        {
            int n = gameData.number[form1.Difficulty];
            int m = gameData.imageNumber[form1.Level];
            gameData.buttons = new Button[n, n];
            gameData.imageIndex = new int[n, n];
            gameData.visible = new bool[n + 2, n + 2];
            int startX = 200, startY = 75;
            int delta = 600 / n;
            int w = delta - 5;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Button btn = new Button();
                    btn.SetBounds(startX + delta * i, startY + delta * j, w, w);
                    btn.Visible = false;
                    gameData.buttons[i, j] = btn;
                    gameData.visible[i + 1, j + 1] = true;
                    btn.Tag = i * n + j;
                    btn.Click += form1.ButtonClick;
                    form1.Controls.Add(btn);
                }
            }
            int totalNum = n * n;
            Random rnd = new Random();
            while (totalNum > 0)
            {
                int x = rnd.Next(n), y = rnd.Next(n), i = rnd.Next(m);
                Button btn = gameData.buttons[x, y];
                while (btn.Visible)
                {
                    x = rnd.Next(n);
                    y = rnd.Next(n);
                    btn = gameData.buttons[x, y];
                }
                btn.BackgroundImage = gameData.images[i];
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.UseVisualStyleBackColor = true;
                btn.Visible = true;
                gameData.imageIndex[x, y] = i;
                while (btn.Visible)
                {
                    x = rnd.Next(n);
                    y = rnd.Next(n);
                    btn = gameData.buttons[x, y];
                }
                btn.BackgroundImage = gameData.images[i];
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.UseVisualStyleBackColor = true;
                btn.Visible = true;
                gameData.imageIndex[x, y] = i;
                totalNum -= 2;
            }
            gameData.initialed = true;
            gameData.choosedButton = null;
        }

        public void RemoveButton(GameData gameData, Form1 form1)
        {
            foreach (Button btn in gameData.buttons)
            {
                form1.Controls.Remove(btn);
            }
        }

        
    }
}
