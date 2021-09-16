namespace _21._11._20_Text_Editor_EXAM
{
    partial class Replace
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
            this.searchNextReplaceButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.whatTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.whatReplaceLabel = new System.Windows.Forms.Label();
            this.toReplaceLabel = new System.Windows.Forms.Label();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.cancelReplaceButton = new System.Windows.Forms.Button();
            this.caseSensitiveReplaceCheckBox = new System.Windows.Forms.CheckBox();
            this.textWrappingReplaceCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // searchNextReplaceButton
            // 
            this.searchNextReplaceButton.Location = new System.Drawing.Point(362, 12);
            this.searchNextReplaceButton.Name = "searchNextReplaceButton";
            this.searchNextReplaceButton.Size = new System.Drawing.Size(103, 28);
            this.searchNextReplaceButton.TabIndex = 1;
            this.searchNextReplaceButton.Text = "Search next";
            this.searchNextReplaceButton.UseVisualStyleBackColor = true;
            this.searchNextReplaceButton.Click += new System.EventHandler(this.searchNextButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(362, 46);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(103, 28);
            this.replaceButton.TabIndex = 3;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceReplaceButton_Click);
            // 
            // whatTextBox
            // 
            this.whatTextBox.HideSelection = false;
            this.whatTextBox.Location = new System.Drawing.Point(60, 19);
            this.whatTextBox.Name = "whatTextBox";
            this.whatTextBox.Size = new System.Drawing.Size(284, 22);
            this.whatTextBox.TabIndex = 4;
            // 
            // toTextBox
            // 
            this.toTextBox.HideSelection = false;
            this.toTextBox.Location = new System.Drawing.Point(60, 52);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(284, 22);
            this.toTextBox.TabIndex = 5;
            // 
            // whatReplaceLabel
            // 
            this.whatReplaceLabel.AutoSize = true;
            this.whatReplaceLabel.Location = new System.Drawing.Point(9, 20);
            this.whatReplaceLabel.Name = "whatReplaceLabel";
            this.whatReplaceLabel.Size = new System.Drawing.Size(45, 17);
            this.whatReplaceLabel.TabIndex = 6;
            this.whatReplaceLabel.Text = "What:";
            // 
            // toReplaceLabel
            // 
            this.toReplaceLabel.AutoSize = true;
            this.toReplaceLabel.Location = new System.Drawing.Point(9, 53);
            this.toReplaceLabel.Name = "toReplaceLabel";
            this.toReplaceLabel.Size = new System.Drawing.Size(29, 17);
            this.toReplaceLabel.TabIndex = 7;
            this.toReplaceLabel.Text = "To:";
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.Location = new System.Drawing.Point(362, 80);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(103, 28);
            this.replaceAllButton.TabIndex = 8;
            this.replaceAllButton.Text = "Replace all";
            this.replaceAllButton.UseVisualStyleBackColor = true;
            this.replaceAllButton.Click += new System.EventHandler(this.replaceAllButton_Click);
            // 
            // cancelReplaceButton
            // 
            this.cancelReplaceButton.Location = new System.Drawing.Point(362, 114);
            this.cancelReplaceButton.Name = "cancelReplaceButton";
            this.cancelReplaceButton.Size = new System.Drawing.Size(103, 28);
            this.cancelReplaceButton.TabIndex = 9;
            this.cancelReplaceButton.Text = "Cancel";
            this.cancelReplaceButton.UseVisualStyleBackColor = true;
            this.cancelReplaceButton.Click += new System.EventHandler(this.cancelReplaceButton_Click);
            // 
            // caseSensitiveReplaceCheckBox
            // 
            this.caseSensitiveReplaceCheckBox.AutoSize = true;
            this.caseSensitiveReplaceCheckBox.Location = new System.Drawing.Point(12, 123);
            this.caseSensitiveReplaceCheckBox.Name = "caseSensitiveReplaceCheckBox";
            this.caseSensitiveReplaceCheckBox.Size = new System.Drawing.Size(122, 21);
            this.caseSensitiveReplaceCheckBox.TabIndex = 16;
            this.caseSensitiveReplaceCheckBox.Text = "Case-sensitive";
            this.caseSensitiveReplaceCheckBox.UseVisualStyleBackColor = true;
            this.caseSensitiveReplaceCheckBox.CheckedChanged += new System.EventHandler(this.caseSensitiveReplaceCheckBox_CheckedChanged);
            // 
            // textWrappingReplaceCheckBox
            // 
            this.textWrappingReplaceCheckBox.AccessibleName = "textWrappingReplaceCheckBox";
            this.textWrappingReplaceCheckBox.AutoSize = true;
            this.textWrappingReplaceCheckBox.Location = new System.Drawing.Point(12, 150);
            this.textWrappingReplaceCheckBox.Name = "textWrappingReplaceCheckBox";
            this.textWrappingReplaceCheckBox.Size = new System.Drawing.Size(118, 21);
            this.textWrappingReplaceCheckBox.TabIndex = 15;
            this.textWrappingReplaceCheckBox.Text = "Text wrapping";
            this.textWrappingReplaceCheckBox.UseVisualStyleBackColor = true;
            this.textWrappingReplaceCheckBox.CheckedChanged += new System.EventHandler(this.textWrappingReplaceCheckBox_CheckedChanged);
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 183);
            this.Controls.Add(this.caseSensitiveReplaceCheckBox);
            this.Controls.Add(this.textWrappingReplaceCheckBox);
            this.Controls.Add(this.cancelReplaceButton);
            this.Controls.Add(this.replaceAllButton);
            this.Controls.Add(this.toReplaceLabel);
            this.Controls.Add(this.whatReplaceLabel);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.whatTextBox);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.searchNextReplaceButton);
            this.MaximumSize = new System.Drawing.Size(495, 230);
            this.MinimumSize = new System.Drawing.Size(495, 230);
            this.Name = "Replace";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Replace_Closing);
            this.Load += new System.EventHandler(this.Replace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchNextReplaceButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Label whatReplaceLabel;
        private System.Windows.Forms.Label toReplaceLabel;
        public System.Windows.Forms.TextBox whatTextBox;
        public System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button replaceAllButton;
        private System.Windows.Forms.Button cancelReplaceButton;
        private System.Windows.Forms.CheckBox caseSensitiveReplaceCheckBox;
        private System.Windows.Forms.CheckBox textWrappingReplaceCheckBox;
    }
}