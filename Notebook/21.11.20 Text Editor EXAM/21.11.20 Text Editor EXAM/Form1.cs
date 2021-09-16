using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._11._20_Text_Editor_EXAM
{
    public partial class Form1 : Form
    {
        private static SaveFileDialog _saveFileDialog = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        static public string NameNotBook { get; set; }
        static public bool IsSaved { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                NameNotBook = "New Text Document.txt";
                this.Text = NameNotBook + "- Notebook";

                foreach (FontFamily oneFontFamily in FontFamily.Families)
                {
                    fontToolStrip1.Items.Add(oneFontFamily.Name);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveForm saveForm = new SaveForm();
                saveForm.ShowDialog();

                if (saveForm.DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (saveForm.DialogResult == DialogResult.OK)
                {
                    if (IsSaved == true)
                    {
                        File.WriteAllText(_saveFileDialog.FileName, mainTextBox.Text);
                    }
                    else
                    {
                        if (_saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(_saveFileDialog.FileName, mainTextBox.Text);
                        }
                    }
                    mainTextBox.Clear();
                    NameNotBook = "New Text Document.txt";
                    this.Text = NameNotBook + "- Notebook";
                    IsSaved = false;
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (PathTooLongException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                About aboutForm = new About();
                aboutForm.ShowDialog();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                IsSaved = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mainTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                    NameNotBook = Path.GetFileName(openFileDialog.FileName);
                    this.Text = NameNotBook + "- Notebook";
                    _saveFileDialog.FileName = openFileDialog.FileName;
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (PathTooLongException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int lineNumber = mainTextBox.GetLineFromCharIndex(mainTextBox.SelectionStart);
                currentLineStripBar.Text = "Current Line: " + (lineNumber + 1).ToString();

                if (mainTextBox.SelectionLength > 0)
                {
                    toolStripMenuItem8.Enabled = true;
                    toolStripMenuItem9.Enabled = true;
                    toolStripMenuItem11.Enabled = true;
                    copyToolStrip.Enabled = true;
                    cutToolStrip.Enabled = true;
                    deleteToolStrip.Enabled = true;
                }
                else
                {
                    toolStripMenuItem8.Enabled = false;
                    toolStripMenuItem9.Enabled = false;
                    toolStripMenuItem11.Enabled = false;
                    copyToolStrip.Enabled = false;
                    cutToolStrip.Enabled = false;
                    deleteToolStrip.Enabled = false;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (mainTextBox.CanUndo == true)
                {
                    toolStripMenuItem6.Enabled = true;
                    toolStripMenuItem7.Enabled = true;
                }
                else
                {
                    toolStripMenuItem6.Enabled = false;
                    toolStripMenuItem7.Enabled = false;
                }
                
                string tempString = "";
                tempString = "Amount Of Chars: ";
                amountCharsStripTool.Text = tempString + mainTextBox.Text.Length.ToString();
                tempString = "Amount Of Lines: ";
                amountLinesStripTool.Text = tempString + mainTextBox.Lines.Length.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fontMenu_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog fontDialog1 = new FontDialog();
                fontDialog1.ShowColor = true;

                fontDialog1.Font = mainTextBox.Font;
                fontDialog1.Color = mainTextBox.ForeColor;

                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    mainTextBox.Font = fontDialog1.Font;
                    mainTextBox.ForeColor = fontDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editCancelMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainTextBox.CanUndo == true)
                {
                    // Undo the last operation.
                    mainTextBox.Undo();
                    // Clear the undo buffer to prevent last action from being redone.
                    mainTextBox.ClearUndo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editUndoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainTextBox.CanUndo == true)
                {
                    // Undo the last operation.
                    mainTextBox.Undo();
                    // Clear the undo buffer to prevent last action from being redone.
                    mainTextBox.ClearUndo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editCopyMenu_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that text is selected in the text box.   
                if (mainTextBox.SelectionLength > 0)
                {
                    // Copy the selected text to the Clipboard.
                    mainTextBox.Copy();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editCutMenu_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that text is currently selected in the text box.   
                if (mainTextBox.SelectedText != "")
                {
                    // Cut the selected text in the control and paste it into the Clipboard.
                    mainTextBox.Cut();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editPasteMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
                {
                    // Determine if any text is selected in the text box.
                    if (mainTextBox.SelectionLength > 0)
                    {
                        // Ask user if they want to paste over currently selected text.
                        if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            // Move selection to the point after the current selection and paste.
                            mainTextBox.SelectionStart = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
                        }
                    }
                    // Paste current text in Clipboard into text box.
                    mainTextBox.Paste();
                }
            }
            catch (ExternalException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ThreadStateException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editDeleteMenu_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectedText = "";
        }

        private void editSelectAllMenu_Click(object sender, EventArgs e)
        {
            try
            {
                // Determine if any text is selected in the TextBox control.
                if (mainTextBox.SelectionLength == 0)
                {
                    // Select all text in the text box.
                    mainTextBox.SelectAll();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editSearchMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Search searchForm = new Search();
                searchForm.Owner = this;
                searchForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editReplaceMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Replace replaceForm = new Replace();
                replaceForm.Owner = this;
                replaceForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fileNew_Click(object sender, EventArgs e)
        {
            try
            {
                SaveForm saveForm = new SaveForm();
                saveForm.ShowDialog();

                if (saveForm.DialogResult == DialogResult.OK)
                {
                    if (IsSaved == true)
                    {
                        File.WriteAllText(_saveFileDialog.FileName, mainTextBox.Text);
                    }
                    else
                    {
                        if (_saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(_saveFileDialog.FileName, mainTextBox.Text);
                        }
                    }
                    mainTextBox.Clear();
                    NameNotBook = "New Text Document.txt";
                    this.Text = NameNotBook + "- Notebook";
                    IsSaved = false;
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (PathTooLongException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsSaved == true)
                {
                    //_nameNoteBook = Path.GetFileName(saveFileDialog.FileName) + ".txt";
                    this.Text = NameNotBook + "- Notebook";
                    File.WriteAllText(_saveFileDialog.FileName, mainTextBox.Text);
                }
                else
                {
                    if (_saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        NameNotBook = Path.GetFileName(_saveFileDialog.FileName);
                        this.Text = NameNotBook + "- Notebook";
                        File.WriteAllText(_saveFileDialog.FileName, mainTextBox.Text);
                    }
                }
                IsSaved = true;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (PathTooLongException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fileSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                _saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                _saveFileDialog.FilterIndex = 2;
                _saveFileDialog.RestoreDirectory = true;

                if (_saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    NameNotBook = Path.GetFileName(_saveFileDialog.FileName);
                    this.Text = NameNotBook + "- Notebook";
                    File.WriteAllText(_saveFileDialog.FileName, mainTextBox.Text);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (PathTooLongException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pasteListToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void aligningToolStrip_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (aligningToolStrip.Text == "Left")
                {
                    mainTextBox.TextAlign = HorizontalAlignment.Left;
                }
                else if (aligningToolStrip.Text == "Right")
                {
                    mainTextBox.TextAlign = HorizontalAlignment.Right;
                }
                else if (aligningToolStrip.Text == "Center")
                {
                    mainTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            catch (InvalidEnumArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fontToolStrip1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (FontFamily oneFontFamily in FontFamily.Families)
                {
                    if (fontToolStrip1.Text == oneFontFamily.Name)
                    {
                        mainTextBox.Font = new Font(oneFontFamily.Name.ToString(), mainTextBox.Font.Size);
                        break;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fontSizeToolStrip_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainTextBox.Font = new Font(mainTextBox.Font.FontFamily, Int32.Parse(fontSizeToolStrip.Text));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (boldCheckBox.Checked)
                {
                    mainTextBox.Font = new Font(mainTextBox.Font, mainTextBox.Font.Style ^ FontStyle.Bold);
                }
                else
                {
                    mainTextBox.Font = new Font(mainTextBox.Font, mainTextBox.Font.Style ^ FontStyle.Regular);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (italicCheckBox.Checked)
                {
                    mainTextBox.Font = new Font(mainTextBox.Font, mainTextBox.Font.Style ^ FontStyle.Italic);
                }
                else
                {
                    mainTextBox.Font = new Font(mainTextBox.Font, mainTextBox.Font.Style ^ FontStyle.Regular);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void underlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (underlineCheckBox.Checked)
                {
                    mainTextBox.Font = new Font(mainTextBox.Font, mainTextBox.Font.Style ^ FontStyle.Underline);
                }
                else
                {
                    mainTextBox.Font = new Font(mainTextBox.Font, mainTextBox.Font.Style ^ FontStyle.Regular);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
