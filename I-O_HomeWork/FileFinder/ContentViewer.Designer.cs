namespace FileFinder
{
    partial class ContentViewer
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
            this.FileContentViewer = new System.Windows.Forms.TextBox();
            this.CompressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileContentViewer
            // 
            this.FileContentViewer.Location = new System.Drawing.Point(12, 12);
            this.FileContentViewer.Multiline = true;
            this.FileContentViewer.Name = "FileContentViewer";
            this.FileContentViewer.Size = new System.Drawing.Size(460, 414);
            this.FileContentViewer.TabIndex = 0;
            // 
            // CompressButton
            // 
            this.CompressButton.Location = new System.Drawing.Point(12, 432);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(460, 27);
            this.CompressButton.TabIndex = 1;
            this.CompressButton.Text = "Compress with ZIP algorithm";
            this.CompressButton.UseVisualStyleBackColor = true;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // ContentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 468);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.FileContentViewer);
            this.Name = "ContentViewer";
            this.Text = "ContentViewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContentViewer_FormClosed);
            this.Load += new System.EventHandler(this.ContentViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileContentViewer;
        private System.Windows.Forms.Button CompressButton;
    }
}