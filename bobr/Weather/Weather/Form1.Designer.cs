namespace Weather
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            temp_ = new Label();
            comboBox1 = new ComboBox();
            wind_kph = new Label();
            pressure_mb = new Label();
            cloud = new Label();
            humidity = new Label();
            precip_mm = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(311, 343);
            button1.Name = "button1";
            button1.Size = new Size(161, 54);
            button1.TabIndex = 0;
            button1.Text = "update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(267, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 170);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // temp_
            // 
            temp_.AutoSize = true;
            temp_.Location = new Point(67, 273);
            temp_.Name = "temp_";
            temp_.Size = new Size(56, 20);
            temp_.TabIndex = 2;
            temp_.Text = "Temp -";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "C", "F" });
            comboBox1.Location = new Point(551, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // wind_kph
            // 
            wind_kph.AutoSize = true;
            wind_kph.Location = new Point(164, 273);
            wind_kph.Name = "wind_kph";
            wind_kph.Size = new Size(100, 20);
            wind_kph.TabIndex = 4;
            wind_kph.Text = "Wind Speed -";
            // 
            // pressure_mb
            // 
            pressure_mb.AutoSize = true;
            pressure_mb.Location = new Point(311, 273);
            pressure_mb.Name = "pressure_mb";
            pressure_mb.Size = new Size(77, 20);
            pressure_mb.TabIndex = 5;
            pressure_mb.Text = "Pressure - ";
            // 
            // cloud
            // 
            cloud.AutoSize = true;
            cloud.Location = new Point(434, 273);
            cloud.Name = "cloud";
            cloud.Size = new Size(68, 20);
            cloud.TabIndex = 6;
            cloud.Text = "Coluds - ";
            // 
            // humidity
            // 
            humidity.AutoSize = true;
            humidity.Location = new Point(551, 273);
            humidity.Name = "humidity";
            humidity.Size = new Size(88, 20);
            humidity.TabIndex = 7;
            humidity.Text = "Humudity - ";
            // 
            // precip_mm
            // 
            precip_mm.AutoSize = true;
            precip_mm.Location = new Point(680, 273);
            precip_mm.Name = "precip_mm";
            precip_mm.Size = new Size(59, 20);
            precip_mm.TabIndex = 8;
            precip_mm.Text = "Presip -";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(551, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 66);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 10;
            label1.Text = "City:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(precip_mm);
            Controls.Add(humidity);
            Controls.Add(cloud);
            Controls.Add(pressure_mb);
            Controls.Add(wind_kph);
            Controls.Add(comboBox1);
            Controls.Add(temp_);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label temp_;
        private ComboBox comboBox1;
        private Label wind_kph;
        private Label pressure_mb;
        private Label cloud;
        private Label humidity;
        private Label precip_mm;
        private TextBox textBox1;
        private Label label1;
    }
}
