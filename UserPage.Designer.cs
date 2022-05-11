
namespace seminar9
{
    partial class UserPage
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
            this.equipDataGrid1 = new System.Windows.Forms.DataGridView();
            this.addPlaneButton = new System.Windows.Forms.Button();
            this.equipDataGrid2 = new System.Windows.Forms.DataGridView();
            this.equipDataGrid3 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // equipDataGrid1
            // 
            this.equipDataGrid1.AllowUserToAddRows = false;
            this.equipDataGrid1.AllowUserToDeleteRows = false;
            this.equipDataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.equipDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipDataGrid1.Location = new System.Drawing.Point(12, 70);
            this.equipDataGrid1.Name = "equipDataGrid1";
            this.equipDataGrid1.ReadOnly = true;
            this.equipDataGrid1.RowHeadersWidth = 62;
            this.equipDataGrid1.RowTemplate.Height = 28;
            this.equipDataGrid1.Size = new System.Drawing.Size(1448, 112);
            this.equipDataGrid1.TabIndex = 0;
            // 
            // addPlaneButton
            // 
            this.addPlaneButton.Location = new System.Drawing.Point(569, 12);
            this.addPlaneButton.Name = "addPlaneButton";
            this.addPlaneButton.Size = new System.Drawing.Size(214, 30);
            this.addPlaneButton.TabIndex = 1;
            this.addPlaneButton.Text = "Add da plane";
            this.addPlaneButton.UseVisualStyleBackColor = true;
            this.addPlaneButton.Click += new System.EventHandler(this.addPlaneButton_Click);
            // 
            // equipDataGrid2
            // 
            this.equipDataGrid2.AllowUserToAddRows = false;
            this.equipDataGrid2.AllowUserToDeleteRows = false;
            this.equipDataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.equipDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipDataGrid2.Location = new System.Drawing.Point(12, 284);
            this.equipDataGrid2.Name = "equipDataGrid2";
            this.equipDataGrid2.ReadOnly = true;
            this.equipDataGrid2.RowHeadersWidth = 62;
            this.equipDataGrid2.RowTemplate.Height = 28;
            this.equipDataGrid2.Size = new System.Drawing.Size(1448, 112);
            this.equipDataGrid2.TabIndex = 2;
            // 
            // equipDataGrid3
            // 
            this.equipDataGrid3.AllowUserToAddRows = false;
            this.equipDataGrid3.AllowUserToDeleteRows = false;
            this.equipDataGrid3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.equipDataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipDataGrid3.Location = new System.Drawing.Point(12, 482);
            this.equipDataGrid3.Name = "equipDataGrid3";
            this.equipDataGrid3.ReadOnly = true;
            this.equipDataGrid3.RowHeadersWidth = 62;
            this.equipDataGrid3.RowTemplate.Height = 28;
            this.equipDataGrid3.Size = new System.Drawing.Size(1448, 112);
            this.equipDataGrid3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::seminar9.Properties.Resources.png_transparent_computer_icons_logout_angle_text_black;
            this.pictureBox1.Location = new System.Drawing.Point(1360, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.equipDataGrid3);
            this.Controls.Add(this.equipDataGrid2);
            this.Controls.Add(this.addPlaneButton);
            this.Controls.Add(this.equipDataGrid1);
            this.Name = "UserPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView equipDataGrid1;
        private System.Windows.Forms.Button addPlaneButton;
        private System.Windows.Forms.DataGridView equipDataGrid2;
        private System.Windows.Forms.DataGridView equipDataGrid3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

