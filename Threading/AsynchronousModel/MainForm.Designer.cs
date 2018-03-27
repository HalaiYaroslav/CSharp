namespace AsynchronousModel
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
            this.isCompleteButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.callbackButton = new System.Windows.Forms.Button();
            this.isCompleteState = new System.Windows.Forms.Label();
            this.endState = new System.Windows.Forms.Label();
            this.callbackState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isCompleteButton
            // 
            this.isCompleteButton.Location = new System.Drawing.Point(12, 12);
            this.isCompleteButton.Name = "isCompleteButton";
            this.isCompleteButton.Size = new System.Drawing.Size(75, 23);
            this.isCompleteButton.TabIndex = 0;
            this.isCompleteButton.Text = "IsComplete";
            this.isCompleteButton.UseVisualStyleBackColor = true;
            this.isCompleteButton.Click += new System.EventHandler(this.isCompleteButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(93, 12);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 1;
            this.endButton.Text = "End";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // callbackButton
            // 
            this.callbackButton.Location = new System.Drawing.Point(174, 12);
            this.callbackButton.Name = "callbackButton";
            this.callbackButton.Size = new System.Drawing.Size(75, 23);
            this.callbackButton.TabIndex = 2;
            this.callbackButton.Text = "Callback";
            this.callbackButton.UseVisualStyleBackColor = true;
            this.callbackButton.Click += new System.EventHandler(this.callbackButton_Click);
            // 
            // isCompleteState
            // 
            this.isCompleteState.AutoSize = true;
            this.isCompleteState.Location = new System.Drawing.Point(12, 53);
            this.isCompleteState.Name = "isCompleteState";
            this.isCompleteState.Size = new System.Drawing.Size(59, 13);
            this.isCompleteState.TabIndex = 3;
            this.isCompleteState.Text = "IsComplete";
            // 
            // endState
            // 
            this.endState.AutoSize = true;
            this.endState.Location = new System.Drawing.Point(90, 53);
            this.endState.Name = "endState";
            this.endState.Size = new System.Drawing.Size(59, 13);
            this.endState.TabIndex = 4;
            this.endState.Text = "IsComplete";
            // 
            // callbackState
            // 
            this.callbackState.AutoSize = true;
            this.callbackState.Location = new System.Drawing.Point(171, 53);
            this.callbackState.Name = "callbackState";
            this.callbackState.Size = new System.Drawing.Size(59, 13);
            this.callbackState.TabIndex = 5;
            this.callbackState.Text = "IsComplete";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 75);
            this.Controls.Add(this.callbackState);
            this.Controls.Add(this.endState);
            this.Controls.Add(this.isCompleteState);
            this.Controls.Add(this.callbackButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.isCompleteButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button isCompleteButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button callbackButton;
        private System.Windows.Forms.Label isCompleteState;
        private System.Windows.Forms.Label endState;
        private System.Windows.Forms.Label callbackState;
    }
}

