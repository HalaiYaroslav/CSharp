namespace Registry_Application
{
    partial class Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            this.listBox_DoctorsView = new System.Windows.Forms.ListBox();
            this.lb_InfoDoctorsForm = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.lb_Post = new System.Windows.Forms.Label();
            this.lb_Cabinet = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Cabinet = new System.Windows.Forms.TextBox();
            this.tb_Post = new System.Windows.Forms.TextBox();
            this.tb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lb_Floor = new System.Windows.Forms.Label();
            this.tb_Floor = new System.Windows.Forms.TextBox();
            this.listBox_ViewPatients = new System.Windows.Forms.ListBox();
            this.lb_ViewPatients = new System.Windows.Forms.Label();
            this.btn_RefreshListBoxes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_DoctorsView
            // 
            this.listBox_DoctorsView.BackColor = System.Drawing.Color.White;
            this.listBox_DoctorsView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_DoctorsView.ForeColor = System.Drawing.Color.Black;
            this.listBox_DoctorsView.FormattingEnabled = true;
            this.listBox_DoctorsView.ItemHeight = 19;
            this.listBox_DoctorsView.Location = new System.Drawing.Point(12, 33);
            this.listBox_DoctorsView.Name = "listBox_DoctorsView";
            this.listBox_DoctorsView.Size = new System.Drawing.Size(267, 289);
            this.listBox_DoctorsView.TabIndex = 0;
            this.listBox_DoctorsView.SelectedIndexChanged += new System.EventHandler(this.listBox_DoctorsView_SelectedIndexChanged);
            // 
            // lb_InfoDoctorsForm
            // 
            this.lb_InfoDoctorsForm.AutoSize = true;
            this.lb_InfoDoctorsForm.BackColor = System.Drawing.Color.Transparent;
            this.lb_InfoDoctorsForm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_InfoDoctorsForm.ForeColor = System.Drawing.Color.White;
            this.lb_InfoDoctorsForm.Location = new System.Drawing.Point(12, 9);
            this.lb_InfoDoctorsForm.Name = "lb_InfoDoctorsForm";
            this.lb_InfoDoctorsForm.Size = new System.Drawing.Size(267, 24);
            this.lb_InfoDoctorsForm.TabIndex = 1;
            this.lb_InfoDoctorsForm.Text = "Doctors who work in hospital";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.BackColor = System.Drawing.Color.Transparent;
            this.lb_Address.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Address.ForeColor = System.Drawing.Color.Black;
            this.lb_Address.Location = new System.Drawing.Point(283, 162);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(81, 24);
            this.lb_Address.TabIndex = 2;
            this.lb_Address.Text = "Address";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lb_PhoneNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_PhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(279, 230);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(144, 24);
            this.lb_PhoneNumber.TabIndex = 3;
            this.lb_PhoneNumber.Text = "Phone Number";
            // 
            // lb_Post
            // 
            this.lb_Post.AutoSize = true;
            this.lb_Post.BackColor = System.Drawing.Color.Transparent;
            this.lb_Post.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Post.ForeColor = System.Drawing.Color.Black;
            this.lb_Post.Location = new System.Drawing.Point(285, 295);
            this.lb_Post.Name = "lb_Post";
            this.lb_Post.Size = new System.Drawing.Size(50, 24);
            this.lb_Post.TabIndex = 4;
            this.lb_Post.Text = "Post";
            // 
            // lb_Cabinet
            // 
            this.lb_Cabinet.AutoSize = true;
            this.lb_Cabinet.BackColor = System.Drawing.Color.Transparent;
            this.lb_Cabinet.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Cabinet.ForeColor = System.Drawing.Color.Black;
            this.lb_Cabinet.Location = new System.Drawing.Point(284, 38);
            this.lb_Cabinet.Name = "lb_Cabinet";
            this.lb_Cabinet.Size = new System.Drawing.Size(80, 24);
            this.lb_Cabinet.TabIndex = 5;
            this.lb_Cabinet.Text = "Cabinet";
            // 
            // tb_Address
            // 
            this.tb_Address.BackColor = System.Drawing.Color.White;
            this.tb_Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Address.ForeColor = System.Drawing.Color.Black;
            this.tb_Address.Location = new System.Drawing.Point(429, 160);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.ReadOnly = true;
            this.tb_Address.Size = new System.Drawing.Size(202, 26);
            this.tb_Address.TabIndex = 6;
            // 
            // tb_Cabinet
            // 
            this.tb_Cabinet.BackColor = System.Drawing.Color.White;
            this.tb_Cabinet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Cabinet.ForeColor = System.Drawing.Color.Black;
            this.tb_Cabinet.Location = new System.Drawing.Point(429, 36);
            this.tb_Cabinet.Name = "tb_Cabinet";
            this.tb_Cabinet.ReadOnly = true;
            this.tb_Cabinet.Size = new System.Drawing.Size(202, 26);
            this.tb_Cabinet.TabIndex = 7;
            // 
            // tb_Post
            // 
            this.tb_Post.BackColor = System.Drawing.Color.White;
            this.tb_Post.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Post.ForeColor = System.Drawing.Color.Black;
            this.tb_Post.Location = new System.Drawing.Point(429, 296);
            this.tb_Post.Name = "tb_Post";
            this.tb_Post.ReadOnly = true;
            this.tb_Post.Size = new System.Drawing.Size(202, 26);
            this.tb_Post.TabIndex = 8;
            // 
            // tb_PhoneNumber
            // 
            this.tb_PhoneNumber.BackColor = System.Drawing.Color.White;
            this.tb_PhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_PhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.tb_PhoneNumber.Location = new System.Drawing.Point(429, 228);
            this.tb_PhoneNumber.Name = "tb_PhoneNumber";
            this.tb_PhoneNumber.ReadOnly = true;
            this.tb_PhoneNumber.Size = new System.Drawing.Size(202, 26);
            this.tb_PhoneNumber.TabIndex = 9;
            // 
            // lb_Floor
            // 
            this.lb_Floor.AutoSize = true;
            this.lb_Floor.BackColor = System.Drawing.Color.Transparent;
            this.lb_Floor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Floor.ForeColor = System.Drawing.Color.Black;
            this.lb_Floor.Location = new System.Drawing.Point(283, 94);
            this.lb_Floor.Name = "lb_Floor";
            this.lb_Floor.Size = new System.Drawing.Size(59, 24);
            this.lb_Floor.TabIndex = 10;
            this.lb_Floor.Text = "Floor";
            // 
            // tb_Floor
            // 
            this.tb_Floor.BackColor = System.Drawing.Color.White;
            this.tb_Floor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Floor.ForeColor = System.Drawing.Color.Black;
            this.tb_Floor.Location = new System.Drawing.Point(429, 95);
            this.tb_Floor.Name = "tb_Floor";
            this.tb_Floor.ReadOnly = true;
            this.tb_Floor.Size = new System.Drawing.Size(202, 26);
            this.tb_Floor.TabIndex = 11;
            // 
            // listBox_ViewPatients
            // 
            this.listBox_ViewPatients.BackColor = System.Drawing.Color.White;
            this.listBox_ViewPatients.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_ViewPatients.ForeColor = System.Drawing.Color.Black;
            this.listBox_ViewPatients.FormattingEnabled = true;
            this.listBox_ViewPatients.ItemHeight = 19;
            this.listBox_ViewPatients.Location = new System.Drawing.Point(654, 33);
            this.listBox_ViewPatients.Name = "listBox_ViewPatients";
            this.listBox_ViewPatients.Size = new System.Drawing.Size(267, 289);
            this.listBox_ViewPatients.TabIndex = 12;
            this.listBox_ViewPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_ViewPatients_MouseClick);
            // 
            // lb_ViewPatients
            // 
            this.lb_ViewPatients.AutoSize = true;
            this.lb_ViewPatients.BackColor = System.Drawing.Color.Transparent;
            this.lb_ViewPatients.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ViewPatients.ForeColor = System.Drawing.Color.White;
            this.lb_ViewPatients.Location = new System.Drawing.Point(650, 9);
            this.lb_ViewPatients.Name = "lb_ViewPatients";
            this.lb_ViewPatients.Size = new System.Drawing.Size(132, 24);
            this.lb_ViewPatients.TabIndex = 13;
            this.lb_ViewPatients.Text = "Their patients";
            // 
            // btn_RefreshListBoxes
            // 
            this.btn_RefreshListBoxes.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RefreshListBoxes.CausesValidation = false;
            this.btn_RefreshListBoxes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RefreshListBoxes.ForeColor = System.Drawing.Color.Black;
            this.btn_RefreshListBoxes.Location = new System.Drawing.Point(429, 9);
            this.btn_RefreshListBoxes.Name = "btn_RefreshListBoxes";
            this.btn_RefreshListBoxes.Size = new System.Drawing.Size(202, 23);
            this.btn_RefreshListBoxes.TabIndex = 14;
            this.btn_RefreshListBoxes.Text = "Refresh lists";
            this.btn_RefreshListBoxes.UseVisualStyleBackColor = false;
            this.btn_RefreshListBoxes.Click += new System.EventHandler(this.btn_RefreshListBoxes_Click);
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 330);
            this.Controls.Add(this.btn_RefreshListBoxes);
            this.Controls.Add(this.lb_ViewPatients);
            this.Controls.Add(this.listBox_ViewPatients);
            this.Controls.Add(this.tb_Floor);
            this.Controls.Add(this.lb_Floor);
            this.Controls.Add(this.tb_PhoneNumber);
            this.Controls.Add(this.tb_Post);
            this.Controls.Add(this.tb_Cabinet);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.lb_Cabinet);
            this.Controls.Add(this.lb_Post);
            this.Controls.Add(this.lb_PhoneNumber);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_InfoDoctorsForm);
            this.Controls.Add(this.listBox_DoctorsView);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(949, 369);
            this.MinimumSize = new System.Drawing.Size(949, 369);
            this.Name = "Doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_DoctorsView;
        private System.Windows.Forms.Label lb_InfoDoctorsForm;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.Label lb_Post;
        private System.Windows.Forms.Label lb_Cabinet;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Cabinet;
        private System.Windows.Forms.TextBox tb_Post;
        private System.Windows.Forms.TextBox tb_PhoneNumber;
        private System.Windows.Forms.Label lb_Floor;
        private System.Windows.Forms.TextBox tb_Floor;
        private System.Windows.Forms.ListBox listBox_ViewPatients;
        private System.Windows.Forms.Label lb_ViewPatients;
        private System.Windows.Forms.Button btn_RefreshListBoxes;
    }
}