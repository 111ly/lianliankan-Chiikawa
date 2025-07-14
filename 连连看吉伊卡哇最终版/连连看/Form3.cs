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
    public partial class 选择游戏难度 : Form
    {
        public int selectedDifficulty { get; set; }
        public 选择游戏难度(Form1 form1)
        {
            InitializeComponent();
        }

        private void Sample_Click(object sender, EventArgs e)
        {
            selectedDifficulty = 0; // 简单难度
            this.Close(); // 关闭当前窗体
        }

        private void General_Click(object sender, EventArgs e)
        {
            selectedDifficulty = 1; // 一般难度
            this.Close(); // 关闭当前窗体
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            selectedDifficulty = 2; // 困难难度
            this.Close(); // 关闭当前窗体
        }
    }
}
