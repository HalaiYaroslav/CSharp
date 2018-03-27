namespace Registry_Application
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
            this.menuDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMadication = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuDoctors
            // 
            this.menuDoctors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewDoctors,
            this.menuEditDoctors});
            this.menuDoctors.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuDoctors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuDoctors.Name = "menuDoctors";
            this.menuDoctors.Size = new System.Drawing.Size(87, 26);
            this.menuDoctors.Text = "Doctors";
            // 
            // menuViewDoctors
            // 
            this.menuViewDoctors.BackColor = System.Drawing.Color.Teal;
            this.menuViewDoctors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuViewDoctors.Name = "menuViewDoctors";
            this.menuViewDoctors.Size = new System.Drawing.Size(190, 26);
            this.menuViewDoctors.Text = "View Doctors";
            this.menuViewDoctors.Click += new System.EventHandler(this.menuViewDoctors_Click);
            // 
            // menuEditDoctors
            // 
            this.menuEditDoctors.BackColor = System.Drawing.Color.Teal;
            this.menuEditDoctors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuEditDoctors.Name = "menuEditDoctors";
            this.menuEditDoctors.Size = new System.Drawing.Size(190, 26);
            this.menuEditDoctors.Text = "Edit Doctors";
            this.menuEditDoctors.Click += new System.EventHandler(this.menuEditDoctors_Click);
            // 
            // menuPatients
            // 
            this.menuPatients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewPatients,
            this.menuEditPatient});
            this.menuPatients.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuPatients.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuPatients.Name = "menuPatients";
            this.menuPatients.Size = new System.Drawing.Size(88, 26);
            this.menuPatients.Text = "Patients";
            // 
            // menuViewPatients
            // 
            this.menuViewPatients.BackColor = System.Drawing.Color.Teal;
            this.menuViewPatients.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuViewPatients.Name = "menuViewPatients";
            this.menuViewPatients.Size = new System.Drawing.Size(191, 26);
            this.menuViewPatients.Text = "View Patients";
            this.menuViewPatients.Click += new System.EventHandler(this.menuViewPatients_Click);
            // 
            // menuEditPatient
            // 
            this.menuEditPatient.BackColor = System.Drawing.Color.Teal;
            this.menuEditPatient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuEditPatient.Name = "menuEditPatient";
            this.menuEditPatient.Size = new System.Drawing.Size(191, 26);
            this.menuEditPatient.Text = "Edit Patients";
            this.menuEditPatient.Click += new System.EventHandler(this.menuEditPatient_Click);
            // 
            // menuAboutProgram
            // 
            this.menuAboutProgram.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuAboutProgram.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuAboutProgram.Name = "menuAboutProgram";
            this.menuAboutProgram.Size = new System.Drawing.Size(168, 26);
            this.menuAboutProgram.Text = "About Application";
            this.menuAboutProgram.Click += new System.EventHandler(this.menuAboutProgram_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Teal;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoctors,
            this.menuPatients,
            this.menuCreate,
            this.menuAboutProgram});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(428, 30);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Main Menu";
            // 
            // menuCreate
            // 
            this.menuCreate.BackColor = System.Drawing.Color.Teal;
            this.menuCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMadication,
            this.menuRecipe});
            this.menuCreate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuCreate.Name = "menuCreate";
            this.menuCreate.Size = new System.Drawing.Size(78, 26);
            this.menuCreate.Text = "Create";
            // 
            // menuMadication
            // 
            this.menuMadication.BackColor = System.Drawing.Color.Teal;
            this.menuMadication.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuMadication.Name = "menuMadication";
            this.menuMadication.Size = new System.Drawing.Size(172, 26);
            this.menuMadication.Text = "Medication";
            this.menuMadication.Click += new System.EventHandler(this.menuMadication_Click);
            // 
            // menuRecipe
            // 
            this.menuRecipe.BackColor = System.Drawing.Color.Teal;
            this.menuRecipe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuRecipe.Name = "menuRecipe";
            this.menuRecipe.Size = new System.Drawing.Size(172, 26);
            this.menuRecipe.Text = "Recipe";
            this.menuRecipe.Click += new System.EventHandler(this.menuRecipe_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(12, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximumSize = new System.Drawing.Size(444, 405);
            this.MinimumSize = new System.Drawing.Size(444, 405);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registry Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuDoctors;
        private System.Windows.Forms.ToolStripMenuItem menuViewDoctors;
        private System.Windows.Forms.ToolStripMenuItem menuEditDoctors;
        private System.Windows.Forms.ToolStripMenuItem menuPatients;
        private System.Windows.Forms.ToolStripMenuItem menuViewPatients;
        private System.Windows.Forms.ToolStripMenuItem menuEditPatient;
        private System.Windows.Forms.ToolStripMenuItem menuAboutProgram;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem menuCreate;
        private System.Windows.Forms.ToolStripMenuItem menuMadication;
        private System.Windows.Forms.ToolStripMenuItem menuRecipe;
    }
}

