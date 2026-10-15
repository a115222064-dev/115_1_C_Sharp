using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    // 主表單類別：處理使用者輸入並顯示組合後的出生日期字串
    public partial class Form1 : Form
    {
        // 建構子：初始化表單與其元件
        public Form1()
        {
            InitializeComponent();
        }

        // 按下「顯示日期」按鈕時的事件處理函式
        // 會將四個輸入欄位的文字組合成一個可讀的日期字串並顯示在輸出標籤
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 使用者輸入的各欄位組合成一個輸出字串
            // 範例輸出格式: "星期, 月份 日, 年份"（例如："Monday, January 1, 2000"）
            string output;

            output = dayOfWeekTextBox.Text + ", " + monthTextBox.Text + " " + dayOfMonthTextBox.Text + ", " + yearTextBox.Text;

            // 將組合好的字串放到畫面上的 label 顯示
            dateOutputLabel.Text = output;
        }

        // 按下「清除」按鈕時的事件處理函式
        // 會清空所有輸入欄位與輸出標籤的內容
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空輸入欄位
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";

            // 清空輸出顯示
            dateOutputLabel.Text = "";
        }

        // 按下「結束」按鈕時的事件處理函式
        // 關閉目前表單（結束應用程式的視窗）
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // dateOutputLabel 的 Click 事件，目前未使用但保留以免設計工具移除事件綁定
        private void dateOutputLabel_Click(object sender, EventArgs e)
        {
            // 此處暫時不執行任何動作
        }
    }
}
