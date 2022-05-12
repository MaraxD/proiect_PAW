
namespace seminar9
{
    partial class CheckOut
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
            this.numeText = new System.Windows.Forms.TextBox();
            this.prenumeText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.onlineCheckBox = new System.Windows.Forms.CheckBox();
            this.rambursCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeText
            // 
            this.numeText.Location = new System.Drawing.Point(223, 74);
            this.numeText.Name = "numeText";
            this.numeText.Size = new System.Drawing.Size(240, 26);
            this.numeText.TabIndex = 0;
            // 
            // prenumeText
            // 
            this.prenumeText.Location = new System.Drawing.Point(223, 131);
            this.prenumeText.Name = "prenumeText";
            this.prenumeText.Size = new System.Drawing.Size(240, 26);
            this.prenumeText.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(662, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(59, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nume";
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Location = new System.Drawing.Point(59, 131);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(73, 20);
            this.prenumeLabel.TabIndex = 5;
            this.prenumeLabel.Text = "Prenume";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(59, 185);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(144, 20);
            this.paymentLabel.TabIndex = 6;
            this.paymentLabel.Text = "Modalitate de plata";
            // 
            // onlineCheckBox
            // 
            this.onlineCheckBox.AutoSize = true;
            this.onlineCheckBox.Location = new System.Drawing.Point(63, 224);
            this.onlineCheckBox.Name = "onlineCheckBox";
            this.onlineCheckBox.Size = new System.Drawing.Size(80, 24);
            this.onlineCheckBox.TabIndex = 7;
            this.onlineCheckBox.Text = "Online";
            this.onlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // rambursCheckBox
            // 
            this.rambursCheckBox.AutoSize = true;
            this.rambursCheckBox.Location = new System.Drawing.Point(223, 224);
            this.rambursCheckBox.Name = "rambursCheckBox";
            this.rambursCheckBox.Size = new System.Drawing.Size(100, 24);
            this.rambursCheckBox.TabIndex = 8;
            this.rambursCheckBox.Text = "Ramburs";
            this.rambursCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adresa";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 26);
            this.textBox3.TabIndex = 10;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(560, 601);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(137, 45);
            this.buyButton.TabIndex = 11;
            this.buyButton.Text = "Cumpara";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 684);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rambursCheckBox);
            this.Controls.Add(this.onlineCheckBox);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.prenumeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prenumeText);
            this.Controls.Add(this.numeText);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeText;
        private System.Windows.Forms.TextBox prenumeText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label prenumeLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.CheckBox onlineCheckBox;
        private System.Windows.Forms.CheckBox rambursCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buyButton;
    }
}