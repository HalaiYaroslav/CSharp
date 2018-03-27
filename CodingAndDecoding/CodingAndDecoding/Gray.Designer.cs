namespace CodingAndDecoding
{
    partial class Gray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gray));
            this.cmbx_TypeOfCoding = new System.Windows.Forms.ComboBox();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.btn_Encode = new System.Windows.Forms.Button();
            this.rdbtn_Decimal = new System.Windows.Forms.RadioButton();
            this.rdbtn_Binary = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbx_TypeOfCoding
            // 
            this.cmbx_TypeOfCoding.BackColor = System.Drawing.Color.Honeydew;
            this.cmbx_TypeOfCoding.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_TypeOfCoding.ForeColor = System.Drawing.Color.Maroon;
            this.cmbx_TypeOfCoding.FormattingEnabled = true;
            this.cmbx_TypeOfCoding.Items.AddRange(new object[] {
            "CODING",
            "DECODING"});
            this.cmbx_TypeOfCoding.Location = new System.Drawing.Point(189, 15);
            this.cmbx_TypeOfCoding.Name = "cmbx_TypeOfCoding";
            this.cmbx_TypeOfCoding.Size = new System.Drawing.Size(354, 29);
            this.cmbx_TypeOfCoding.TabIndex = 0;
            this.cmbx_TypeOfCoding.Tag = "";
            // 
            // tb_Input
            // 
            this.tb_Input.BackColor = System.Drawing.Color.Honeydew;
            this.tb_Input.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Input.ForeColor = System.Drawing.Color.Maroon;
            this.tb_Input.Location = new System.Drawing.Point(76, 114);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(180, 28);
            this.tb_Input.TabIndex = 1;
            // 
            // tb_Output
            // 
            this.tb_Output.BackColor = System.Drawing.Color.Honeydew;
            this.tb_Output.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.ForeColor = System.Drawing.Color.Maroon;
            this.tb_Output.Location = new System.Drawing.Point(363, 114);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(180, 28);
            this.tb_Output.TabIndex = 2;
            // 
            // btn_Encode
            // 
            this.btn_Encode.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Encode.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encode.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Encode.Location = new System.Drawing.Point(16, 164);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(527, 30);
            this.btn_Encode.TabIndex = 3;
            this.btn_Encode.Text = "Encode";
            this.btn_Encode.UseVisualStyleBackColor = false;
            this.btn_Encode.Click += new System.EventHandler(this.btn_Encode_Click);
            // 
            // rdbtn_Decimal
            // 
            this.rdbtn_Decimal.AutoSize = true;
            this.rdbtn_Decimal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdbtn_Decimal.Checked = true;
            this.rdbtn_Decimal.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Decimal.ForeColor = System.Drawing.Color.Maroon;
            this.rdbtn_Decimal.Location = new System.Drawing.Point(292, 67);
            this.rdbtn_Decimal.Name = "rdbtn_Decimal";
            this.rdbtn_Decimal.Size = new System.Drawing.Size(100, 25);
            this.rdbtn_Decimal.TabIndex = 4;
            this.rdbtn_Decimal.TabStop = true;
            this.rdbtn_Decimal.Text = "Decimal";
            this.rdbtn_Decimal.UseVisualStyleBackColor = false;
            // 
            // rdbtn_Binary
            // 
            this.rdbtn_Binary.AutoSize = true;
            this.rdbtn_Binary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdbtn_Binary.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Binary.ForeColor = System.Drawing.Color.Maroon;
            this.rdbtn_Binary.Location = new System.Drawing.Point(454, 67);
            this.rdbtn_Binary.Name = "rdbtn_Binary";
            this.rdbtn_Binary.Size = new System.Drawing.Size(89, 25);
            this.rdbtn_Binary.TabIndex = 5;
            this.rdbtn_Binary.Text = "Binary";
            this.rdbtn_Binary.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type of Coding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type of Input Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(276, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output";
            // 
            // Gray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 214);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbtn_Binary);
            this.Controls.Add(this.rdbtn_Decimal);
            this.Controls.Add(this.btn_Encode);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.cmbx_TypeOfCoding);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gray";
            this.Text = "Gray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_TypeOfCoding;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Button btn_Encode;
        private System.Windows.Forms.RadioButton rdbtn_Decimal;
        private System.Windows.Forms.RadioButton rdbtn_Binary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}