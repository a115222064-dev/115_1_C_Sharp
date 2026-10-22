using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    // 定義特價計算器的主要視窗。
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有介面元件。
        public Form1()
        {
            InitializeComponent();
        }

        // 處理「計算售價」按鈕的按下事件。
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告原價、折扣百分比與計算後售價的變數。
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            // 讀取使用者輸入的商品原價。
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            // 讀取使用者輸入的折扣百分比。
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
            // 使用原價扣除折扣金額，計算折扣後售價。
            salePrice = originalPrice - (originalPrice * discountPercentage / 100);
            // 將計算結果以貨幣格式顯示在售價標籤中。
            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 處理「離開」按鈕的按下事件。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
