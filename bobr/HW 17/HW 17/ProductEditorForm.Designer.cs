namespace HW_17
{
    partial class ProductEditorForm
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
            txtName = new TextBox();
            txtSpecs = new TextBox();
            txtDesc = new TextBox();
            txtPrice = new TextBox();
            lstProducts = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(32, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // txtSpecs
            // 
            txtSpecs.Location = new Point(32, 71);
            txtSpecs.Name = "txtSpecs";
            txtSpecs.Size = new Size(125, 27);
            txtSpecs.TabIndex = 1;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(32, 117);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(125, 27);
            txtDesc.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(32, 165);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 3;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(32, 218);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(150, 104);
            lstProducts.TabIndex = 4;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(321, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(321, 115);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 32);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 7;
            label1.Text = "Назва товару";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 78);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 8;
            label2.Text = "Характеристика";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 124);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 9;
            label3.Text = "короткий опис";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 165);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 10;
            label4.Text = "ціна (тільки число)";
            // 
            // ProductEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lstProducts);
            Controls.Add(txtPrice);
            Controls.Add(txtDesc);
            Controls.Add(txtSpecs);
            Controls.Add(txtName);
            Name = "ProductEditorForm";
            Text = "ProductEditorForm";
            Load += ProductEditorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSpecs;
        private TextBox txtDesc;
        private TextBox txtPrice;
        private ListBox lstProducts;
        private Button btnAdd;
        private Button btnEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}