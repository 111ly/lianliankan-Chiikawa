using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 连连看
{
    public partial class 排行榜 : Form
    {
        private List<Player> leaderboard;

        public 排行榜()
        {
            InitializeComponent();
        }

        private void InitializeListBox()
        {
            listBox1.DrawMode = DrawMode.OwnerDrawFixed; // 设置绘制模式为OwnerDrawFixed
            listBox1.DrawItem += ListBox_DrawItem; // 订阅绘制项事件
            listBox1.ItemHeight = 40;

        }
        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {

            if (e.Index < 0) return;

            e.DrawBackground();
            e.DrawFocusRectangle();

            // 获取文本
            string text = listBox1.Items[e.Index].ToString();


            // 获取文本尺寸
            Size textSize = TextRenderer.MeasureText(text, e.Font);

            // 计算文本居中的位置
            int x = (listBox1.Width - textSize.Width) / 2;
            int y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            // 绘制文本
            e.Graphics.DrawString(text, e.Font, new SolidBrush(e.ForeColor), x, y);


        }
        private void InitializeLeaderboard()
        {
            // 初始化排行榜
            leaderboard = new List<Player>
            {
                new Player("cd", 165),
                new Player("lcy", 190),
                new Player("ljs", 180),
                new Player("ly", 170),
                new Player("lsq", 160),
                new Player("whq", 200)
            };
            leaderboard.Add(new Player("youscore", (int)this.Tag));

            // 显示排行榜
            DisplayLeaderboard();
        }
        private void DisplayLeaderboard()
        {
            // 清空列表框
            listBox1.Items.Clear();
            // 绘制背景图像

            listBox1.Font = new Font("Arial", 12, FontStyle.Bold);
            // 使用Sort方法按Age属性排序
            leaderboard.Sort((p1, p2) => p2.Score.CompareTo(p1.Score));
            // 添加排行榜中的每个玩家
            listBox1.Items.Add("游戏分数排行榜");
            listBox1.Items.Add($"{"名次".PadRight(9)}   {"用户名".PadRight(10)}    {"分数"}");
            for (int i = 0; i < leaderboard.Count; i++)
            {
                // 将带有序号的字符串添加到 ListBox 中
                listBox1.Items.Add($"{i + 1}              {leaderboard[i].Name.PadRight(10)}:     {leaderboard[i].Score.ToString().PadLeft(10)}");
            }
        }
        private void 排行榜_Load(object sender, EventArgs e)
        {
            InitializeLeaderboard();
            InitializeListBox();
        }
    }
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return $"{Name}:    {Score}";
        }
    }
}
