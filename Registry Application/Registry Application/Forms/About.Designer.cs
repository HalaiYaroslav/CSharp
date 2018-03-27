namespace Registry_Application
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
            this.lb_Creator = new System.Windows.Forms.Label();
            this.lb_GroupAndFac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Creator
            // 
            this.lb_Creator.AutoSize = true;
            this.lb_Creator.BackColor = System.Drawing.Color.Transparent;
            this.lb_Creator.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Creator.ForeColor = System.Drawing.Color.White;
            this.lb_Creator.Location = new System.Drawing.Point(38, 9);
            this.lb_Creator.Name = "lb_Creator";
            this.lb_Creator.Size = new System.Drawing.Size(199, 22);
            this.lb_Creator.TabIndex = 0;
            this.lb_Creator.Text = "Created by Galay Y. O.";
            // 
            // lb_GroupAndFac
            // 
            this.lb_GroupAndFac.AutoSize = true;
            this.lb_GroupAndFac.BackColor = System.Drawing.Color.Transparent;
            this.lb_GroupAndFac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_GroupAndFac.ForeColor = System.Drawing.Color.White;
            this.lb_GroupAndFac.Location = new System.Drawing.Point(83, 230);
            this.lb_GroupAndFac.Name = "lb_GroupAndFac";
            this.lb_GroupAndFac.Size = new System.Drawing.Size(116, 22);
            this.lb_GroupAndFac.TabIndex = 1;
            this.lb_GroupAndFac.Text = "IA - 51 FICT";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb_GroupAndFac);
            this.Controls.Add(this.lb_Creator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Creator;
        private System.Windows.Forms.Label lb_GroupAndFac;
    }
}