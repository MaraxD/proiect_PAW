
namespace seminar9
{
    partial class FemeiPage
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
            this.equipDataGrid2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // equipDataGrid2
            // 
            this.equipDataGrid2.AllowUserToAddRows = false;
            this.equipDataGrid2.AllowUserToDeleteRows = false;
            this.equipDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.equipDataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.equipDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipDataGrid2.Location = new System.Drawing.Point(12, 62);
            this.equipDataGrid2.Name = "equipDataGrid2";
            this.equipDataGrid2.ReadOnly = true;
            this.equipDataGrid2.RowHeadersWidth = 62;
            this.equipDataGrid2.RowTemplate.Height = 28;
            this.equipDataGrid2.Size = new System.Drawing.Size(833, 512);
            this.equipDataGrid2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::seminar9.Properties.Resources.png_Home_Button_Icon_Png_Home_Bread_Crumbs_home_button_image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FemeiPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.equipDataGrid2);
            this.Name = "FemeiPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FemeiPage";
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView equipDataGrid2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}