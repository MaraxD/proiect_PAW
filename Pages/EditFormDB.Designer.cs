
namespace seminar9.Pages
{
    partial class EditFormDB
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
            this.descTXT = new System.Windows.Forms.TextBox();
            this.priceTXT = new System.Windows.Forms.TextBox();
            this.colorTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descTXT
            // 
            this.descTXT.Location = new System.Drawing.Point(238, 70);
            this.descTXT.Name = "descTXT";
            this.descTXT.Size = new System.Drawing.Size(235, 26);
            this.descTXT.TabIndex = 0;
            // 
            // priceTXT
            // 
            this.priceTXT.Location = new System.Drawing.Point(238, 122);
            this.priceTXT.Name = "priceTXT";
            this.priceTXT.Size = new System.Drawing.Size(235, 26);
            this.priceTXT.TabIndex = 1;
            // 
            // colorTXT
            // 
            this.colorTXT.Location = new System.Drawing.Point(238, 172);
            this.colorTXT.Name = "colorTXT";
            this.colorTXT.Size = new System.Drawing.Size(235, 26);
            this.colorTXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditFormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 382);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorTXT);
            this.Controls.Add(this.priceTXT);
            this.Controls.Add(this.descTXT);
            this.Name = "EditFormDB";
            this.Text = "EditFormDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descTXT;
        private System.Windows.Forms.TextBox priceTXT;
        private System.Windows.Forms.TextBox colorTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}