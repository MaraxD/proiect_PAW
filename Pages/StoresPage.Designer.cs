
namespace seminar9
{
    partial class StoresPage
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
            this.storesDataGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // storesDataGrid
            // 
            this.storesDataGrid.AllowUserToAddRows = false;
            this.storesDataGrid.AllowUserToDeleteRows = false;
            this.storesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.storesDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.storesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storesDataGrid.Location = new System.Drawing.Point(49, 185);
            this.storesDataGrid.Name = "storesDataGrid";
            this.storesDataGrid.ReadOnly = true;
            this.storesDataGrid.RowHeadersWidth = 62;
            this.storesDataGrid.RowTemplate.Height = 28;
            this.storesDataGrid.Size = new System.Drawing.Size(1214, 384);
            this.storesDataGrid.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::seminar9.Properties.Resources.png_Home_Button_Icon_Png_Home_Bread_Crumbs_home_button_image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StoresPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::seminar9.Properties.Resources.map2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1321, 769);
            this.Controls.Add(this.storesDataGrid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StoresPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoresPage";
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView storesDataGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}