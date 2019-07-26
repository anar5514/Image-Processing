namespace ImageProcessingWithWinform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalPic = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.resultPic = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSelectColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPic)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPic
            // 
            this.originalPic.Location = new System.Drawing.Point(85, 48);
            this.originalPic.Name = "originalPic";
            this.originalPic.Size = new System.Drawing.Size(291, 254);
            this.originalPic.TabIndex = 0;
            this.originalPic.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(85, 358);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(291, 58);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(655, 358);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(291, 58);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // resultPic
            // 
            this.resultPic.Location = new System.Drawing.Point(655, 48);
            this.resultPic.Name = "resultPic";
            this.resultPic.Size = new System.Drawing.Size(291, 254);
            this.resultPic.TabIndex = 0;
            this.resultPic.TabStop = false;
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(85, 433);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(291, 58);
            this.btnSelectColor.TabIndex = 1;
            this.btnSelectColor.Text = "Select Color";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 535);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.resultPic);
            this.Controls.Add(this.originalPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originalPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPic;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.PictureBox resultPic;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSelectColor;
    }
}

