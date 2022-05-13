
namespace seminar9
{
    partial class CopiiPage
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
            this.equipDataGrid3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::seminar9.Properties.Resources.png_Home_Button_Icon_Png_Home_Bread_Crumbs_home_button_image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // equipDataGrid3
            // 
            this.equipDataGrid3.AllowUserToAddRows = false;
            this.equipDataGrid3.AllowUserToDeleteRows = false;
            this.equipDataGrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.equipDataGrid3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.equipDataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipDataGrid3.Location = new System.Drawing.Point(12, 62);
            this.equipDataGrid3.Name = "equipDataGrid3";
            this.equipDataGrid3.ReadOnly = true;
            this.equipDataGrid3.RowHeadersWidth = 62;
            this.equipDataGrid3.RowTemplate.Height = 28;
            this.equipDataGrid3.Size = new System.Drawing.Size(776, 376);
            this.equipDataGrid3.TabIndex = 6;
            // 
            // CopiiPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equipDataGrid3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CopiiPage";
            this.Text = "CopiiPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView equipDataGrid3;
    }
}