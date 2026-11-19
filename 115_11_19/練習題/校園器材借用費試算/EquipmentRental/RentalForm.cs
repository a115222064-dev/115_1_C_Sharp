using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            label12345.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";

            int days;

            if (int.TryParse(daysTextBox.Text, out days))
            {
                if (days >= 1 && days <= 7)
                {
                    int dailyRate;
                    if (days <= 2)
                    {
                        dailyRate = 80;
                    }
                    else if (days <= 5)
                    {
                        dailyRate = 70;
                    }
                    else
                    {
                        dailyRate = 60;
                    }

                    int discount = 0;
                    if (clubCheckBox.Checked && days >= 3)
                    {
                        discount = 30;
                        label12345.Text = "折抵 30 元";
                    }
                    else if (clubCheckBox.Checked)
                    {
                        label12345.Text = "未達折扣門檻";
                    }
                    else
                    {
                        label12345.Text = "無優惠";
                    }

                    int total = dailyRate * days - discount;
                    dailyRateLabel.Text = dailyRate.ToString();
                    totalLabel.Text = total.ToString();
                    feedbackLabel.Text = "試算完成。";
                }
                else
                {
                    feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                }
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void daysTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            daysTextBox.Clear();
            clubCheckBox.Checked = false;
            feedbackLabel.Text = "";
            dailyRateLabel.Text = "—";
            label12345.Text = "—";
            totalLabel.Text = "—";
        }

        private void clubCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (clubCheckBox.Checked)
            {

            }
            else
            { 
            
            }
        }
    }
}
