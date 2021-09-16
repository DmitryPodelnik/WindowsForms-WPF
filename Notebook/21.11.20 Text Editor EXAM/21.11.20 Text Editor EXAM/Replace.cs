using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

namespace _21._11._20_Text_Editor_EXAM
{
    public partial class Replace : Form
    {
        private static int _searchIndex = 0;
        private static int _end;
        private static int _start;
        private static int _count = 0;
        public Replace()
        {
            InitializeComponent();
        }

        private void cancelReplaceButton_Click(object sender, EventArgs e)
        {
            _end = 0;
            _start = 0;
            _count = 0;
            _searchIndex = 0;
            Close();
        }

        private void Replace_Load(object sender, EventArgs e)
        {

        }

        private void Replace_Closing(object sender, FormClosingEventArgs e)
        {
            _end = 0;
            _start = 0;
            _count = 0;
            _searchIndex = 0;
        }

        private void replaceAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                ((Form1)this.Owner).mainTextBox.Text = ((Form1)this.Owner).mainTextBox.Text.Replace(whatTextBox.Text, toTextBox.Text);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error");
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

        private void searchNextButton_Click(object sender, EventArgs e)
        {
            try
            {
                string find = whatTextBox.Text;
                int firstWord;
                int lastWord;
                if (caseSensitiveReplaceCheckBox.Checked)
                {
                    firstWord = ((Form1)this.Owner).mainTextBox.Text.IndexOf(find);
                    lastWord = ((Form1)this.Owner).mainTextBox.Text.LastIndexOf(find);
                }
                else
                {
                    firstWord = ((Form1)this.Owner).mainTextBox.Text.IndexOf(find, StringComparison.OrdinalIgnoreCase);
                    lastWord = ((Form1)this.Owner).mainTextBox.Text.LastIndexOf(find, StringComparison.OrdinalIgnoreCase);
                }

                if (((Form1)this.Owner).mainTextBox.Text.Contains(find))
                {
                    if (_end != -1)
                    {
                        if (caseSensitiveReplaceCheckBox.Checked)
                        {
                            _searchIndex = ((Form1)this.Owner).mainTextBox.Text.IndexOf(find, _searchIndex) + find.Length;
                        }
                        else
                        {
                            _searchIndex = ((Form1)this.Owner).mainTextBox.Text.IndexOf(find, _searchIndex, StringComparison.OrdinalIgnoreCase) + find.Length;
                        }
                        if ((_searchIndex - find.Length) != -1)
                        {
                            _start = _searchIndex - find.Length;
                            _end = _searchIndex;
                            ((Form1)this.Owner).mainTextBox.SelectionStart = _searchIndex - find.Length;
                            ((Form1)this.Owner).mainTextBox.SelectionLength = find.Length;
                        }
                    }
                    if (textWrappingReplaceCheckBox.Checked)
                    {
                        if (_start == lastWord)
                        {
                            _searchIndex = 0;
                        }
                    }
                    else
                    {
                        if (_end == -1)
                        {
                            MessageBox.Show("Nothing found");
                        }
                        if (_start == lastWord)
                        {
                            _end = -1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nothing found");
                }
            }
            catch (ArgumentNullException ex)
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

        private void textWrappingReplaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (textWrappingReplaceCheckBox.Checked)
                {
                    if (_start == ((Form1)this.Owner).mainTextBox.Text.LastIndexOf(whatTextBox.Text))
                    {
                        _searchIndex = 0;
                    }
                    _end = 0;
                    _start = 0;
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error");
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

        private void replaceReplaceButton_Click(object sender, EventArgs e)
        {
            if (_count == 0)
            {
                searchNextButton_Click(null, null);
                _count++;
            }
            else
            {
                ((Form1)this.Owner).mainTextBox.SelectedText = ((Form1)this.Owner).mainTextBox.SelectedText.Replace(whatTextBox.Text, toTextBox.Text);
                _count = 0;
            }
        }

        private void caseSensitiveReplaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
