namespace HW_17
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
            btnSearchTask = new Button();
            btnSalesTask = new Button();
            SuspendLayout();
            // 
            // btnSearchTask
            // 
            btnSearchTask.Location = new Point(12, 12);
            btnSearchTask.Name = "btnSearchTask";
            btnSearchTask.Size = new Size(776, 29);
            btnSearchTask.TabIndex = 0;
            btnSearchTask.Text = "Завдання з пошуком файлів";
            btnSearchTask.UseVisualStyleBackColor = true;
            btnSearchTask.Click += btnSearchTask_Click;
            // 
            // btnSalesTask
            // 
            btnSalesTask.Location = new Point(12, 68);
            btnSalesTask.Name = "btnSalesTask";
            btnSalesTask.Size = new Size(776, 29);
            btnSalesTask.TabIndex = 1;
            btnSalesTask.Text = "завдання з продажами";
            btnSalesTask.UseVisualStyleBackColor = true;
            btnSalesTask.Click += btnSalesTask_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalesTask);
            Controls.Add(btnSearchTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearchTask;
        private Button btnSalesTask;
    }
}
