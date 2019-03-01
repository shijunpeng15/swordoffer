/* ****************************************************************
 * Copyright (C) 2018
 * 文件名：
 * 文件功能描述：
 * 
 * 创建标识：时俊鹏-2019/3/1 21:47:19
 * 
 * 修改标识：
 * 修改描述：
 * ***************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class 替换空格
    {
        /*
         请实现一个函数，将一个字符串中的每个空格替换成“%20”。
         例如，当字符串为We Are Happy.则经过替换之后的字符串为We%20Are%20Happy。
         */

        //简单粗暴的
        public string ReplaceSpace(string str)
        {
            var s = str.Replace(" ", "%20"); //新建一个字符串
            return s;
        }

        //此方法比上面的耗时，暂未知Replace源码
        public string ReplaceSpace2(string str)
        {
            var count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            var le = str.Length + (count * 2);   //str.Length - count + (count * 3);
            var c = new char[le];
            var newIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    c[newIndex] = str[i];
                    newIndex++;
                }
                else
                {
                    c[newIndex] = '%';
                    c[++newIndex] = '2';
                    c[++newIndex] = '0';
                    newIndex++;
                }
            }
            return new string(c);
        }

    }
}
