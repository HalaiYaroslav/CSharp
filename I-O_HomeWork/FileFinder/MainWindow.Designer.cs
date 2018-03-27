namespace FileFinder
{
    partial class MainWindow
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
            this.PathInput = new System.Windows.Forms.TextBox();
            this.AvailablePathsSelector = new System.Windows.Forms.ComboBox();
            this.SavePathButton = new System.Windows.Forms.Button();
            this.ChoosePathLabel = new System.Windows.Forms.Label();
            this.FilesLabel = new System.Windows.Forms.Label();
            this.ParentDirectoryLabel = new System.Windows.Forms.Label();
            this.ExceptionsLabel = new System.Windows.Forms.Label();
            this.DirectoriesSelector = new System.Windows.Forms.ListBox();
            this.FilesSelector = new System.Windows.Forms.ListBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PathInput
            // 
            this.PathInput.Location = new System.Drawing.Point(124, 37);
            this.PathInput.Name = "PathInput";
            this.PathInput.Size = new System.Drawing.Size(548, 20);
            this.PathInput.TabIndex = 2;
            this.PathInput.TextChanged += new System.EventHandler(this.PathInput_TextChanged);
            // 
            // AvailablePathsSelector
            // 
            this.AvailablePathsSelector.FormattingEnabled = true;
            this.AvailablePathsSelector.Items.AddRange(new object[] {
            "C:\\",
            "D:\\"});
            this.AvailablePathsSelector.Location = new System.Drawing.Point(124, 6);
            this.AvailablePathsSelector.Name = "AvailablePathsSelector";
            this.AvailablePathsSelector.Size = new System.Drawing.Size(548, 21);
            this.AvailablePathsSelector.TabIndex = 3;
            this.AvailablePathsSelector.SelectionChangeCommitted += new System.EventHandler(this.AvailablePathsSelector_SelectionChangeCommitted);
            // 
            // SavePathButton
            // 
            this.SavePathButton.Location = new System.Drawing.Point(12, 34);
            this.SavePathButton.Name = "SavePathButton";
            this.SavePathButton.Size = new System.Drawing.Size(106, 23);
            this.SavePathButton.TabIndex = 4;
            this.SavePathButton.Text = "Save Path";
            this.SavePathButton.UseVisualStyleBackColor = true;
            this.SavePathButton.Click += new System.EventHandler(this.SavePathButton_Click);
            // 
            // ChoosePathLabel
            // 
            this.ChoosePathLabel.AutoSize = true;
            this.ChoosePathLabel.Location = new System.Drawing.Point(9, 14);
            this.ChoosePathLabel.Name = "ChoosePathLabel";
            this.ChoosePathLabel.Size = new System.Drawing.Size(70, 13);
            this.ChoosePathLabel.TabIndex = 5;
            this.ChoosePathLabel.Text = "Choose path:";
            // 
            // FilesLabel
            // 
            this.FilesLabel.AutoSize = true;
            this.FilesLabel.Location = new System.Drawing.Point(483, 103);
            this.FilesLabel.Name = "FilesLabel";
            this.FilesLabel.Size = new System.Drawing.Size(28, 13);
            this.FilesLabel.TabIndex = 6;
            this.FilesLabel.Text = "Files";
            // 
            // ParentDirectoryLabel
            // 
            this.ParentDirectoryLabel.AutoSize = true;
            this.ParentDirectoryLabel.Location = new System.Drawing.Point(121, 103);
            this.ParentDirectoryLabel.Name = "ParentDirectoryLabel";
            this.ParentDirectoryLabel.Size = new System.Drawing.Size(57, 13);
            this.ParentDirectoryLabel.TabIndex = 7;
            this.ParentDirectoryLabel.Text = "Directories";
            // 
            // ExceptionsLabel
            // 
            this.ExceptionsLabel.AutoSize = true;
            this.ExceptionsLabel.Location = new System.Drawing.Point(303, 103);
            this.ExceptionsLabel.Name = "ExceptionsLabel";
            this.ExceptionsLabel.Size = new System.Drawing.Size(0, 13);
            this.ExceptionsLabel.TabIndex = 8;
            // 
            // DirectoriesSelector
            // 
            this.DirectoriesSelector.FormattingEnabled = true;
            this.DirectoriesSelector.Location = new System.Drawing.Point(12, 119);
            this.DirectoriesSelector.Name = "DirectoriesSelector";
            this.DirectoriesSelector.Size = new System.Drawing.Size(315, 303);
            this.DirectoriesSelector.TabIndex = 9;
            this.DirectoriesSelector.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DirectoriesSelector_MouseDoubleClick);
            // 
            // FilesSelector
            // 
            this.FilesSelector.FormattingEnabled = true;
            this.FilesSelector.Location = new System.Drawing.Point(349, 119);
            this.FilesSelector.Name = "FilesSelector";
            this.FilesSelector.Size = new System.Drawing.Size(323, 303);
            this.FilesSelector.TabIndex = 10;
            this.FilesSelector.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FilesSelector_MouseDoubleClick);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(12, 90);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(38, 23);
            this.ReturnButton.TabIndex = 11;
            this.ReturnButton.Text = "<-";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // FindFileButton
            // 
            this.FindFileButton.Location = new System.Drawing.Point(12, 63);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(106, 23);
            this.FindFileButton.TabIndex = 12;
            this.FindFileButton.Text = "Find file";
            this.FindFileButton.UseVisualStyleBackColor = true;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // FileNameInput
            // 
            this.FileNameInput.Location = new System.Drawing.Point(124, 63);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(548, 20);
            this.FileNameInput.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 433);
            this.Controls.Add(this.FileNameInput);
            this.Controls.Add(this.FindFileButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.FilesSelector);
            this.Controls.Add(this.DirectoriesSelector);
            this.Controls.Add(this.ExceptionsLabel);
            this.Controls.Add(this.ParentDirectoryLabel);
            this.Controls.Add(this.FilesLabel);
            this.Controls.Add(this.ChoosePathLabel);
            this.Controls.Add(this.SavePathButton);
            this.Controls.Add(this.AvailablePathsSelector);
            this.Controls.Add(this.PathInput);
            this.Name = "MainWindow";
            this.Text = "File Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PathInput;
        private System.Windows.Forms.ComboBox AvailablePathsSelector;
        private System.Windows.Forms.Button SavePathButton;
        private System.Windows.Forms.Label ChoosePathLabel;
        private System.Windows.Forms.Label FilesLabel;
        private System.Windows.Forms.Label ParentDirectoryLabel;
        private System.Windows.Forms.Label ExceptionsLabel;
        private System.Windows.Forms.ListBox DirectoriesSelector;
        private System.Windows.Forms.ListBox FilesSelector;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.TextBox FileNameInput;
    }
}

