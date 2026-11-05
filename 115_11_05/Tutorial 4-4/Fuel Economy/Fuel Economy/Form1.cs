using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km; 
            double L;
            double kmpl;


            //km = double.Parse(kmTextBox.Text);
            //L = double.Parse(LTextBox.Text);

            if (double.TryParse(kmTextBox.Text, out km))
            {
                if (double.TryParse(LTextBox.Text, out L)) 
                {
                    if(km > 0 && L > 0)
                    {
                        kmpl = km / L;
                        kmplLabel.Text = kmpl.ToString("F2") + "公里/公升";
                    }
                    else
                    {
                        MessageBox.Show("公里數和公升數必須大於零。");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的公升數。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的公里數。");
            }

                

            



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
