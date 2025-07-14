using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 连连看
{
    public class GameData
    {
        public int[] number;//每行(每列)图片的数量
        public int[] imageNumber;//不同关卡使用的图片数量
        public string[] sdifficulty;//存储难度(简单、一般、困难)的字符串
        public Button[,] buttons;//按钮
        public Image[] images;//图片文件
        public int difficulty;//难度的下标，0：简单，1：一般，2：困难
        public int level;//关卡等级:0,1,2,3,4
        public int time;//剩余时间
        public int score;//当前得分
        public int maxScore;//最高分
        public int totalNumber;//总的按钮个数
        public int removedNumber;//已经消除的按钮个数
        public bool initialed;//界面是否初始化，Score发生改变或者End按钮事件触发时，initialed都置为false，下一次开始时需要重新加载，GenerateButton函数会把initialed置为true。
        public Button choosedButton;//第一次选中的按钮
        public int[,] imageIndex;//存储每个按钮对应的图片的下标
        public bool[,] visible;//存储每个按钮是否可见(未消除)，但是还要在buttons周围加一圈，方便计算是否可达
        public SoundPlayer backGround;//背景音乐
        public bool godMode;//无敌模式开关
    }
}
