
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
            this.button1 = new System.Windows.Forms.Button();
            this.planeSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // planeSaveButton
            // 
            this.planeSaveButton.Location = new System.Drawing.Point(115, 82);
            this.planeSaveButton.Name = "planeSaveButton";
            this.planeSaveButton.Size = new System.Drawing.Size(75, 31);
            this.planeSaveButton.TabIndex = 8;
            this.planeSaveButton.Text = "Admin";
            this.planeSaveButton.UseVisualStyleBackColor = true;
            this.planeSaveButton.Click += new System.EventHandler(this.planeSaveButton_Click_1);
            // 
            // AddPlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.planeSaveButton);
            this.Name = "AddPlaneForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button planeSaveButton;
    }
}