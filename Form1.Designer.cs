
namespace seminar9
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
            this.planesDataGrid = new System.Windows.Forms.DataGridView();
            this.addPlaneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // planesDataGrid
            // 
            this.planesDataGrid.AllowUserToAddRows = false;
            this.planesDataGrid.AllowUserToDeleteRows = false;
            this.planesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planesDataGrid.Location = new System.Drawing.Point(12, 70);
            this.planesDataGrid.Name = "planesDataGrid";
            this.planesDataGrid.ReadOnly = true;
            this.planesDataGrid.RowHeadersWidth = 62;
            this.planesDataGrid.RowTemplate.Height = 28;
            this.planesDataGrid.Size = new System.Drawing.Size(802, 378);
            this.planesDataGrid.TabIndex = 0;
            // 
            // addPlaneButton
            // 
            this.addPlaneButton.Location = new System.Drawing.Point(290, 21);
            this.addPlaneButton.Name = "addPlaneButton";
            this.addPlaneButton.Size = new System.Drawing.Size(214, 30);
            this.addPlaneButton.TabIndex = 1;
            this.addPlaneButton.Text = "Add da plane";
            this.addPlaneButton.UseVisualStyleBackColor = true;
            this.addPlaneButton.Click += new System.EventHandler(this.addPlaneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 460);
            this.Controls.Add(this.addPlaneButton);
            this.Controls.Add(this.planesDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView planesDataGrid;
        private System.Windows.Forms.Button addPlaneButton;
    }
}

