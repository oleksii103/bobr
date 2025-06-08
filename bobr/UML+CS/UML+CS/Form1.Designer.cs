namespace UML_CS
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
            fontDialog1 = new FontDialog();
            trackBar3 = new TrackBar();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar4 = new TrackBar();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            SuspendLayout();
            // 
            // trackBar3
            // 
            trackBar3.LargeChange = 0;
            trackBar3.Location = new Point(189, 131);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(547, 56);
            trackBar3.TabIndex = 3;
            trackBar3.Scroll += trackBar3_Scroll;
            trackBar3.ValueChanged += trackBar4_ValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(54, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Alpha";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(54, 90);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(57, 24);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Red";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(54, 140);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(70, 24);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Green";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Location = new Point(54, 202);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(60, 24);
            checkBox4.TabIndex = 11;
            checkBox4.Text = "Blue";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 0;
            trackBar1.Location = new Point(189, 16);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(547, 56);
            trackBar1.TabIndex = 12;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.ValueChanged += trackBar4_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 0;
            trackBar2.Location = new Point(189, 78);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(547, 56);
            trackBar2.TabIndex = 13;
            trackBar2.Scroll += trackBar2_Scroll;
            trackBar2.ValueChanged += trackBar4_ValueChanged;
            // 
            // trackBar4
            // 
            trackBar4.LargeChange = 0;
            trackBar4.Location = new Point(189, 202);
            trackBar4.Maximum = 255;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(547, 56);
            trackBar4.TabIndex = 14;
            trackBar4.ValueChanged += trackBar4_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(43, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(43, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 27);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(140, 202);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(43, 27);
            textBox4.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(46, 232);
            button1.Name = "button1";
            button1.Size = new Size(78, 32);
            button1.TabIndex = 19;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(742, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(46, 114);
            panel3.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(140, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 21);
            panel1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(trackBar4);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(trackBar3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontDialog fontDialog1;
        private TrackBar trackBar3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Panel panel3;
        private Panel panel1;
    }
}
