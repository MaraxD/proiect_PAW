
namespace seminar9
{
    partial class Main
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
            this.userButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userButton
            // 
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Location = new System.Drawing.Point(95, 175);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(116, 41);
            this.userButton.TabIndex = 9;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(95, 76);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(116, 41);
            this.adminButton.TabIndex = 8;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 316);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.adminButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button adminButton;
    }
}