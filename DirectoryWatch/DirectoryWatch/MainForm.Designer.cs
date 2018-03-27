namespace DirectoryWatch
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox_Folders = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btn_AddComBoxText = new System.Windows.Forms.Button();
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.lb_Folders = new System.Windows.Forms.Label();
            this.lb_Files = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Folders
            // 
            this.listBox_Folders.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Folders.ForeColor = System.Drawing.Color.Black;
            this.listBox_Folders.FormattingEnabled = true;
            this.listBox_Folders.ItemHeight = 21;
            this.listBox_Folders.Location = new System.Drawing.Point(12, 148);
            this.listBox_Folders.Name = "listBox_Folders";
            this.listBox_Folders.Size = new System.Drawing.Size(371, 277);
            this.listBox_Folders.TabIndex = 0;
            this.listBox_Folders.SelectedIndexChanged += new System.EventHandler(this.listBox_Folders_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(67, 84);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(705, 25);
            this.textBox.TabIndex = 1;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "C:\\",
            "D:\\",
            "D:\\Музика",
            "D:\\Музика\\New"});
            this.comboBox.Location = new System.Drawing.Point(12, 52);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(760, 28);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // btn_AddComBoxText
            // 
            this.btn_AddComBoxText.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddComBoxText.Location = new System.Drawing.Point(12, 12);
            this.btn_AddComBoxText.Name = "btn_AddComBoxText";
            this.btn_AddComBoxText.Size = new System.Drawing.Size(760, 30);
            this.btn_AddComBoxText.TabIndex = 3;
            this.btn_AddComBoxText.Text = "Add path to combobox";
            this.btn_AddComBoxText.UseVisualStyleBackColor = true;
            this.btn_AddComBoxText.Click += new System.EventHandler(this.btn_AddComBoxText_Click);
            // 
            // listBox_Files
            // 
            this.listBox_Files.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Files.ForeColor = System.Drawing.Color.Black;
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.ItemHeight = 18;
            this.listBox_Files.Location = new System.Drawing.Point(401, 148);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(371, 274);
            this.listBox_Files.TabIndex = 4;
            // 
            // lb_Folders
            // 
            this.lb_Folders.AutoSize = true;
            this.lb_Folders.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Folders.Location = new System.Drawing.Point(8, 121);
            this.lb_Folders.Name = "lb_Folders";
            this.lb_Folders.Size = new System.Drawing.Size(72, 24);
            this.lb_Folders.TabIndex = 5;
            this.lb_Folders.Text = "Folders";
            // 
            // lb_Files
            // 
            this.lb_Files.AutoSize = true;
            this.lb_Files.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Files.Location = new System.Drawing.Point(397, 121);
            this.lb_Files.Name = "lb_Files";
            this.lb_Files.Size = new System.Drawing.Size(52, 24);
            this.lb_Files.TabIndex = 6;
            this.lb_Files.Text = "Files";
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info.Location = new System.Drawing.Point(8, 85);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(52, 24);
            this.lb_info.TabIndex = 7;
            this.lb_info.Text = "Path";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(784, 438);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.lb_Files);
            this.Controls.Add(this.lb_Folders);
            this.Controls.Add(this.listBox_Files);
            this.Controls.Add(this.btn_AddComBoxText);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listBox_Folders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Watch";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Folders;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btn_AddComBoxText;
        private System.Windows.Forms.ListBox listBox_Files;
        private System.Windows.Forms.Label lb_Folders;
        private System.Windows.Forms.Label lb_Files;
        private System.Windows.Forms.Label lb_info;
    }
}

