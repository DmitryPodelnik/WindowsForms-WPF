namespace _21._11._20_Text_Editor_EXAM
{
    partial class SaveForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelSaveButton = new System.Windows.Forms.Button();
            this.doNotSaveButton = new System.Windows.Forms.Button();
            this.saveSaveButton = new System.Windows.Forms.Button();
            this.saveSureLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancelSaveButton);
            this.panel1.Controls.Add(this.doNotSaveButton);
            this.panel1.Controls.Add(this.saveSaveButton);
            this.panel1.Location = new System.Drawing.Point(-1, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 59);
            this.panel1.TabIndex = 0;
            // 
            // cancelSaveButton
            // 
            this.cancelSaveButton.Location = new System.Drawing.Point(322, 14);
            this.cancelSaveButton.Name = "cancelSaveButton";
            this.cancelSaveButton.Size = new System.Drawing.Size(108, 27);
            this.cancelSaveButton.TabIndex = 2;
            this.cancelSaveButton.Text = "Cancel";
            this.cancelSaveButton.UseVisualStyleBackColor = true;
            this.cancelSaveButton.Click += new System.EventHandler(this.cancelSaveButton_Click);
            // 
            // doNotSaveButton
            // 
            this.doNotSaveButton.Location = new System.Drawing.Point(182, 14);
            this.doNotSaveButton.Name = "doNotSaveButton";
            this.doNotSaveButton.Size = new System.Drawing.Size(134, 27);
            this.doNotSaveButton.TabIndex = 1;
            this.doNotSaveButton.Text = "Do not Save";
            this.doNotSaveButton.UseVisualStyleBackColor = true;
            this.doNotSaveButton.Click += new System.EventHandler(this.doNotSaveButton_Click);
            // 
            // saveSaveButton
            // 
            this.saveSaveButton.Location = new System.Drawing.Point(42, 14);
            this.saveSaveButton.Name = "saveSaveButton";
            this.saveSaveButton.Size = new System.Drawing.Size(134, 27);
            this.saveSaveButton.TabIndex = 0;
            this.saveSaveButton.Text = "Save";
            this.saveSaveButton.UseVisualStyleBackColor = true;
            this.saveSaveButton.Click += new System.EventHandler(this.saveSaveButton_Click);
            // 
            // saveSureLabel
            // 
            this.saveSureLabel.AutoSize = true;
            this.saveSureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveSureLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.saveSureLabel.Location = new System.Drawing.Point(12, 29);
            this.saveSureLabel.Name = "saveSureLabel";
            this.saveSureLabel.Size = new System.Drawing.Size(314, 24);
            this.saveSureLabel.TabIndex = 1;
            this.saveSureLabel.Text = "Do you want to save changes in file  \r\n";
            this.saveSureLabel.Click += new System.EventHandler(this.saveSureLabel_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 158);
            this.Controls.Add(this.saveSureLabel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notebook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaveForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveSaveButton;
        private System.Windows.Forms.Button doNotSaveButton;
        private System.Windows.Forms.Button cancelSaveButton;
        private System.Windows.Forms.Label saveSureLabel;
    }
}