using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 建立表單上的所有控制項
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // 設定速度轉換的起始值、結束值與間隔
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;

            // 設定英里與公里之間的換算比例
            const double CONVERSION_FACTOR = 0.6214;

            int kmh;
            double mph;

            // 清空 ListBox 以便顯示新的結果
            outputListBox.Items.Clear();

            // 按下按鈕後顯示速度轉換結果
            for (kmh = START_SPEED; kmh <= END_SPEED; kmh += INTERVAL)
            {
               mph = kmh * CONVERSION_FACTOR;
               outputListBox.Items.Add($"{kmh} 公里/小時 = {mph:F2} 英里/小時");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉速度轉換器視窗
            this.Close();
        }
    }
}