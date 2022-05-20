
namespace seminar9.Pages
{
    partial class AddFormDB
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorTXT = new System.Windows.Forms.TextBox();
            this.priceTXT = new System.Windows.Forms.TextBox();
            this.descTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 51);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Description";
            // 
            // colorTXT
            // 
            this.colorTXT.Location = new System.Drawing.Point(224, 169);
            this.colorTXT.Name = "colorTXT";
            this.colorTXT.Size = new System.Drawing.Size(235, 26);
            this.colorTXT.TabIndex = 10;
            // 
            // priceTXT
            // 
            this.priceTXT.Location = new System.Drawing.Point(224, 119);
            this.priceTXT.Name = "priceTXT";
            this.priceTXT.Size = new System.Drawing.Size(235, 26);
            this.priceTXT.TabIndex = 9;
            // 
            // descTXT
            // 
            this.descTXT.Location = new System.Drawing.Point(224, 67);
            this.descTXT.Name = "descTXT";
            this.descTXT.Size = new System.Drawing.Size(235, 26);
            this.descTXT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Category";
            // 
            // categTXT
            // 
            this.categTXT.Location = new System.Drawing.Point(224, 217);
            this.categTXT.Name = "categTXT";
            this.categTXT.Size = new System.Drawing.Size(235, 26);
            this.categTXT.TabIndex = 16;
            // 
            // AddFormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 382);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categTXT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorTXT);
            this.Controls.Add(this.priceTXT);
            this.Controls.Add(this.descTXT);
            this.Name = "AddFormDB";
            this.Text = "AddFormDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox colorTXT;
        private System.Windows.Forms.TextBox priceTXT;
        private System.Windows.Forms.TextBox descTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categTXT;
    }
}