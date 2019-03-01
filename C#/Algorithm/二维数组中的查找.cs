/* ****************************************************************
 * Copyright (C) 2018
 * 文件名：
 * 文件功能描述：
 * 
 * 创建标识：时俊鹏-2019/3/1 21:08:14
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
    public class 二维数组中的查找
    {
        /*
         在一个二维数组中（每个一维数组的长度相同），每一行都按照从左到右递增的顺序排序，
         每一列都按照从上到下递增的顺序排序。请完成一个函数，输入这样的一个二维数组和一个整数，
         判断数组中是否含有该整数。

            1  2   3  4  5
            2  3   4  5  6
            3  4   5  6  7
            4  5   6  7  8
         */

        /*思路：
         * 从右上角开始比较，如果target大于右上角的值 5 ，则按照该二维数组的规律，target必在其下行，因此需要向下一行再比较右上角  6   row++
         * 如果target小于右上角的值，则按照规律，target必在其左行，因此需要向左一行再比较右上角， col--
         * 直至相等为止
         */

        public bool Find(int target, int[][] array)
        {
            int row = 0; //行                 
            int col = array[0].Length - 1; //列数      
            while (row <= array.Length - 1 && col >= 0)
            {
                if (target == array[row][col])  //从右上角开始比较  
                {
                    return true;
                }
                else if (target > array[row][col])
                {
                    row++;   //
                }
                else
                {
                    col--;
                }
            }
            return false;
        }



    }
}
