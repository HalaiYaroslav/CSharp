namespace Registry_Application
{
    partial class EditingDoctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingDoctors));
            this.btn_AddNewDoctor = new System.Windows.Forms.Button();
            this.lstb_ViewDoctors = new System.Windows.Forms.ListBox();
            this.btn_EditDoctor = new System.Windows.Forms.Button();
            this.tbx_Floor = new System.Windows.Forms.TextBox();
            this.tbx_NumberOfCabinet = new System.Windows.Forms.TextBox();
            this.lb_Floor = new System.Windows.Forms.Label();
            this.lb_Number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Post = new System.Windows.Forms.TextBox();
            this.tbx_PhoneNumber = new System.Windows.Forms.TextBox();
            this.tbx_Address = new System.Windows.Forms.TextBox();
            this.tbx_SureNAme = new System.Windows.Forms.TextBox();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lb_Post = new System.Windows.Forms.Label();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_SureName = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.btn_RemoveDoctor = new System.Windows.Forms.Button();
            this.listBox_ViewPatients = new System.Windows.Forms.ListBox();
            this.btn_AddPatientToDoctor_sList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddNewDoctor
            // 
            this.btn_AddNewDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddNewDoctor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddNewDoctor.Location = new System.Drawing.Point(12, 292);
            this.btn_AddNewDoctor.Name = "btn_AddNewDoctor";
            this.btn_AddNewDoctor.Size = new System.Drawing.Size(141, 29);
            this.btn_AddNewDoctor.TabIndex = 0;
            this.btn_AddNewDoctor.Text = "Add New";
            this.btn_AddNewDoctor.UseVisualStyleBackColor = true;
            this.btn_AddNewDoctor.Click += new System.EventHandler(this.btn_AddNewDoctor_Click);
            // 
            // lstb_ViewDoctors
            // 
            this.lstb_ViewDoctors.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstb_ViewDoctors.FormattingEnabled = true;
            this.lstb_ViewDoctors.ItemHeight = 21;
            this.lstb_ViewDoctors.Location = new System.Drawing.Point(434, 11);
            this.lstb_ViewDoctors.Name = "lstb_ViewDoctors";
            this.lstb_ViewDoctors.Size = new System.Drawing.Size(234, 382);
            this.lstb_ViewDoctors.TabIndex = 1;
            this.lstb_ViewDoctors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstb_ViewDoctors_MouseClick);
            // 
            // btn_EditDoctor
            // 
            this.btn_EditDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditDoctor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_EditDoctor.Location = new System.Drawing.Point(12, 327);
            this.btn_EditDoctor.Name = "btn_EditDoctor";
            this.btn_EditDoctor.Size = new System.Drawing.Size(141, 29);
            this.btn_EditDoctor.TabIndex = 2;
            this.btn_EditDoctor.Text = "Edit";
            this.btn_EditDoctor.UseVisualStyleBackColor = true;
            this.btn_EditDoctor.Click += new System.EventHandler(this.btn_EditDoctor_Click);
            // 
            // tbx_Floor
            // 
            this.tbx_Floor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_Floor.Location = new System.Drawing.Point(166, 243);
            this.tbx_Floor.Name = "tbx_Floor";
            this.tbx_Floor.Size = new System.Drawing.Size(262, 29);
            this.tbx_Floor.TabIndex = 32;
            // 
            // tbx_NumberOfCabinet
            // 
            this.tbx_NumberOfCabinet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_NumberOfCabinet.Location = new System.Drawing.Point(166, 205);
            this.tbx_NumberOfCabinet.Name = "tbx_NumberOfCabinet";
            this.tbx_NumberOfCabinet.Size = new System.Drawing.Size(262, 29);
            this.tbx_NumberOfCabinet.TabIndex = 31;
            // 
            // lb_Floor
            // 
            this.lb_Floor.AutoSize = true;
            this.lb_Floor.BackColor = System.Drawing.Color.Transparent;
            this.lb_Floor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Floor.Location = new System.Drawing.Point(12, 243);
            this.lb_Floor.Name = "lb_Floor";
            this.lb_Floor.Size = new System.Drawing.Size(55, 22);
            this.lb_Floor.TabIndex = 30;
            this.lb_Floor.Text = "Floor";
            // 
            // lb_Number
            // 
            this.lb_Number.AutoSize = true;
            this.lb_Number.BackColor = System.Drawing.Color.Transparent;
            this.lb_Number.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Number.Location = new System.Drawing.Point(12, 205);
            this.lb_Number.Name = "lb_Number";
            this.lb_Number.Size = new System.Drawing.Size(153, 19);
            this.lb_Number.TabIndex = 29;
            this.lb_Number.Text = "Number Of Cabinet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(225, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Doctor\'s Cabinet";
            // 
            // tbx_Post
            // 
            this.tbx_Post.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_Post.Location = new System.Drawing.Point(166, 152);
            this.tbx_Post.Name = "tbx_Post";
            this.tbx_Post.Size = new System.Drawing.Size(262, 29);
            this.tbx_Post.TabIndex = 26;
            // 
            // tbx_PhoneNumber
            // 
            this.tbx_PhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_PhoneNumber.Location = new System.Drawing.Point(166, 117);
            this.tbx_PhoneNumber.Name = "tbx_PhoneNumber";
            this.tbx_PhoneNumber.Size = new System.Drawing.Size(262, 29);
            this.tbx_PhoneNumber.TabIndex = 25;
            // 
            // tbx_Address
            // 
            this.tbx_Address.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_Address.Location = new System.Drawing.Point(166, 82);
            this.tbx_Address.Name = "tbx_Address";
            this.tbx_Address.Size = new System.Drawing.Size(262, 29);
            this.tbx_Address.TabIndex = 24;
            // 
            // tbx_SureNAme
            // 
            this.tbx_SureNAme.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_SureNAme.Location = new System.Drawing.Point(166, 47);
            this.tbx_SureNAme.Name = "tbx_SureNAme";
            this.tbx_SureNAme.Size = new System.Drawing.Size(262, 29);
            this.tbx_SureNAme.TabIndex = 23;
            // 
            // tbx_Name
            // 
            this.tbx_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_Name.Location = new System.Drawing.Point(166, 12);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(262, 29);
            this.tbx_Name.TabIndex = 22;
            // 
            // lb_Post
            // 
            this.lb_Post.AutoSize = true;
            this.lb_Post.BackColor = System.Drawing.Color.Transparent;
            this.lb_Post.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Post.Location = new System.Drawing.Point(12, 152);
            this.lb_Post.Name = "lb_Post";
            this.lb_Post.Size = new System.Drawing.Size(46, 22);
            this.lb_Post.TabIndex = 21;
            this.lb_Post.Text = "Post";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lb_PhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_PhoneNumber.Location = new System.Drawing.Point(12, 117);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.lb_PhoneNumber.TabIndex = 20;
            this.lb_PhoneNumber.Text = "Phone Number";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.BackColor = System.Drawing.Color.Transparent;
            this.lb_Address.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Address.Location = new System.Drawing.Point(12, 82);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(76, 22);
            this.lb_Address.TabIndex = 19;
            this.lb_Address.Text = "Address";
            // 
            // lb_SureName
            // 
            this.lb_SureName.AutoSize = true;
            this.lb_SureName.BackColor = System.Drawing.Color.Transparent;
            this.lb_SureName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_SureName.Location = new System.Drawing.Point(12, 47);
            this.lb_SureName.Name = "lb_SureName";
            this.lb_SureName.Size = new System.Drawing.Size(101, 22);
            this.lb_SureName.TabIndex = 18;
            this.lb_SureName.Text = "Sure Name";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Name.Location = new System.Drawing.Point(12, 12);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(58, 22);
            this.lb_Name.TabIndex = 17;
            this.lb_Name.Text = "Name";
            // 
            // btn_RemoveDoctor
            // 
            this.btn_RemoveDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RemoveDoctor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_RemoveDoctor.Location = new System.Drawing.Point(12, 362);
            this.btn_RemoveDoctor.Name = "btn_RemoveDoctor";
            this.btn_RemoveDoctor.Size = new System.Drawing.Size(141, 32);
            this.btn_RemoveDoctor.TabIndex = 33;
            this.btn_RemoveDoctor.Text = "Remove";
            this.btn_RemoveDoctor.UseVisualStyleBackColor = true;
            this.btn_RemoveDoctor.Click += new System.EventHandler(this.btn_RemoveDoctor_Click);
            // 
            // listBox_ViewPatients
            // 
            this.listBox_ViewPatients.FormattingEnabled = true;
            this.listBox_ViewPatients.Location = new System.Drawing.Point(166, 312);
            this.listBox_ViewPatients.Name = "listBox_ViewPatients";
            this.listBox_ViewPatients.Size = new System.Drawing.Size(262, 82);
            this.listBox_ViewPatients.TabIndex = 34;
            // 
            // btn_AddPatientToDoctor_sList
            // 
            this.btn_AddPatientToDoctor_sList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddPatientToDoctor_sList.Location = new System.Drawing.Point(166, 278);
            this.btn_AddPatientToDoctor_sList.Name = "btn_AddPatientToDoctor_sList";
            this.btn_AddPatientToDoctor_sList.Size = new System.Drawing.Size(262, 28);
            this.btn_AddPatientToDoctor_sList.TabIndex = 35;
            this.btn_AddPatientToDoctor_sList.Text = "Add patients to doctor\'s patientlist";
            this.btn_AddPatientToDoctor_sList.UseVisualStyleBackColor = true;
            this.btn_AddPatientToDoctor_sList.Click += new System.EventHandler(this.btn_AddPatientToDoctor_sList_Click);
            // 
            // EditingDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 405);
            this.Controls.Add(this.btn_AddPatientToDoctor_sList);
            this.Controls.Add(this.listBox_ViewPatients);
            this.Controls.Add(this.btn_RemoveDoctor);
            this.Controls.Add(this.tbx_Floor);
            this.Controls.Add(this.tbx_NumberOfCabinet);
            this.Controls.Add(this.lb_Floor);
            this.Controls.Add(this.lb_Number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Post);
            this.Controls.Add(this.tbx_PhoneNumber);
            this.Controls.Add(this.tbx_Address);
            this.Controls.Add(this.tbx_SureNAme);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.lb_Post);
            this.Controls.Add(this.lb_PhoneNumber);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_SureName);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.btn_EditDoctor);
            this.Controls.Add(this.lstb_ViewDoctors);
            this.Controls.Add(this.btn_AddNewDoctor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(696, 444);
            this.MinimumSize = new System.Drawing.Size(696, 444);
            this.Name = "EditingDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditingDoctors";
            this.Load += new System.EventHandler(this.EditingDoctors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNewDoctor;
        public System.Windows.Forms.ListBox lstb_ViewDoctors;
        private System.Windows.Forms.Button btn_EditDoctor;
        private System.Windows.Forms.TextBox tbx_Floor;
        private System.Windows.Forms.TextBox tbx_NumberOfCabinet;
        private System.Windows.Forms.Label lb_Floor;
        private System.Windows.Forms.Label lb_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Post;
        private System.Windows.Forms.TextBox tbx_PhoneNumber;
        private System.Windows.Forms.TextBox tbx_Address;
        private System.Windows.Forms.TextBox tbx_SureNAme;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lb_Post;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_SureName;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_RemoveDoctor;
        private System.Windows.Forms.ListBox listBox_ViewPatients;
        private System.Windows.Forms.Button btn_AddPatientToDoctor_sList;
    }
}