namespace _21._11._20_Text_Editor_EXAM
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.currentLineStripBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.amountLinesStripTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.amountCharsStripTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.mainPanelToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.fontSizeToolStrip = new System.Windows.Forms.ToolStripComboBox();
            this.fontToolStrip1 = new System.Windows.Forms.ToolStripComboBox();
            this.aligningToolStrip = new System.Windows.Forms.ToolStripComboBox();
            this.pasteListToolStrip = new System.Windows.Forms.ToolStripButton();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextBox.HideSelection = false;
            this.mainTextBox.Location = new System.Drawing.Point(11, 30);
            this.mainTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.mainTextBox.MinimumSize = new System.Drawing.Size(150, 100);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTextBox.Size = new System.Drawing.Size(729, 523);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.formatMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(742, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(46, 24);
            this.fileMenu.Text = "File";
            this.fileMenu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.toolStripMenuItem1.Text = "New";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(240, 26);
            this.toolStripMenuItem2.Text = "Open...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(240, 26);
            this.toolStripMenuItem3.Text = "Save";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(240, 26);
            this.toolStripMenuItem4.Text = "Save as...";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.fileSaveAs_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(240, 26);
            this.toolStripMenuItem5.Text = "Exit";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripSeparator1,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripSeparator2,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(49, 24);
            this.editMenu.Text = "Edit";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem6.Enabled = false;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem6.Text = "Cancel";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.editCancelMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem7.Enabled = false;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.toolStripMenuItem7.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem7.Text = "Undo";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.editUndoMenu_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem8.Enabled = false;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem8.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem8.Text = "Copy";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.editCopyMenu_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem9.Enabled = false;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItem9.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem9.Text = "Cut";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.editCutMenu_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItem10.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem10.Text = "Paste";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.editPasteMenu_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem11.Enabled = false;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.toolStripMenuItem11.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem11.Text = "Delete";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.editDeleteMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem12.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem12.Text = "Select All";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.editSelectAllMenu_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.toolStripMenuItem13.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem13.Text = "Search...";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.editSearchMenu_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.toolStripMenuItem14.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem14.Text = "Replace...";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.editReplaceMenu_Click);
            // 
            // formatMenu
            // 
            this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15});
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(70, 24);
            this.formatMenu.Text = "Format";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(130, 26);
            this.toolStripMenuItem15.Text = "Font...";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.fontMenu_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStrip});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(55, 24);
            this.helpMenu.Text = "Help";
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStrip.Text = "About";
            this.aboutToolStrip.Click += new System.EventHandler(this.aboutToolStrip_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentLineStripBar,
            this.amountLinesStripTool,
            this.amountCharsStripTool});
            this.statusStrip.Location = new System.Drawing.Point(0, 577);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(742, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // currentLineStripBar
            // 
            this.currentLineStripBar.Margin = new System.Windows.Forms.Padding(0, 4, 30, 2);
            this.currentLineStripBar.Name = "currentLineStripBar";
            this.currentLineStripBar.Size = new System.Drawing.Size(103, 20);
            this.currentLineStripBar.Text = "Current Line: 1";
            this.currentLineStripBar.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // amountLinesStripTool
            // 
            this.amountLinesStripTool.Margin = new System.Windows.Forms.Padding(0, 4, 30, 2);
            this.amountLinesStripTool.Name = "amountLinesStripTool";
            this.amountLinesStripTool.Size = new System.Drawing.Size(134, 20);
            this.amountLinesStripTool.Text = "Amount Of Lines: 1";
            // 
            // amountCharsStripTool
            // 
            this.amountCharsStripTool.Margin = new System.Windows.Forms.Padding(0, 4, 30, 2);
            this.amountCharsStripTool.Name = "amountCharsStripTool";
            this.amountCharsStripTool.Size = new System.Drawing.Size(137, 20);
            this.amountCharsStripTool.Text = "Amount Of Chars: 0";
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Location = new System.Drawing.Point(1, 30);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 546);
            this.leftPanel.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPanelToolStrip,
            this.fontToolStrip,
            this.pasteListToolStrip});
            this.toolStrip.Location = new System.Drawing.Point(0, 550);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(742, 27);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // mainPanelToolStrip
            // 
            this.mainPanelToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanelToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainPanelToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStrip,
            this.openToolStrip,
            this.saveToolStrip,
            this.toolStripSeparator,
            this.copyToolStrip,
            this.cutToolStrip,
            this.pasteToolStrip,
            this.deleteToolStrip});
            this.mainPanelToolStrip.Image = global::_21._11._20_Text_Editor_EXAM.Properties.Resources.mainPanel;
            this.mainPanelToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainPanelToolStrip.Name = "mainPanelToolStrip";
            this.mainPanelToolStrip.Size = new System.Drawing.Size(34, 24);
            this.mainPanelToolStrip.Text = "Main Panel";
            // 
            // newToolStrip
            // 
            this.newToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newToolStrip.Name = "newToolStrip";
            this.newToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStrip.Size = new System.Drawing.Size(190, 26);
            this.newToolStrip.Text = "New";
            this.newToolStrip.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // openToolStrip
            // 
            this.openToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.openToolStrip.Name = "openToolStrip";
            this.openToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStrip.Size = new System.Drawing.Size(190, 26);
            this.openToolStrip.Text = "Open...";
            this.openToolStrip.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStrip.Size = new System.Drawing.Size(190, 26);
            this.saveToolStrip.Text = "Save";
            this.saveToolStrip.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(187, 6);
            // 
            // copyToolStrip
            // 
            this.copyToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.copyToolStrip.Enabled = false;
            this.copyToolStrip.Name = "copyToolStrip";
            this.copyToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStrip.Size = new System.Drawing.Size(190, 26);
            this.copyToolStrip.Text = "Copy";
            this.copyToolStrip.Click += new System.EventHandler(this.editCopyMenu_Click);
            // 
            // cutToolStrip
            // 
            this.cutToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cutToolStrip.Name = "cutToolStrip";
            this.cutToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStrip.Size = new System.Drawing.Size(190, 26);
            this.cutToolStrip.Text = "Cut";
            this.cutToolStrip.Click += new System.EventHandler(this.editCutMenu_Click);
            // 
            // pasteToolStrip
            // 
            this.pasteToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pasteToolStrip.Name = "pasteToolStrip";
            this.pasteToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStrip.Size = new System.Drawing.Size(190, 26);
            this.pasteToolStrip.Text = "Paste";
            this.pasteToolStrip.Click += new System.EventHandler(this.editPasteMenu_Click);
            // 
            // deleteToolStrip
            // 
            this.deleteToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteToolStrip.Name = "deleteToolStrip";
            this.deleteToolStrip.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStrip.Size = new System.Drawing.Size(190, 26);
            this.deleteToolStrip.Text = "Delete";
            this.deleteToolStrip.Click += new System.EventHandler(this.editDeleteMenu_Click);
            // 
            // fontToolStrip
            // 
            this.fontToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStrip,
            this.fontToolStrip1,
            this.aligningToolStrip});
            this.fontToolStrip.Image = global::_21._11._20_Text_Editor_EXAM.Properties.Resources.textFormation;
            this.fontToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontToolStrip.Name = "fontToolStrip";
            this.fontToolStrip.Size = new System.Drawing.Size(34, 24);
            this.fontToolStrip.Text = "Font Edition";
            // 
            // fontSizeToolStrip
            // 
            this.fontSizeToolStrip.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.fontSizeToolStrip.Name = "fontSizeToolStrip";
            this.fontSizeToolStrip.Size = new System.Drawing.Size(121, 28);
            this.fontSizeToolStrip.Text = "Font Size";
            this.fontSizeToolStrip.TextChanged += new System.EventHandler(this.fontSizeToolStrip_TextChanged);
            // 
            // fontToolStrip1
            // 
            this.fontToolStrip1.Name = "fontToolStrip1";
            this.fontToolStrip1.Size = new System.Drawing.Size(121, 28);
            this.fontToolStrip1.Text = "Font";
            this.fontToolStrip1.TextChanged += new System.EventHandler(this.fontToolStrip1_TextChanged);
            // 
            // aligningToolStrip
            // 
            this.aligningToolStrip.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.aligningToolStrip.Name = "aligningToolStrip";
            this.aligningToolStrip.Size = new System.Drawing.Size(121, 28);
            this.aligningToolStrip.Text = "Aligning";
            this.aligningToolStrip.TextChanged += new System.EventHandler(this.aligningToolStrip_TextChanged);
            // 
            // pasteListToolStrip
            // 
            this.pasteListToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteListToolStrip.Image = global::_21._11._20_Text_Editor_EXAM.Properties.Resources.list;
            this.pasteListToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteListToolStrip.Name = "pasteListToolStrip";
            this.pasteListToolStrip.Size = new System.Drawing.Size(29, 24);
            this.pasteListToolStrip.Text = "Paste List";
            this.pasteListToolStrip.Visible = false;
            this.pasteListToolStrip.Click += new System.EventHandler(this.pasteListToolStrip_Click);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.italicCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicCheckBox.Location = new System.Drawing.Point(144, 550);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(24, 29);
            this.italicCheckBox.TabIndex = 7;
            this.italicCheckBox.Text = "I";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.italicCheckBox_CheckedChanged);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boldCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldCheckBox.Location = new System.Drawing.Point(107, 550);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(31, 29);
            this.boldCheckBox.TabIndex = 8;
            this.boldCheckBox.Text = "B";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.underlineCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineCheckBox.Location = new System.Drawing.Point(173, 550);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(31, 29);
            this.underlineCheckBox.TabIndex = 9;
            this.underlineCheckBox.Text = "U";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            this.underlineCheckBox.CheckedChanged += new System.EventHandler(this.underlineCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 603);
            this.Controls.Add(this.underlineCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel currentLineStripBar;
        private System.Windows.Forms.ToolStripStatusLabel amountLinesStripTool;
        private System.Windows.Forms.ToolStripStatusLabel amountCharsStripTool;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStrip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton mainPanelToolStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStrip;
        private System.Windows.Forms.ToolStripMenuItem cutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton fontToolStrip;
        private System.Windows.Forms.ToolStripComboBox fontSizeToolStrip;
        private System.Windows.Forms.ToolStripComboBox fontToolStrip1;
        private System.Windows.Forms.ToolStripComboBox aligningToolStrip;
        private System.Windows.Forms.ToolStripButton pasteListToolStrip;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        public System.Windows.Forms.TextBox mainTextBox;
    }
}

