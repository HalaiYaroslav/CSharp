namespace Registry_Application
{
    partial class EditingPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingPatients));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AddNewPatient = new System.Windows.Forms.Button();
            this.btn_EditPatient = new System.Windows.Forms.Button();
            this.btn_RemovePatient = new System.Windows.Forms.Button();
            this.btn_AddDoctor = new System.Windows.Forms.Button();
            this.btn_AddRecipe = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_SureName = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_PhoneNumb = new System.Windows.Forms.TextBox();
            this.tb_Disease = new System.Windows.Forms.TextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.lstb_ViewPatients = new System.Windows.Forms.ListBox();
            this.lstb_ViewDoctors = new System.Windows.Forms.ListBox();
            this.lstb_ViewRecipes = new System.Windows.Forms.ListBox();
            this.lb_ViewPatients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sure Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Disease";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // btn_AddNewPatient
            // 
            this.btn_AddNewPatient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddNewPatient.Location = new System.Drawing.Point(130, 229);
            this.btn_AddNewPatient.Name = "btn_AddNewPatient";
            this.btn_AddNewPatient.Size = new System.Drawing.Size(148, 30);
            this.btn_AddNewPatient.TabIndex = 6;
            this.btn_AddNewPatient.Text = "Add New";
            this.btn_AddNewPatient.UseVisualStyleBackColor = true;
            this.btn_AddNewPatient.Click += new System.EventHandler(this.btn_AddNewPatient_Click);
            // 
            // btn_EditPatient
            // 
            this.btn_EditPatient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditPatient.Location = new System.Drawing.Point(527, 229);
            this.btn_EditPatient.Name = "btn_EditPatient";
            this.btn_EditPatient.Size = new System.Drawing.Size(148, 30);
            this.btn_EditPatient.TabIndex = 7;
            this.btn_EditPatient.Text = "Edit";
            this.btn_EditPatient.UseVisualStyleBackColor = true;
            this.btn_EditPatient.Click += new System.EventHandler(this.btn_EditPatient_Click);
            // 
            // btn_RemovePatient
            // 
            this.btn_RemovePatient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RemovePatient.Location = new System.Drawing.Point(681, 229);
            this.btn_RemovePatient.Name = "btn_RemovePatient";
            this.btn_RemovePatient.Size = new System.Drawing.Size(134, 30);
            this.btn_RemovePatient.TabIndex = 8;
            this.btn_RemovePatient.Text = "Remove";
            this.btn_RemovePatient.UseVisualStyleBackColor = true;
            this.btn_RemovePatient.Click += new System.EventHandler(this.btn_RemovePatient_Click);
            // 
            // btn_AddDoctor
            // 
            this.btn_AddDoctor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddDoctor.Location = new System.Drawing.Point(294, 12);
            this.btn_AddDoctor.Name = "btn_AddDoctor";
            this.btn_AddDoctor.Size = new System.Drawing.Size(66, 118);
            this.btn_AddDoctor.TabIndex = 9;
            this.btn_AddDoctor.Text = "Add Doctor";
            this.btn_AddDoctor.UseVisualStyleBackColor = true;
            this.btn_AddDoctor.Click += new System.EventHandler(this.btn_AddDoctor_Click);
            // 
            // btn_AddRecipe
            // 
            this.btn_AddRecipe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddRecipe.Location = new System.Drawing.Point(295, 136);
            this.btn_AddRecipe.Name = "btn_AddRecipe";
            this.btn_AddRecipe.Size = new System.Drawing.Size(65, 118);
            this.btn_AddRecipe.TabIndex = 10;
            this.btn_AddRecipe.Text = "Add Recipe";
            this.btn_AddRecipe.UseVisualStyleBackColor = true;
            this.btn_AddRecipe.Click += new System.EventHandler(this.btn_AddRecipe_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Name.Location = new System.Drawing.Point(140, 12);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(148, 29);
            this.tb_Name.TabIndex = 11;
            // 
            // tb_SureName
            // 
            this.tb_SureName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_SureName.Location = new System.Drawing.Point(140, 47);
            this.tb_SureName.Name = "tb_SureName";
            this.tb_SureName.Size = new System.Drawing.Size(148, 29);
            this.tb_SureName.TabIndex = 12;
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Address.Location = new System.Drawing.Point(140, 85);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(148, 29);
            this.tb_Address.TabIndex = 13;
            // 
            // tb_PhoneNumb
            // 
            this.tb_PhoneNumb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_PhoneNumb.Location = new System.Drawing.Point(140, 120);
            this.tb_PhoneNumb.Name = "tb_PhoneNumb";
            this.tb_PhoneNumb.Size = new System.Drawing.Size(148, 29);
            this.tb_PhoneNumb.TabIndex = 14;
            // 
            // tb_Disease
            // 
            this.tb_Disease.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Disease.Location = new System.Drawing.Point(140, 159);
            this.tb_Disease.Name = "tb_Disease";
            this.tb_Disease.Size = new System.Drawing.Size(148, 29);
            this.tb_Disease.TabIndex = 15;
            // 
            // tb_Date
            // 
            this.tb_Date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Date.Location = new System.Drawing.Point(140, 194);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(148, 29);
            this.tb_Date.TabIndex = 16;
            // 
            // lstb_ViewPatients
            // 
            this.lstb_ViewPatients.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstb_ViewPatients.FormattingEnabled = true;
            this.lstb_ViewPatients.ItemHeight = 23;
            this.lstb_ViewPatients.Location = new System.Drawing.Point(527, 35);
            this.lstb_ViewPatients.Name = "lstb_ViewPatients";
            this.lstb_ViewPatients.Size = new System.Drawing.Size(288, 188);
            this.lstb_ViewPatients.TabIndex = 17;
            this.lstb_ViewPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstb_ViewPatients_MouseClick);
            // 
            // lstb_ViewDoctors
            // 
            this.lstb_ViewDoctors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstb_ViewDoctors.FormattingEnabled = true;
            this.lstb_ViewDoctors.ItemHeight = 19;
            this.lstb_ViewDoctors.Location = new System.Drawing.Point(366, 12);
            this.lstb_ViewDoctors.Name = "lstb_ViewDoctors";
            this.lstb_ViewDoctors.Size = new System.Drawing.Size(155, 118);
            this.lstb_ViewDoctors.TabIndex = 18;
            // 
            // lstb_ViewRecipes
            // 
            this.lstb_ViewRecipes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstb_ViewRecipes.FormattingEnabled = true;
            this.lstb_ViewRecipes.ItemHeight = 19;
            this.lstb_ViewRecipes.Location = new System.Drawing.Point(366, 136);
            this.lstb_ViewRecipes.Name = "lstb_ViewRecipes";
            this.lstb_ViewRecipes.Size = new System.Drawing.Size(155, 118);
            this.lstb_ViewRecipes.TabIndex = 19;
            // 
            // lb_ViewPatients
            // 
            this.lb_ViewPatients.AutoSize = true;
            this.lb_ViewPatients.BackColor = System.Drawing.Color.Transparent;
            this.lb_ViewPatients.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ViewPatients.Location = new System.Drawing.Point(739, 12);
            this.lb_ViewPatients.Name = "lb_ViewPatients";
            this.lb_ViewPatients.Size = new System.Drawing.Size(76, 22);
            this.lb_ViewPatients.TabIndex = 20;
            this.lb_ViewPatients.Text = "Patients";
            // 
            // EditingPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 268);
            this.Controls.Add(this.lb_ViewPatients);
            this.Controls.Add(this.lstb_ViewRecipes);
            this.Controls.Add(this.lstb_ViewDoctors);
            this.Controls.Add(this.lstb_ViewPatients);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.tb_Disease);
            this.Controls.Add(this.tb_PhoneNumb);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_SureName);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_AddRecipe);
            this.Controls.Add(this.btn_AddDoctor);
            this.Controls.Add(this.btn_RemovePatient);
            this.Controls.Add(this.btn_EditPatient);
            this.Controls.Add(this.btn_AddNewPatient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(837, 307);
            this.MinimumSize = new System.Drawing.Size(837, 307);
            this.Name = "EditingPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditingPatients";
            this.Load += new System.EventHandler(this.EditingPatients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AddNewPatient;
        private System.Windows.Forms.Button btn_EditPatient;
        private System.Windows.Forms.Button btn_RemovePatient;
        private System.Windows.Forms.Button btn_AddDoctor;
        private System.Windows.Forms.Button btn_AddRecipe;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_SureName;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_PhoneNumb;
        private System.Windows.Forms.TextBox tb_Disease;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.ListBox lstb_ViewPatients;
        private System.Windows.Forms.ListBox lstb_ViewDoctors;
        private System.Windows.Forms.ListBox lstb_ViewRecipes;
        private System.Windows.Forms.Label lb_ViewPatients;
    }
}