using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單元件。
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MIN_SALARY = 40000m; // 最低年收入
            const int MIN_YEARS = 2; // 最低年資

            decimal salary; // 年收入
            int yearsOnjob; // 年資

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnjob = int.Parse(yearsTextBox.Text);

                // 判斷是否符合貸款資格。

                if(salary >= MIN_SALARY)
                {
                    if(yearsOnjob >= MIN_YEARS)
                    {

                        decisionLabel.Text = "符合貸款資格";


                    }
                    else
                    {
                        decisionLabel.Text = "薪資符合但年資不符合資格";
                    }

                }
                else 
                { 
                
                decisionLabel.Text = "薪資不符合資格";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除薪資、年資與審核結果。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標移回薪資輸入框。
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 表單載入時執行初始化工作。
        }
    }
}
