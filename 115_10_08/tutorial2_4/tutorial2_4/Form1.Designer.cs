namespace tutorial2_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.finlandPictureBox = new System.Windows.Forms.PictureBox();
            this.germanPictureBox = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.countryLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // finlandPictureBox
            // 
            this.finlandPictureBox.Image = global::tutorial2_4.Properties.Resources.Finland;
            this.finlandPictureBox.Location = new System.Drawing.Point(54, 255);
            this.finlandPictureBox.Name = "finlandPictureBox";
            this.finlandPictureBox.Size = new System.Drawing.Size(328, 164);
            this.finlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandPictureBox.TabIndex = 0;
            this.finlandPictureBox.TabStop = false;
            this.finlandPictureBox.Click += new System.EventHandler(this.finlandPictureBox_Click);
            // 
            // germanPictureBox
            // 
            this.germanPictureBox.Image = global::tutorial2_4.Properties.Resources.Germany;
            this.germanPictureBox.Location = new System.Drawing.Point(890, 255);
            this.germanPictureBox.Name = "germanPictureBox";
            this.germanPictureBox.Size = new System.Drawing.Size(343, 164);
            this.germanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanPictureBox.TabIndex = 1;
            this.germanPictureBox.TabStop = false;
            this.germanPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.Image = global::tutorial2_4.Properties.Resources.France;
            this.francePictureBox.Location = new System.Drawing.Point(462, 255);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(363, 163);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francePictureBox.TabIndex = 2;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // countryLable
            // 
            this.countryLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLable.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLable.Location = new System.Drawing.Point(462, 488);
            this.countryLable.Name = "countryLable";
            this.countryLable.Size = new System.Drawing.Size(363, 128);
            this.countryLable.TabIndex = 3;
            this.countryLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1099, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "point a flag,i\'ll told you witch contry it is";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryLable);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.germanPictureBox);
            this.Controls.Add(this.finlandPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox finlandPictureBox;
        private System.Windows.Forms.PictureBox germanPictureBox;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.Label countryLable;
        private System.Windows.Forms.Label label1;
    }
}

