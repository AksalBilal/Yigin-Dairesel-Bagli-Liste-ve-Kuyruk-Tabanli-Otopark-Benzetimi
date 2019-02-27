namespace Ödev_2
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
            this.btnArabaCıkart = new System.Windows.Forms.Button();
            this.listBodrumKat = new System.Windows.Forms.ListBox();
            this.listZemınKat = new System.Windows.Forms.ListBox();
            this.listIkıncıKat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArabaCıkart
            // 
            this.btnArabaCıkart.Location = new System.Drawing.Point(361, 12);
            this.btnArabaCıkart.Name = "btnArabaCıkart";
            this.btnArabaCıkart.Size = new System.Drawing.Size(257, 81);
            this.btnArabaCıkart.TabIndex = 0;
            this.btnArabaCıkart.Text = "ARABA ÇIKART";
            this.btnArabaCıkart.UseVisualStyleBackColor = true;
            this.btnArabaCıkart.Click += new System.EventHandler(this.btnArabaCıkart_Click);
            // 
            // listBodrumKat
            // 
            this.listBodrumKat.FormattingEnabled = true;
            this.listBodrumKat.ItemHeight = 16;
            this.listBodrumKat.Location = new System.Drawing.Point(12, 130);
            this.listBodrumKat.Name = "listBodrumKat";
            this.listBodrumKat.Size = new System.Drawing.Size(256, 356);
            this.listBodrumKat.TabIndex = 1;
            // 
            // listZemınKat
            // 
            this.listZemınKat.FormattingEnabled = true;
            this.listZemınKat.ItemHeight = 16;
            this.listZemınKat.Location = new System.Drawing.Point(362, 130);
            this.listZemınKat.Name = "listZemınKat";
            this.listZemınKat.Size = new System.Drawing.Size(256, 356);
            this.listZemınKat.TabIndex = 2;
            // 
            // listIkıncıKat
            // 
            this.listIkıncıKat.FormattingEnabled = true;
            this.listIkıncıKat.ItemHeight = 16;
            this.listIkıncıKat.Location = new System.Drawing.Point(711, 130);
            this.listIkıncıKat.Name = "listIkıncıKat";
            this.listIkıncıKat.Size = new System.Drawing.Size(256, 356);
            this.listIkıncıKat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "BODRUM KATINDAKİ ARABALAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ZEMIN KATINDAKİ ARABALAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "İKİNCİ KATTAKİ ARABALAR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listIkıncıKat);
            this.Controls.Add(this.listZemınKat);
            this.Controls.Add(this.listBodrumKat);
            this.Controls.Add(this.btnArabaCıkart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArabaCıkart;
        private System.Windows.Forms.ListBox listBodrumKat;
        private System.Windows.Forms.ListBox listZemınKat;
        private System.Windows.Forms.ListBox listIkıncıKat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

