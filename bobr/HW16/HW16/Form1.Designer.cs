namespace HW16
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
            btnLoadFile = new Button();
            progressBar1 = new ProgressBar();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(214, 148);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(357, 149);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "Load file";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            btnLoadFile.StyleChanged += btnLoadFile_StyleChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(48, 333);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(708, 87);
            progressBar1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(171, 34);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(454, 87);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(progressBar1);
            Controls.Add(btnLoadFile);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadFile;
        private ProgressBar progressBar1;
        private RichTextBox richTextBox1;
    }
}
