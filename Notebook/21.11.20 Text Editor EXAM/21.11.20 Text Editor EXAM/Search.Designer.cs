namespace _21._11._20_Text_Editor_EXAM
{
    partial class Search
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
            this.searchNextButton = new System.Windows.Forms.Button();
            this.cancelReplaceButton = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.whatReplaceLabel = new System.Windows.Forms.Label();
            this.textWrappingCheckBox = new System.Windows.Forms.CheckBox();
            this.caseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.directionGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonDownSearch = new System.Windows.Forms.RadioButton();
            this.radioButtonUpSearch = new System.Windows.Forms.RadioButton();
            this.directionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchNextButton
            // 
            this.searchNextButton.Location = new System.Drawing.Point(377, 12);
            this.searchNextButton.Name = "searchNextButton";
            this.searchNextButton.Size = new System.Drawing.Size(103, 28);
            this.searchNextButton.TabIndex = 1;
            this.searchNextButton.Text = "Search next";
            this.searchNextButton.UseVisualStyleBackColor = true;
            this.searchNextButton.Click += new System.EventHandler(this.searchNextButton_Click);
            // 
            // cancelReplaceButton
            // 
            this.cancelReplaceButton.Location = new System.Drawing.Point(377, 46);
            this.cancelReplaceButton.Name = "cancelReplaceButton";
            this.cancelReplaceButton.Size = new System.Drawing.Size(103, 28);
            this.cancelReplaceButton.TabIndex = 4;
            this.cancelReplaceButton.Text = "Cancel";
            this.cancelReplaceButton.UseVisualStyleBackColor = true;
            this.cancelReplaceButton.Click += new System.EventHandler(this.cancelReplaceButton_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.HideSelection = false;
            this.textBoxSearch.Location = new System.Drawing.Point(69, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(284, 22);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // whatReplaceLabel
            // 
            this.whatReplaceLabel.AutoSize = true;
            this.whatReplaceLabel.Location = new System.Drawing.Point(12, 20);
            this.whatReplaceLabel.Name = "whatReplaceLabel";
            this.whatReplaceLabel.Size = new System.Drawing.Size(45, 17);
            this.whatReplaceLabel.TabIndex = 12;
            this.whatReplaceLabel.Text = "What:";
            // 
            // textWrappingCheckBox
            // 
            this.textWrappingCheckBox.AccessibleName = "textWrappingSearchCheckBox";
            this.textWrappingCheckBox.AutoSize = true;
            this.textWrappingCheckBox.Location = new System.Drawing.Point(12, 120);
            this.textWrappingCheckBox.Name = "textWrappingCheckBox";
            this.textWrappingCheckBox.Size = new System.Drawing.Size(118, 21);
            this.textWrappingCheckBox.TabIndex = 13;
            this.textWrappingCheckBox.Text = "Text wrapping";
            this.textWrappingCheckBox.UseVisualStyleBackColor = true;
            this.textWrappingCheckBox.CheckedChanged += new System.EventHandler(this.textWrappingCheckBox_CheckedChanged);
            // 
            // caseSensitiveCheckBox
            // 
            this.caseSensitiveCheckBox.AccessibleName = "textWrappingSearchCheckBox";
            this.caseSensitiveCheckBox.AutoSize = true;
            this.caseSensitiveCheckBox.Location = new System.Drawing.Point(12, 93);
            this.caseSensitiveCheckBox.Name = "caseSensitiveCheckBox";
            this.caseSensitiveCheckBox.Size = new System.Drawing.Size(122, 21);
            this.caseSensitiveCheckBox.TabIndex = 14;
            this.caseSensitiveCheckBox.Text = "Case-sensitive";
            this.caseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.caseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.caseSensitiveCheckBox_CheckedChanged);
            // 
            // directionGroupBox
            // 
            this.directionGroupBox.Controls.Add(this.radioButtonDownSearch);
            this.directionGroupBox.Controls.Add(this.radioButtonUpSearch);
            this.directionGroupBox.Location = new System.Drawing.Point(210, 58);
            this.directionGroupBox.Name = "directionGroupBox";
            this.directionGroupBox.Size = new System.Drawing.Size(144, 56);
            this.directionGroupBox.TabIndex = 15;
            this.directionGroupBox.TabStop = false;
            this.directionGroupBox.Text = "Direction";
            // 
            // radioButtonDownSearch
            // 
            this.radioButtonDownSearch.AutoSize = true;
            this.radioButtonDownSearch.Checked = true;
            this.radioButtonDownSearch.Location = new System.Drawing.Point(73, 21);
            this.radioButtonDownSearch.Name = "radioButtonDownSearch";
            this.radioButtonDownSearch.Size = new System.Drawing.Size(64, 21);
            this.radioButtonDownSearch.TabIndex = 1;
            this.radioButtonDownSearch.TabStop = true;
            this.radioButtonDownSearch.Text = "Down";
            this.radioButtonDownSearch.UseVisualStyleBackColor = true;
            this.radioButtonDownSearch.CheckedChanged += new System.EventHandler(this.radioButtonDownSearch_CheckedChanged);
            // 
            // radioButtonUpSearch
            // 
            this.radioButtonUpSearch.AutoSize = true;
            this.radioButtonUpSearch.Location = new System.Drawing.Point(6, 21);
            this.radioButtonUpSearch.Name = "radioButtonUpSearch";
            this.radioButtonUpSearch.Size = new System.Drawing.Size(47, 21);
            this.radioButtonUpSearch.TabIndex = 0;
            this.radioButtonUpSearch.Text = "Up";
            this.radioButtonUpSearch.UseVisualStyleBackColor = true;
            this.radioButtonUpSearch.CheckedChanged += new System.EventHandler(this.radioButtonUpSearch_CheckedChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 153);
            this.Controls.Add(this.directionGroupBox);
            this.Controls.Add(this.caseSensitiveCheckBox);
            this.Controls.Add(this.textWrappingCheckBox);
            this.Controls.Add(this.whatReplaceLabel);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.cancelReplaceButton);
            this.Controls.Add(this.searchNextButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 200);
            this.Name = "Search";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_Closing);
            this.Load += new System.EventHandler(this.Search_Load);
            this.directionGroupBox.ResumeLayout(false);
            this.directionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchNextButton;
        private System.Windows.Forms.Button cancelReplaceButton;
        private System.Windows.Forms.Label whatReplaceLabel;
        public System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.CheckBox textWrappingCheckBox;
        private System.Windows.Forms.CheckBox caseSensitiveCheckBox;
        private System.Windows.Forms.GroupBox directionGroupBox;
        private System.Windows.Forms.RadioButton radioButtonDownSearch;
        private System.Windows.Forms.RadioButton radioButtonUpSearch;
    }
}