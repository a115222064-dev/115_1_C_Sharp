using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;
            if (cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
                switch (city)
                {
                    case "紐約":
                        timeZoneLabel.Text = "紐約的時區是東部標準時間（EST）。";
                        break;
                    case "舊金山":
                        timeZoneLabel.Text = "舊金山的時區是太平洋標準時間（PST）。";
                        break;
                    case "明尼阿波利斯":
                        timeZoneLabel.Text = "明尼阿波利斯的時區是中部標準時間（CST）。";
                        break;
                    case "檀香山":
                        timeZoneLabel.Text = "檀香山的時區是夏威夷－阿留申標準時間（HST）。";
                        break;
                    case "丹佛":
                        timeZoneLabel.Text = "丹佛的時區是山區標準時間（MST）。";
                        break;
                    default:
                        MessageBox.Show("請從清單中選擇城市。");
                        break;
                }
            }
            else
            {
                MessageBox.Show("請從清單中選擇城市。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
