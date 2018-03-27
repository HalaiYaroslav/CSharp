namespace CodingAndDecoding
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lbl_Creator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Creator
            // 
            this.lbl_Creator.AutoSize = true;
            this.lbl_Creator.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Creator.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Creator.ForeColor = System.Drawing.Color.White;
            this.lbl_Creator.Location = new System.Drawing.Point(0, 267);
            this.lbl_Creator.Name = "lbl_Creator";
            this.lbl_Creator.Size = new System.Drawing.Size(241, 22);
            this.lbl_Creator.TabIndex = 0;
            this.lbl_Creator.Text = "Created by Galay Y. O. KPI FICT";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 298);
            this.Controls.Add(this.lbl_Creator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Creator;
    }
}