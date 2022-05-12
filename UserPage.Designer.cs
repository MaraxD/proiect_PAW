
using System;
using System.Windows.Forms;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wStripMenuItem,
            this.mStripMenuItem,
            this.cStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1472, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wStripMenuItem
            // 
            this.wStripMenuItem.Name = "wStripMenuItem";
            this.wStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.wStripMenuItem.Text = "Femei";
            this.wStripMenuItem.Click += new System.EventHandler(this.wStripMenuItem_Click);
            // 
            // mStripMenuItem
            // 
            this.mStripMenuItem.Name = "mStripMenuItem";
            this.mStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.mStripMenuItem.Text = "Barbati";
            this.mStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // cStripMenuItem
            // 
            this.cStripMenuItem.Name = "cStripMenuItem";
            this.cStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.cStripMenuItem.Text = "Copii";
            this.cStripMenuItem.Click += new System.EventHandler(this.cStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::seminar9.Properties.Resources.png_transparent_computer_icons_logout_angle_text_black;
            this.pictureBox1.Location = new System.Drawing.Point(1372, 36);
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
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserPage";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem wStripMenuItem;
        private ToolStripMenuItem mStripMenuItem;
        private ToolStripMenuItem cStripMenuItem;
    }
}

