using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單元件。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 設定高分與及格分數的標準。
            const double HIGH_SCORE = 95.0;

            const double PASSING_SCORE = 60.0;

            // 宣告三次成績、平均分數及等級變數。
            double test1, test2, test3, average;
            string grade;

            try
            {
                // 讀取三次測驗成績並轉換為數字。
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三次測驗的平均分數。
                average = (test1 + test2 + test3) / 3.0;

                // 將平均分數顯示到標籤，並保留一位小數。
                averageLabel.Text = average.ToString("n1");

                if ()

                // 顯示成績等級。
                MessageBox.Show($"成績等級 : {grade}");

            }

            catch (Exception ex)
            {
                // 輸入資料格式錯誤時顯示錯誤訊息。
                MessageBox.Show(ex.Message);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三次成績與平均分數。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 將輸入焦點移回第一個成績欄位。
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
