namespace HW_17
{
    partial class SearchForm
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
            txtFolder = new TextBox();
            btnBrowse = new Button();
            txtPattern = new TextBox();
            btnSearch = new Button();
            lstFiles = new ListBox();
            SuspendLayout();
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(48, 43);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(125, 27);
            txtFolder.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(48, 77);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 29);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "chose folder";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtPattern
            // 
            txtPattern.Location = new Point(48, 112);
            txtPattern.Name = "txtPattern";
            txtPattern.Size = new Size(125, 27);
            txtPattern.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(48, 145);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.Location = new Point(48, 180);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(475, 104);
            lstFiles.TabIndex = 4;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstFiles);
            Controls.Add(btnSearch);
            Controls.Add(txtPattern);
            Controls.Add(btnBrowse);
            Controls.Add(txtFolder);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFolder;
        private Button btnBrowse;
        private TextBox txtPattern;
        private Button btnSearch;
        private ListBox lstFiles;
    }
}