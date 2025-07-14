using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 连连看
{
    internal class EliminationRule
    {
        private bool IsArrivable0(int x1, int y1, int x2, int y2, GameData gameData,Form1 form1)//直线可达
        {
            int n = gameData.number[form1.Difficulty];
            if (x1 == x2)
            {
                if (y1 < y2)
                {
                    for (int y = y1 + 1; y < y2; ++y)
                    {
                        if (gameData.visible[x1, y])
                            return false;
                    }
                    return true;
                }
                else
                {
                    for (int y = y1 - 1; y > y2; --y)
                    {
                        if (gameData.visible[x1, y])
                            return false;
                    }
                    return true;
                }
            }
            else if (y1 == y2)
            {
                if (x1 < x2)
                {
                    for (int x = x1 + 1; x < x2; ++x)
                    {
                        if (gameData.visible[x, y1])
                            return false;
                    }
                    return true;
                }
                else
                {
                    for (int x = x1 - 1; x > x2; --x)
                    {
                        if (gameData.visible[x, y1])
                            return false;
                    }
                    return true;
                }
            }
            else
                return false;
        }

        private bool IsArrivable1(int x1, int y1, int x2, int y2, GameData gameData, Form1 form1)//拐一个角可达
        {
            int n = gameData.number[form1.Difficulty];
            for (int i = 0; i < n + 2; ++i)
            {
                if (i == x1)
                    continue;
                if (!gameData.visible[i, y1] && IsArrivable0(x1, y1, i, y1, gameData, form1) && IsArrivable0(x2, y2, i, y1, gameData, form1))
                    return true;
            }
            for (int i = 0; i < n + 2; ++i)
            {
                if (i == y1)
                    continue;
                if (!gameData.visible[x1, i] && IsArrivable0(x1, y1, x1, i, gameData, form1) && IsArrivable0(x2, y2, x1, i, gameData, form1))
                    return true;
            }
            return false;
        }

        private bool IsArrivable2(int x1, int y1, int x2, int y2, GameData gameData, Form1 form1)//拐两个角可达
        {
            int n = gameData.number[form1.Difficulty];
            for (int i = 0; i < n + 2; ++i)
            {
                if (i == x1)
                    continue;
                if (!gameData.visible[i, y1] && IsArrivable0(x1, y1, i, y1, gameData, form1) && IsArrivable1(x2, y2, i, y1, gameData, form1))
                    return true;
            }
            for (int i = 0; i < n + 2; ++i)
            {
                if (i == y1)
                    continue;
                if (!gameData.visible[x1, i] && IsArrivable0(x1, y1, x1, i, gameData, form1) && IsArrivable1(x2, y2, x1, i, gameData, form1))
                    return true;
            }
            return false;
        }

        public bool IsArrivable(int x1, int y1, int x2, int y2, GameData gameData, Form1 form1)
        {
            int n = gameData.number[form1.Difficulty];
            return IsArrivable0(x1 + 1, y1 + 1, x2 + 1, y2 + 1,gameData, form1)
                || IsArrivable1(x1 + 1, y1 + 1, x2 + 1, y2 + 1, gameData, form1)
                || IsArrivable2(x1 + 1, y1 + 1, x2 + 1, y2 + 1, gameData, form1);
        }
    }
}
