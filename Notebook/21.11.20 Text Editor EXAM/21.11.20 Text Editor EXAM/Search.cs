using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._11._20_Text_Editor_EXAM
{
    public partial class Search : Form
    {
        private static int _searchIndex = 0;
        private static int _end;
        private static int _start;
        public bool SearchNext { get; set; } = true;
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
        private void Search_Closing(object sender, FormClosingEventArgs e)
        {
            _searchIndex = 0;
            _end = 0;
            _start = 0;
        }

        private void cancelReplaceButton_Click(object sender, EventArgs e)
        {
            _searchIndex = 0;
            _end = 0;
            _start = 0;
            Close();
        }

        private void searchNextButton_Click(object sender, EventArgs e)
        {
            try
            {
                string find = textBoxSearch.Text;
                int firstWord;
                int lastWord;
                if (caseSensitiveCheckBox.Checked)
                {
                    firstWord = ((Form1)this.Owner).mainTextBox.Text.IndexOf(find);
                    lastWord = ((Form1)this.Owner).mainTextBox.Text.LastIndexOf(find);
                }
                else
                {
                    firstWord = ((Form1)this.Owner).mainTextBox.Text.IndexOf(find, StringComparison.OrdinalIgnoreCase);
                    lastWord = ((Form1)this.Owner).mainTextBox.Text.LastIndexOf(find, StringComparison.OrdinalIgnoreCase);
                }

                if (radioButtonUpSearch.Checked == false)
                {
                    if (((Form1)this.Owner).mainTextBox.Text.Contains(find))
                    {
                        if (_end != -1)
                        {
                            if (caseSensitiveCheckBox.Checked)
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
                        if (textWrappingCheckBox.Checked)
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
                else
                {
                    if (((Form1)this.Owner).mainTextBox.Text.Contains(find))
                    {
                        if (_start != -1)
                        {
                            if (caseSensitiveCheckBox.Checked)
                            {
                                _searchIndex = ((Form1)this.Owner).mainTextBox.Text.LastIndexOf(find, (_searchIndex - find.Length - 1)) + find.Length;
                            }
                            else
                            {
                                _searchIndex = ((Form1)this.Owner).mainTextBox.Text.LastIndexOf(find, (_searchIndex - find.Length - 1), StringComparison.OrdinalIgnoreCase) + find.Length;
                            }
                            if ((_searchIndex - find.Length) != -1)
                            {
                                _start = _searchIndex - find.Length;
                                _end = _searchIndex;
                                ((Form1)this.Owner).mainTextBox.SelectionStart = _searchIndex - find.Length;
                                ((Form1)this.Owner).mainTextBox.SelectionLength = find.Length;
                            }
                        }
                        if (textWrappingCheckBox.Checked)
                        {
                            if (_start == firstWord)
                            {
                                _searchIndex = ((Form1)this.Owner).mainTextBox.Text.Length + find.Length;
                            }
                        }
                        else
                        {
                            if (_start == -1)
                            {
                                MessageBox.Show("Nothing found");
                            }
                            if (_start == firstWord)
                            {
                                _start = -1;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nothing found");
                    }
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDownSearch_CheckedChanged(object sender, EventArgs e)
        {
            SearchNext = false;
        }

        private void radioButtonUpSearch_CheckedChanged(object sender, EventArgs e)
        {
            SearchNext = true;
        }

        private void caseSensitiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textWrappingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (textWrappingCheckBox.Checked)
                {
                    if (_start == ((Form1)this.Owner).mainTextBox.Text.LastIndexOf(textBoxSearch.Text))
                    {
                        _searchIndex = 0;
                    }
                    _end = 0;
                    _start = 0;
                }
                else
                {
                    if (_start == ((Form1)this.Owner).mainTextBox.Text.IndexOf(textBoxSearch.Text))
                    {
                        _searchIndex = ((Form1)this.Owner).mainTextBox.Text.Length + textBoxSearch.Text.Length;
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
    }
}
