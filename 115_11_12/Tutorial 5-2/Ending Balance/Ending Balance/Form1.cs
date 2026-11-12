using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有元件。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal RATE = 0.005m; // 每月利息率為 0.5%
            decimal balance;
            int months;

            

            if(decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                if(int.TryParse(monthsTextBox.Text, out months))
                {
                    int count = 1;
                    while (count <= months)
                    {
                        balance = balance * (1 + RATE); // 每月利息為 0.5%
                        detailListBox.Items.Add($"第 {count} 個月的本利和: {balance:C2}");
                        count = count + 1;
                    }
                    
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數。");
                    monthsTextBox.Focus();
                    return;
                }

            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額。");
                startingBalTextBox.Focus();
                return;
            }
            endingBalanceLabel.Text = balance.ToString("C2"); // 顯示最終的本利和
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除輸入框、結餘標籤及明細清單的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 清除後將游標移回起始餘額輸入框。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
