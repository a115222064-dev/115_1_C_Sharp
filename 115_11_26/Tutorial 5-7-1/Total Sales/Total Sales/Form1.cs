using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            { 
            StreamReader inputFile;
                decimal total = 0m;

                //inputFile = File.OpenText("Sales.txt");

                

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog1.FileName);
                    while (!inputFile.EndOfStream)
                    {
                        if (decimal.TryParse(inputFile.ReadLine(), out decimal sales))
                        {
                            total += sales;
                        }
                        else
                        {
                            MessageBox.Show("Invalid sales amount in file.");
                            inputFile.Close();
                            return;
                        }
                    }
                    inputFile.Close();
                }
                else
                {
                    MessageBox.Show("No file selected.");
                    return;
                }

                

                
                
                totalLabel.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
