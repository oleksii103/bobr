namespace HW_18
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";
        public Form1()
        {
            InitializeComponent();
            UpdateTitle();
        }
        private void UpdateTitle()
        {
            Text = string.IsNullOrEmpty(currentFilePath) ? "Новий документ" : currentFilePath;
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            currentFilePath = "";
            UpdateTitle();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = open.FileName;
                richTextBox1.Text = File.ReadAllText(currentFilePath);
                UpdateTitle();
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentFilePath))
                menuSaveAs_Click(sender, e);
            else
                File.WriteAllText(currentFilePath, richTextBox1.Text);
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = save.FileName;
                File.WriteAllText(currentFilePath, richTextBox1.Text);
                UpdateTitle();
            }
        }

        private void menuCopy_Click(object sender, EventArgs e) => richTextBox1.Copy();
        private void menuCut_Click(object sender, EventArgs e) => richTextBox1.Cut();
        private void menuPaste_Click(object sender, EventArgs e) => richTextBox1.Paste();
        private void menuUndo_Click(object sender, EventArgs e) => richTextBox1.Undo();
        private void menuSelectAll_Click(object sender, EventArgs e) => richTextBox1.SelectAll();

        private void menuBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                richTextBox1.BackColor = cd.Color;
        }

        private void menuForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = cd.Color;
        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fd.Font;
        }

        private void btnNew_Click(object sender, EventArgs e) => menuNew_Click(sender, e);
        private void btnOpen_Click(object sender, EventArgs e) => menuOpen_Click(sender, e);
        private void btnSave_Click(object sender, EventArgs e) => menuSave_Click(sender, e);
        private void btnCopy_Click(object sender, EventArgs e) => menuCopy_Click(sender, e);
        private void btnCut_Click(object sender, EventArgs e) => menuCut_Click(sender, e);
        private void btnPaste_Click(object sender, EventArgs e) => menuPaste_Click(sender, e);
        private void btnUndo_Click(object sender, EventArgs e) => menuUndo_Click(sender, e);
        private void btnSettings_Click(object sender, EventArgs e) => menuFont_Click(sender, e);

        // Контекстне меню
        private void contextCopy_Click(object sender, EventArgs e) => richTextBox1.Copy();
        private void contextCut_Click(object sender, EventArgs e) => richTextBox1.Cut();
        private void contextPaste_Click(object sender, EventArgs e) => richTextBox1.Paste();
        private void contextUndo_Click(object sender, EventArgs e) => richTextBox1.Undo();
    }
}

