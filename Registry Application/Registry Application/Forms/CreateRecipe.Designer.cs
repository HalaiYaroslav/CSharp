namespace Registry_Application
{
    partial class CreateRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRecipe));
            this.lb_ViewRecipes = new System.Windows.Forms.Label();
            this.lb_Disease = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_ViewDoctor = new System.Windows.Forms.Label();
            this.lb_ViewMedications = new System.Windows.Forms.Label();
            this.tb_Disease = new System.Windows.Forms.TextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.lstb_ViewRecipes = new System.Windows.Forms.ListBox();
            this.lstb_ViewDoctors = new System.Windows.Forms.ListBox();
            this.lstb_ViewMedications = new System.Windows.Forms.ListBox();
            this.btn_AddRecipe = new System.Windows.Forms.Button();
            this.btn_AddDoctorToRecipe = new System.Windows.Forms.Button();
            this.btn_AddMedicationToRecipe = new System.Windows.Forms.Button();
            this.btn_RemoveRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ViewRecipes
            // 
            this.lb_ViewRecipes.AutoSize = true;
            this.lb_ViewRecipes.BackColor = System.Drawing.Color.Transparent;
            this.lb_ViewRecipes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ViewRecipes.ForeColor = System.Drawing.Color.White;
            this.lb_ViewRecipes.Location = new System.Drawing.Point(12, 9);
            this.lb_ViewRecipes.Name = "lb_ViewRecipes";
            this.lb_ViewRecipes.Size = new System.Drawing.Size(74, 22);
            this.lb_ViewRecipes.TabIndex = 0;
            this.lb_ViewRecipes.Text = "Recipes";
            // 
            // lb_Disease
            // 
            this.lb_Disease.AutoSize = true;
            this.lb_Disease.BackColor = System.Drawing.Color.Transparent;
            this.lb_Disease.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Disease.ForeColor = System.Drawing.Color.White;
            this.lb_Disease.Location = new System.Drawing.Point(5, 234);
            this.lb_Disease.Name = "lb_Disease";
            this.lb_Disease.Size = new System.Drawing.Size(73, 22);
            this.lb_Disease.TabIndex = 1;
            this.lb_Disease.Text = "Disease";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.BackColor = System.Drawing.Color.Transparent;
            this.lb_Date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Date.ForeColor = System.Drawing.Color.White;
            this.lb_Date.Location = new System.Drawing.Point(5, 271);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(49, 22);
            this.lb_Date.TabIndex = 2;
            this.lb_Date.Text = "Date";
            // 
            // lb_ViewDoctor
            // 
            this.lb_ViewDoctor.AutoSize = true;
            this.lb_ViewDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lb_ViewDoctor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ViewDoctor.ForeColor = System.Drawing.Color.White;
            this.lb_ViewDoctor.Location = new System.Drawing.Point(319, 9);
            this.lb_ViewDoctor.Name = "lb_ViewDoctor";
            this.lb_ViewDoctor.Size = new System.Drawing.Size(67, 22);
            this.lb_ViewDoctor.TabIndex = 4;
            this.lb_ViewDoctor.Text = "Doctor";
            // 
            // lb_ViewMedications
            // 
            this.lb_ViewMedications.AutoSize = true;
            this.lb_ViewMedications.BackColor = System.Drawing.Color.Transparent;
            this.lb_ViewMedications.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ViewMedications.ForeColor = System.Drawing.Color.White;
            this.lb_ViewMedications.Location = new System.Drawing.Point(476, 9);
            this.lb_ViewMedications.Name = "lb_ViewMedications";
            this.lb_ViewMedications.Size = new System.Drawing.Size(110, 22);
            this.lb_ViewMedications.TabIndex = 5;
            this.lb_ViewMedications.Text = "Medications";
            // 
            // tb_Disease
            // 
            this.tb_Disease.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Disease.Location = new System.Drawing.Point(84, 227);
            this.tb_Disease.Name = "tb_Disease";
            this.tb_Disease.Size = new System.Drawing.Size(233, 29);
            this.tb_Disease.TabIndex = 6;
            // 
            // tb_Date
            // 
            this.tb_Date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Date.Location = new System.Drawing.Point(84, 264);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(233, 29);
            this.tb_Date.TabIndex = 7;
            // 
            // lstb_ViewRecipes
            // 
            this.lstb_ViewRecipes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstb_ViewRecipes.FormattingEnabled = true;
            this.lstb_ViewRecipes.HorizontalScrollbar = true;
            this.lstb_ViewRecipes.ItemHeight = 23;
            this.lstb_ViewRecipes.Location = new System.Drawing.Point(9, 34);
            this.lstb_ViewRecipes.Name = "lstb_ViewRecipes";
            this.lstb_ViewRecipes.Size = new System.Drawing.Size(308, 188);
            this.lstb_ViewRecipes.TabIndex = 8;
            // 
            // lstb_ViewDoctors
            // 
            this.lstb_ViewDoctors.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstb_ViewDoctors.FormattingEnabled = true;
            this.lstb_ViewDoctors.HorizontalScrollbar = true;
            this.lstb_ViewDoctors.ItemHeight = 21;
            this.lstb_ViewDoctors.Location = new System.Drawing.Point(323, 34);
            this.lstb_ViewDoctors.Name = "lstb_ViewDoctors";
            this.lstb_ViewDoctors.Size = new System.Drawing.Size(151, 151);
            this.lstb_ViewDoctors.TabIndex = 10;
            // 
            // lstb_ViewMedications
            // 
            this.lstb_ViewMedications.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstb_ViewMedications.FormattingEnabled = true;
            this.lstb_ViewMedications.HorizontalScrollbar = true;
            this.lstb_ViewMedications.ItemHeight = 21;
            this.lstb_ViewMedications.Location = new System.Drawing.Point(480, 34);
            this.lstb_ViewMedications.Name = "lstb_ViewMedications";
            this.lstb_ViewMedications.Size = new System.Drawing.Size(151, 151);
            this.lstb_ViewMedications.TabIndex = 11;
            // 
            // btn_AddRecipe
            // 
            this.btn_AddRecipe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddRecipe.Location = new System.Drawing.Point(324, 225);
            this.btn_AddRecipe.Name = "btn_AddRecipe";
            this.btn_AddRecipe.Size = new System.Drawing.Size(305, 30);
            this.btn_AddRecipe.TabIndex = 12;
            this.btn_AddRecipe.Text = "Add Recipe";
            this.btn_AddRecipe.UseVisualStyleBackColor = true;
            this.btn_AddRecipe.Click += new System.EventHandler(this.btn_AddRecipe_Click);
            // 
            // btn_AddDoctorToRecipe
            // 
            this.btn_AddDoctorToRecipe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddDoctorToRecipe.Location = new System.Drawing.Point(323, 192);
            this.btn_AddDoctorToRecipe.Name = "btn_AddDoctorToRecipe";
            this.btn_AddDoctorToRecipe.Size = new System.Drawing.Size(150, 30);
            this.btn_AddDoctorToRecipe.TabIndex = 14;
            this.btn_AddDoctorToRecipe.Text = "Add doctor ";
            this.btn_AddDoctorToRecipe.UseVisualStyleBackColor = true;
            this.btn_AddDoctorToRecipe.Click += new System.EventHandler(this.btn_AddDoctorToRecipe_Click);
            // 
            // btn_AddMedicationToRecipe
            // 
            this.btn_AddMedicationToRecipe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddMedicationToRecipe.Location = new System.Drawing.Point(481, 189);
            this.btn_AddMedicationToRecipe.Name = "btn_AddMedicationToRecipe";
            this.btn_AddMedicationToRecipe.Size = new System.Drawing.Size(150, 30);
            this.btn_AddMedicationToRecipe.TabIndex = 15;
            this.btn_AddMedicationToRecipe.Text = "Add medication";
            this.btn_AddMedicationToRecipe.UseVisualStyleBackColor = true;
            this.btn_AddMedicationToRecipe.Click += new System.EventHandler(this.btn_AddMedicationToRecipe_Click);
            // 
            // btn_RemoveRecipe
            // 
            this.btn_RemoveRecipe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RemoveRecipe.Location = new System.Drawing.Point(324, 261);
            this.btn_RemoveRecipe.Name = "btn_RemoveRecipe";
            this.btn_RemoveRecipe.Size = new System.Drawing.Size(305, 30);
            this.btn_RemoveRecipe.TabIndex = 16;
            this.btn_RemoveRecipe.Text = "Remove Recipe";
            this.btn_RemoveRecipe.UseVisualStyleBackColor = true;
            this.btn_RemoveRecipe.Click += new System.EventHandler(this.btn_RemoveRecipe_Click);
            // 
            // CreateRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 303);
            this.Controls.Add(this.btn_RemoveRecipe);
            this.Controls.Add(this.btn_AddMedicationToRecipe);
            this.Controls.Add(this.btn_AddDoctorToRecipe);
            this.Controls.Add(this.btn_AddRecipe);
            this.Controls.Add(this.lstb_ViewMedications);
            this.Controls.Add(this.lstb_ViewDoctors);
            this.Controls.Add(this.lstb_ViewRecipes);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.tb_Disease);
            this.Controls.Add(this.lb_ViewMedications);
            this.Controls.Add(this.lb_ViewDoctor);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.lb_Disease);
            this.Controls.Add(this.lb_ViewRecipes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.Name = "CreateRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRecipe";
            this.Load += new System.EventHandler(this.CreateRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ViewRecipes;
        private System.Windows.Forms.Label lb_Disease;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_ViewDoctor;
        private System.Windows.Forms.Label lb_ViewMedications;
        private System.Windows.Forms.TextBox tb_Disease;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.ListBox lstb_ViewRecipes;
        private System.Windows.Forms.ListBox lstb_ViewDoctors;
        private System.Windows.Forms.ListBox lstb_ViewMedications;
        private System.Windows.Forms.Button btn_AddRecipe;
        private System.Windows.Forms.Button btn_AddDoctorToRecipe;
        private System.Windows.Forms.Button btn_AddMedicationToRecipe;
        private System.Windows.Forms.Button btn_RemoveRecipe;
    }
}