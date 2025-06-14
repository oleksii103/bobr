namespace HW_15
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
            cmbTask = new ComboBox();
            btnStatic = new Button();
            txtDate = new TextBox();
            btnCheckDay = new Button();
            datePicker = new DateTimePicker();
            btnCalculateTime = new Button();
            rbYears = new RadioButton();
            rbMonths = new RadioButton();
            rbDays = new RadioButton();
            rbMinutes = new RadioButton();
            rbSeconds = new RadioButton();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // cmbTask
            // 
            cmbTask.FormattingEnabled = true;
            cmbTask.Location = new Point(0, 0);
            cmbTask.Name = "cmbTask";
            cmbTask.Size = new Size(151, 28);
            cmbTask.TabIndex = 0;
            // 
            // btnStatic
            // 
            btnStatic.Location = new Point(0, 34);
            btnStatic.Name = "btnStatic";
            btnStatic.Size = new Size(94, 29);
            btnStatic.TabIndex = 1;
            btnStatic.Text = "catch me!!!";
            btnStatic.UseVisualStyleBackColor = true;
            btnStatic.Click += btnStatic_Click;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(265, 107);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 2;
            // 
            // btnCheckDay
            // 
            btnCheckDay.Location = new Point(265, 163);
            btnCheckDay.Name = "btnCheckDay";
            btnCheckDay.Size = new Size(94, 29);
            btnCheckDay.TabIndex = 3;
            btnCheckDay.Text = "check day";
            btnCheckDay.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(265, 198);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(250, 27);
            datePicker.TabIndex = 4;
            // 
            // btnCalculateTime
            // 
            btnCalculateTime.Location = new Point(421, 163);
            btnCalculateTime.Name = "btnCalculateTime";
            btnCalculateTime.Size = new Size(94, 29);
            btnCalculateTime.TabIndex = 5;
            btnCalculateTime.Text = "calculate";
            btnCalculateTime.UseVisualStyleBackColor = true;
            // 
            // rbYears
            // 
            rbYears.AutoSize = true;
            rbYears.Location = new Point(265, 234);
            rbYears.Name = "rbYears";
            rbYears.Size = new Size(64, 24);
            rbYears.TabIndex = 6;
            rbYears.TabStop = true;
            rbYears.Text = "years";
            rbYears.UseVisualStyleBackColor = true;
            // 
            // rbMonths
            // 
            rbMonths.AutoSize = true;
            rbMonths.Location = new Point(265, 264);
            rbMonths.Name = "rbMonths";
            rbMonths.Size = new Size(79, 24);
            rbMonths.TabIndex = 7;
            rbMonths.TabStop = true;
            rbMonths.Text = "months";
            rbMonths.UseVisualStyleBackColor = true;
            // 
            // rbDays
            // 
            rbDays.AutoSize = true;
            rbDays.Location = new Point(265, 294);
            rbDays.Name = "rbDays";
            rbDays.Size = new Size(60, 24);
            rbDays.TabIndex = 8;
            rbDays.TabStop = true;
            rbDays.Text = "days";
            rbDays.UseVisualStyleBackColor = true;
            // 
            // rbMinutes
            // 
            rbMinutes.AutoSize = true;
            rbMinutes.Location = new Point(398, 234);
            rbMinutes.Name = "rbMinutes";
            rbMinutes.Size = new Size(82, 24);
            rbMinutes.TabIndex = 9;
            rbMinutes.TabStop = true;
            rbMinutes.Text = "minutes";
            rbMinutes.UseVisualStyleBackColor = true;
            // 
            // rbSeconds
            // 
            rbSeconds.AutoSize = true;
            rbSeconds.Location = new Point(398, 264);
            rbSeconds.Name = "rbSeconds";
            rbSeconds.Size = new Size(83, 24);
            rbSeconds.TabIndex = 10;
            rbSeconds.TabStop = true;
            rbSeconds.Text = "seconds";
            rbSeconds.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(265, 324);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(376, 27);
            txtResult.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(rbSeconds);
            Controls.Add(rbMinutes);
            Controls.Add(rbDays);
            Controls.Add(rbMonths);
            Controls.Add(rbYears);
            Controls.Add(btnCalculateTime);
            Controls.Add(datePicker);
            Controls.Add(btnCheckDay);
            Controls.Add(txtDate);
            Controls.Add(btnStatic);
            Controls.Add(cmbTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTask;
        private Button btnStatic;
        private TextBox txtDate;
        private Button btnCheckDay;
        private DateTimePicker datePicker;
        private Button btnCalculateTime;
        private RadioButton rbYears;
        private RadioButton rbMonths;
        private RadioButton rbDays;
        private RadioButton rbMinutes;
        private RadioButton rbSeconds;
        private TextBox txtResult;
    }
}
