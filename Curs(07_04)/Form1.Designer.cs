namespace Curs_07_04_
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDirect = new System.Windows.Forms.Button();
            this.greyScale = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.filterPhotoshop = new System.Windows.Forms.Button();
            this.filtru2 = new System.Windows.Forms.Button();
            this.filitru2max = new System.Windows.Forms.Button();
            this.Contrast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(577, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(452, 498);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnDirect
            // 
            this.btnDirect.Location = new System.Drawing.Point(135, 530);
            this.btnDirect.Name = "btnDirect";
            this.btnDirect.Size = new System.Drawing.Size(116, 53);
            this.btnDirect.TabIndex = 2;
            this.btnDirect.Text = "Replic";
            this.btnDirect.UseVisualStyleBackColor = true;
            this.btnDirect.Click += new System.EventHandler(this.btnDirect_Click);
            // 
            // greyScale
            // 
            this.greyScale.Location = new System.Drawing.Point(12, 530);
            this.greyScale.Name = "greyScale";
            this.greyScale.Size = new System.Drawing.Size(117, 53);
            this.greyScale.TabIndex = 3;
            this.greyScale.Text = "GrayScale";
            this.greyScale.UseVisualStyleBackColor = true;
            this.greyScale.Click += new System.EventHandler(this.greyScale_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(257, 530);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(112, 53);
            this.button.TabIndex = 4;
            this.button.Text = "BW(C)";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // filterPhotoshop
            // 
            this.filterPhotoshop.Location = new System.Drawing.Point(375, 530);
            this.filterPhotoshop.Name = "filterPhotoshop";
            this.filterPhotoshop.Size = new System.Drawing.Size(121, 53);
            this.filterPhotoshop.TabIndex = 5;
            this.filterPhotoshop.Text = "Filter(B)";
            this.filterPhotoshop.UseVisualStyleBackColor = true;
            this.filterPhotoshop.Click += new System.EventHandler(this.filterPhotoshop_Click);
            // 
            // filtru2
            // 
            this.filtru2.Location = new System.Drawing.Point(502, 530);
            this.filtru2.Name = "filtru2";
            this.filtru2.Size = new System.Drawing.Size(124, 53);
            this.filtru2.TabIndex = 6;
            this.filtru2.Text = "Filter2(min)";
            this.filtru2.UseVisualStyleBackColor = true;
            this.filtru2.Click += new System.EventHandler(this.filtru2_Click);
            // 
            // filitru2max
            // 
            this.filitru2max.Location = new System.Drawing.Point(632, 530);
            this.filitru2max.Name = "filitru2max";
            this.filitru2max.Size = new System.Drawing.Size(111, 53);
            this.filitru2max.TabIndex = 7;
            this.filitru2max.Text = "Filter2(max)";
            this.filitru2max.UseVisualStyleBackColor = true;
            this.filitru2max.Click += new System.EventHandler(this.filitru2max_Click);
            // 
            // Contrast
            // 
            this.Contrast.Location = new System.Drawing.Point(749, 530);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(111, 53);
            this.Contrast.TabIndex = 8;
            this.Contrast.Text = "Contrast";
            this.Contrast.UseVisualStyleBackColor = true;
            this.Contrast.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 621);
            this.Controls.Add(this.Contrast);
            this.Controls.Add(this.filitru2max);
            this.Controls.Add(this.filtru2);
            this.Controls.Add(this.filterPhotoshop);
            this.Controls.Add(this.button);
            this.Controls.Add(this.greyScale);
            this.Controls.Add(this.btnDirect);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDirect;
        private System.Windows.Forms.Button greyScale;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button filterPhotoshop;
        private System.Windows.Forms.Button filtru2;
        private System.Windows.Forms.Button filitru2max;
        private System.Windows.Forms.Button Contrast;
    }
}

