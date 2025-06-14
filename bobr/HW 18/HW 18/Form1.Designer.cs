namespace HW_18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuNew = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            menuSaveAs = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            menuCopy = new ToolStripMenuItem();
            menuCut = new ToolStripMenuItem();
            menuPaste = new ToolStripMenuItem();
            menuUndo = new ToolStripMenuItem();
            menuSelectAll = new ToolStripMenuItem();
            setingsToolStripMenuItem = new ToolStripMenuItem();
            menuBackColor = new ToolStripMenuItem();
            menuForeColor = new ToolStripMenuItem();
            menuFont = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnNew = new ToolStripButton();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnCopy = new ToolStripButton();
            btnCut = new ToolStripButton();
            btnPaste = new ToolStripButton();
            btnUndo = new ToolStripButton();
            btnSettings = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextCopy = new ToolStripMenuItem();
            contextCut = new ToolStripMenuItem();
            contextPaste = new ToolStripMenuItem();
            contextUndo = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, setingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNew, menuOpen, menuSave, menuSaveAs });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "file";
            // 
            // menuNew
            // 
            menuNew.Name = "menuNew";
            menuNew.Size = new Size(224, 26);
            menuNew.Text = "new";
            menuNew.Click += menuNew_Click;
            // 
            // menuOpen
            // 
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(224, 26);
            menuOpen.Text = "open";
            menuOpen.Click += menuOpen_Click;
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(224, 26);
            menuSave.Text = "save";
            menuSave.Click += menuSave_Click;
            // 
            // menuSaveAs
            // 
            menuSaveAs.Name = "menuSaveAs";
            menuSaveAs.Size = new Size(224, 26);
            menuSaveAs.Text = "save as";
            menuSaveAs.Click += menuSaveAs_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuCopy, menuCut, menuPaste, menuUndo, menuSelectAll });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "edit";
            // 
            // menuCopy
            // 
            menuCopy.Name = "menuCopy";
            menuCopy.Size = new Size(224, 26);
            menuCopy.Text = "copy";
            menuCopy.Click += menuCopy_Click;
            // 
            // menuCut
            // 
            menuCut.Name = "menuCut";
            menuCut.Size = new Size(224, 26);
            menuCut.Text = "cut";
            menuCut.Click += menuCut_Click;
            // 
            // menuPaste
            // 
            menuPaste.Name = "menuPaste";
            menuPaste.Size = new Size(224, 26);
            menuPaste.Text = "paste";
            menuPaste.Click += menuPaste_Click;
            // 
            // menuUndo
            // 
            menuUndo.Name = "menuUndo";
            menuUndo.Size = new Size(224, 26);
            menuUndo.Text = "undo";
            menuUndo.Click += menuUndo_Click;
            // 
            // menuSelectAll
            // 
            menuSelectAll.Name = "menuSelectAll";
            menuSelectAll.Size = new Size(224, 26);
            menuSelectAll.Text = "select all";
            menuSelectAll.Click += menuSelectAll_Click;
            // 
            // setingsToolStripMenuItem
            // 
            setingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuBackColor, menuForeColor, menuFont });
            setingsToolStripMenuItem.Name = "setingsToolStripMenuItem";
            setingsToolStripMenuItem.Size = new Size(69, 24);
            setingsToolStripMenuItem.Text = "setings";
            // 
            // menuBackColor
            // 
            menuBackColor.Name = "menuBackColor";
            menuBackColor.Size = new Size(224, 26);
            menuBackColor.Text = "back color";
            menuBackColor.Click += menuBackColor_Click;
            // 
            // menuForeColor
            // 
            menuForeColor.Name = "menuForeColor";
            menuForeColor.Size = new Size(224, 26);
            menuForeColor.Text = "font color";
            menuForeColor.Click += menuForeColor_Click;
            // 
            // menuFont
            // 
            menuFont.Name = "menuFont";
            menuFont.Size = new Size(224, 26);
            menuFont.Text = "font";
            menuFont.Click += menuFont_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNew, btnOpen, btnSave, btnCopy, btnCut, btnPaste, btnUndo, btnSettings });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(29, 24);
            btnNew.Text = "toolStripButton1";
            btnNew.Click += btnNew_Click;
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(29, 24);
            btnOpen.Text = "toolStripButton2";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(29, 24);
            btnSave.Text = "toolStripButton3";
            btnSave.Click += btnSave_Click;
            // 
            // btnCopy
            // 
            btnCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopy.Image = (Image)resources.GetObject("btnCopy.Image");
            btnCopy.ImageTransparentColor = Color.Magenta;
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(29, 24);
            btnCopy.Text = "toolStripButton3";
            btnCopy.Click += btnCopy_Click;
            // 
            // btnCut
            // 
            btnCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCut.Image = (Image)resources.GetObject("btnCut.Image");
            btnCut.ImageTransparentColor = Color.Magenta;
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(29, 24);
            btnCut.Text = "toolStripButton3";
            btnCut.Click += btnCut_Click;
            // 
            // btnPaste
            // 
            btnPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPaste.Image = (Image)resources.GetObject("btnPaste.Image");
            btnPaste.ImageTransparentColor = Color.Magenta;
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(29, 24);
            btnPaste.Text = "toolStripButton3";
            btnPaste.Click += btnPaste_Click;
            // 
            // btnUndo
            // 
            btnUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.ImageTransparentColor = Color.Magenta;
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(29, 24);
            btnUndo.Text = "toolStripButton3";
            btnUndo.Click += btnUndo_Click;
            // 
            // btnSettings
            // 
            btnSettings.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageTransparentColor = Color.Magenta;
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(29, 24);
            btnSettings.Text = "toolStripButton3";
            btnSettings.Click += btnSettings_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 55);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 395);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { contextCopy, contextCut, contextPaste, contextUndo });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 128);
            // 
            // contextCopy
            // 
            contextCopy.Name = "contextCopy";
            contextCopy.Size = new Size(210, 24);
            contextCopy.Text = "copy";
            contextCopy.Click += contextCopy_Click;
            // 
            // contextCut
            // 
            contextCut.Name = "contextCut";
            contextCut.Size = new Size(210, 24);
            contextCut.Text = "cut";
            contextCut.Click += contextCut_Click;
            // 
            // contextPaste
            // 
            contextPaste.Name = "contextPaste";
            contextPaste.Size = new Size(210, 24);
            contextPaste.Text = "paste";
            contextPaste.Click += contextPaste_Click;
            // 
            // contextUndo
            // 
            contextUndo.Name = "contextUndo";
            contextUndo.Size = new Size(210, 24);
            contextUndo.Text = "undo";
            contextUndo.Click += contextUndo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuNew;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuSaveAs;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem menuCopy;
        private ToolStripMenuItem menuCut;
        private ToolStripMenuItem menuPaste;
        private ToolStripMenuItem menuUndo;
        private ToolStripMenuItem menuSelectAll;
        private ToolStripMenuItem setingsToolStripMenuItem;
        private ToolStripMenuItem menuBackColor;
        private ToolStripMenuItem menuForeColor;
        private ToolStripMenuItem menuFont;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNew;
        private ToolStripButton btnOpen;
        private ToolStripButton btnSave;
        private ToolStripButton btnCopy;
        private ToolStripButton btnCut;
        private ToolStripButton btnPaste;
        private ToolStripButton btnUndo;
        private ToolStripButton btnSettings;
        private RichTextBox richTextBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem contextCopy;
        private ToolStripMenuItem contextCut;
        private ToolStripMenuItem contextPaste;
        private ToolStripMenuItem contextUndo;
    }
}
