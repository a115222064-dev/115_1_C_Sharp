using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    // 定義應用程式的啟動類別。
    static class Program
    {
        // 應用程式的主要進入點。
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows 樣式的視覺效果。
            Application.EnableVisualStyles();
            // 設定控制項使用預設的文字呈現方式。
            Application.SetCompatibleTextRenderingDefault(false);
            // 啟動特價計算器主視窗。
            Application.Run(new Form1());
        }
    }
}
