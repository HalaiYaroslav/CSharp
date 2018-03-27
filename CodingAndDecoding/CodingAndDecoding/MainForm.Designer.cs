namespace CodingAndDecoding
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_Codes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Gray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Berger = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Elias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_CWSR = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Codes,
            this.menuItem_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem_Codes
            // 
            this.menuItem_Codes.BackColor = System.Drawing.Color.Transparent;
            this.menuItem_Codes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Gray,
            this.toolStripMenuItem2,
            this.menuItem_Berger,
            this.menuItem_Elias,
            this.menuItem_CWSR,
            this.toolStripMenuItem1});
            this.menuItem_Codes.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_Codes.ForeColor = System.Drawing.Color.White;
            this.menuItem_Codes.Name = "menuItem_Codes";
            this.menuItem_Codes.Size = new System.Drawing.Size(83, 29);
            this.menuItem_Codes.Text = "Codes";
            // 
            // menuItem_Gray
            // 
            this.menuItem_Gray.BackColor = System.Drawing.Color.SteelBlue;
            this.menuItem_Gray.ForeColor = System.Drawing.Color.White;
            this.menuItem_Gray.Name = "menuItem_Gray";
            this.menuItem_Gray.Size = new System.Drawing.Size(390, 30);
            this.menuItem_Gray.Text = "Gray";
            this.menuItem_Gray.Click += new System.EventHandler(this.menuItemGray_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(390, 30);
            this.toolStripMenuItem2.Text = "BCD (binary-coded decimal)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.menuItem_BCD_Click);
            // 
            // menuItem_Berger
            // 
            this.menuItem_Berger.BackColor = System.Drawing.Color.SteelBlue;
            this.menuItem_Berger.ForeColor = System.Drawing.Color.White;
            this.menuItem_Berger.Name = "menuItem_Berger";
            this.menuItem_Berger.Size = new System.Drawing.Size(390, 30);
            this.menuItem_Berger.Text = "Berger";
            this.menuItem_Berger.Click += new System.EventHandler(this.menuItem_Berger_Click);
            // 
            // menuItem_Elias
            // 
            this.menuItem_Elias.BackColor = System.Drawing.Color.SteelBlue;
            this.menuItem_Elias.ForeColor = System.Drawing.Color.White;
            this.menuItem_Elias.Name = "menuItem_Elias";
            this.menuItem_Elias.Size = new System.Drawing.Size(390, 30);
            this.menuItem_Elias.Text = "Elias";
            this.menuItem_Elias.Click += new System.EventHandler(this.menuItem_Elias_Click);
            // 
            // menuItem_CWSR
            // 
            this.menuItem_CWSR.BackColor = System.Drawing.Color.SteelBlue;
            this.menuItem_CWSR.ForeColor = System.Drawing.Color.White;
            this.menuItem_CWSR.Name = "menuItem_CWSR";
            this.menuItem_CWSR.Size = new System.Drawing.Size(390, 30);
            this.menuItem_CWSR.Text = "Code with simple reiteration";
            this.menuItem_CWSR.Click += new System.EventHandler(this.menuItem_CWSR_Click);
            // 
            // menuItem_About
            // 
            this.menuItem_About.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_About.ForeColor = System.Drawing.Color.White;
            this.menuItem_About.Name = "menuItem_About";
            this.menuItem_About.Size = new System.Drawing.Size(88, 29);
            this.menuItem_About.Text = "About";
            this.menuItem_About.Click += new System.EventHandler(this.menuItem_About_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(390, 30);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 257);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Codes;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Gray;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Berger;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Elias;
        private System.Windows.Forms.ToolStripMenuItem menuItem_About;
        private System.Windows.Forms.ToolStripMenuItem menuItem_CWSR;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

