
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.numeText = new System.Windows.Forms.TextBox();
            this.prenumeText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valTotalaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.onlineRB = new System.Windows.Forms.RadioButton();
            this.rambursRB = new System.Windows.Forms.RadioButton();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAdress = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeText
            // 
            this.numeText.Location = new System.Drawing.Point(195, 74);
            this.numeText.Name = "numeText";
            this.numeText.Size = new System.Drawing.Size(240, 26);
            this.numeText.TabIndex = 0;
            // 
            // prenumeText
            // 
            this.prenumeText.Location = new System.Drawing.Point(195, 131);
            this.prenumeText.Name = "prenumeText";
            this.prenumeText.Size = new System.Drawing.Size(240, 26);
            this.prenumeText.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(700, 163);
            this.dataGridView1.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(31, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 26);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nume";
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeLabel.Location = new System.Drawing.Point(31, 131);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(101, 26);
            this.prenumeLabel.TabIndex = 5;
            this.prenumeLabel.Text = "Prenume";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(31, 185);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(195, 26);
            this.paymentLabel.TabIndex = 6;
            this.paymentLabel.Text = "Modalitate de plata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adresa";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 26);
            this.textBox3.TabIndex = 10;
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.DimGray;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ForeColor = System.Drawing.Color.White;
            this.buyButton.Location = new System.Drawing.Point(598, 618);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(137, 45);
            this.buyButton.TabIndex = 11;
            this.buyButton.Text = "Cumpara";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Valoare Totala: ";
            // 
            // valTotalaLabel
            // 
            this.valTotalaLabel.AutoSize = true;
            this.valTotalaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTotalaLabel.Location = new System.Drawing.Point(644, 561);
            this.valTotalaLabel.Name = "valTotalaLabel";
            this.valTotalaLabel.Size = new System.Drawing.Size(24, 26);
            this.valTotalaLabel.TabIndex = 14;
            this.valTotalaLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(707, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "lei ";
            // 
            // onlineRB
            // 
            this.onlineRB.AutoSize = true;
            this.onlineRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineRB.Location = new System.Drawing.Point(36, 229);
            this.onlineRB.Name = "onlineRB";
            this.onlineRB.Size = new System.Drawing.Size(100, 30);
            this.onlineRB.TabIndex = 16;
            this.onlineRB.TabStop = true;
            this.onlineRB.Text = "Online";
            this.onlineRB.UseVisualStyleBackColor = true;
            // 
            // rambursRB
            // 
            this.rambursRB.AutoSize = true;
            this.rambursRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rambursRB.Location = new System.Drawing.Point(160, 229);
            this.rambursRB.Name = "rambursRB";
            this.rambursRB.Size = new System.Drawing.Size(126, 30);
            this.rambursRB.TabIndex = 17;
            this.rambursRB.TabStop = true;
            this.rambursRB.Text = "Ramburs";
            this.rambursRB.UseVisualStyleBackColor = true;
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorPrenume
            // 
            this.errorPrenume.ContainerControl = this;
            // 
            // errorAdress
            // 
            this.errorAdress.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::seminar9.Properties.Resources._221_2214080_back_arrow_vector_go_back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 684);
            this.Controls.Add(this.rambursRB);
            this.Controls.Add(this.onlineRB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valTotalaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.prenumeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prenumeText);
            this.Controls.Add(this.numeText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valTotalaLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton onlineRB;
        private System.Windows.Forms.RadioButton rambursRB;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorPrenume;
        private System.Windows.Forms.ErrorProvider errorAdress;
    }
}