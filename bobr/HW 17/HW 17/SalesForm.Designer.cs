namespace HW_17
{
    partial class SalesForm
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
            cmbProducts = new ComboBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            lstCart = new ListBox();
            lblTotal = new Label();
            btnEditProducts = new Button();
            SuspendLayout();
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(36, 73);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(151, 28);
            cmbProducts.TabIndex = 0;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(36, 125);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 55);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "add product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstCart
            // 
            lstCart.FormattingEnabled = true;
            lstCart.Location = new Point(39, 239);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(237, 84);
            lstCart.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(39, 216);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "sum";
            // 
            // btnEditProducts
            // 
            btnEditProducts.DialogResult = DialogResult.Cancel;
            btnEditProducts.Location = new Point(39, 329);
            btnEditProducts.Name = "btnEditProducts";
            btnEditProducts.Size = new Size(94, 55);
            btnEditProducts.TabIndex = 5;
            btnEditProducts.Text = "edit product";
            btnEditProducts.UseVisualStyleBackColor = true;
            btnEditProducts.Click += btnEditProducts_Click;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditProducts);
            Controls.Add(lblTotal);
            Controls.Add(lstCart);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(cmbProducts);
            Name = "SalesForm";
            Text = "SalesForm";
            Load += SalesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProducts;
        private TextBox txtPrice;
        private Button btnAdd;
        private ListBox lstCart;
        private Label lblTotal;
        private Button btnEditProducts;
    }
}