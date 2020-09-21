using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowCultureDifferences("ru", "en");
            ShowCultureDifferences("ru", "");
            ShowCultureDifferences("en", "");
            Console.ReadKey();
        }

        static void ShowCultureDifferences(string culture1, string culture2)
        {
            var _culture1 = new CultureInfo(culture1);
            var _culture2 = new CultureInfo(culture2);

            if (_culture1.DisplayName.Contains("Неизвестный язык") || _culture2.DisplayName.Contains("Неизвестный язык"))
            { 
                Console.WriteLine("Одна из культур не распознана."); 
            }
            else
            {
                var cultureInfo1 = new List<string>();
                cultureInfo1.Add(_culture1.DisplayName);
                cultureInfo1.Add(_culture1.DateTimeFormat.ShortDatePattern);
                cultureInfo1.Add(_culture1.DateTimeFormat.LongTimePattern);
                cultureInfo1.Add(_culture1.NumberFormat.NumberDecimalSeparator);
                cultureInfo1.Add(_culture1.NumberFormat.NumberGroupSeparator);

                var cultureInfo2 = new List<string>();
                cultureInfo2.Add(_culture2.DisplayName);
                cultureInfo2.Add(_culture2.DateTimeFormat.ShortDatePattern);
                cultureInfo2.Add(_culture2.DateTimeFormat.LongTimePattern);
                cultureInfo2.Add(_culture2.NumberFormat.NumberDecimalSeparator);
                cultureInfo2.Add(_culture2.NumberFormat.NumberGroupSeparator);

                TablePrint(cultureInfo1, cultureInfo2);
            }
        }

        static void TablePrint(List<string> leftCollumn, List<string> rightCollumn)
        {
            const char cellLeftTop = '┌';
            const char cellRightTop = '┐';
            const char cellLeftBottom = '└';
            const char cellRightBottom = '┘';
            const char cellHorizontalJointTop = '┬';
            const char cellHorizontalJointbottom = '┴';
            const char cellVerticalJointLeft = '├';
            const char cellTJoint = '┼';
            const char cellVerticalJointRight = '┤';
            const char cellHorizontalLine = '─';
            

            var table = new List<StringBuilder>();

            int leftWidth = 0;
            int rightWidth = 0;
            foreach (var row in leftCollumn)
            {
                if (row.Length > leftWidth)
                {
                    leftWidth = row.Length;
                }
            }
            foreach (var row in rightCollumn)
            {
                if (row.Length > rightWidth)
                {
                    rightWidth = row.Length;
                }
            }
            int tableHeight = leftCollumn.Count > rightCollumn.Count ? leftCollumn.Count : rightCollumn.Count;

            StringBuilder top = new StringBuilder();
            top.Append(cellLeftTop).Append(cellHorizontalLine, leftWidth).Append(cellHorizontalJointTop).Append(cellHorizontalLine, rightWidth).Append(cellRightTop);
            StringBuilder line = new StringBuilder();
            line.Append(cellVerticalJointLeft).Append(cellHorizontalLine, leftWidth).Append(cellTJoint).Append(cellHorizontalLine, rightWidth).Append(cellVerticalJointRight);
            StringBuilder bottom = new StringBuilder();
            bottom.Append(cellLeftBottom).Append(cellHorizontalLine, leftWidth).Append(cellHorizontalJointbottom).Append(cellHorizontalLine, rightWidth).Append(cellRightBottom);

            Console.WriteLine(top);
            Console.WriteLine(BuildTableRow(leftCollumn[0], leftWidth, rightCollumn[0], rightWidth));
            Console.WriteLine(line);
            for (int i = 1; i < tableHeight; i++)
            {
                Console.WriteLine(BuildTableRow(leftCollumn[i], leftWidth, rightCollumn[i], rightWidth));
            }
            Console.WriteLine(bottom);

        }

        static StringBuilder BuildTableRow(string leftWord, int leftWidth, string rightWord, int rightWidth)
        {
            const char cellVerticalLine = '│';

            int leftWordleftSpace = (leftWidth - leftWord.Length) / 2;
            int leftWordRightSpace = leftWidth - leftWordleftSpace - leftWord.Length;
            int rightWordleftSpace = (rightWidth - rightWord.Length) / 2;
            int rightWordRightSpace = rightWidth - rightWordleftSpace - rightWord.Length;
            var result = new StringBuilder();
            result.Append(cellVerticalLine).Append(' ', leftWordleftSpace).Append(leftWord).Append(' ', leftWordRightSpace)
                .Append(cellVerticalLine).Append(' ', rightWordleftSpace).Append(rightWord).Append(' ', rightWordRightSpace)
                .Append(cellVerticalLine);
            return result;
        }
    }
}
