using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_17
{
    public partial class ProductEditorForm : Form
    {
        private List<Product> products;
        public ProductEditorForm(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }

        private void ProductEditorForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            lstProducts.Items.Clear();
            foreach (var p in products)
                lstProducts.Items.Add(p.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                Product p = new Product(txtName.Text, txtSpecs.Text, txtDesc.Text, price);
                products.Add(p);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Некоректна ціна");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstProducts.SelectedIndex;
            if (index >= 0 && decimal.TryParse(txtPrice.Text, out decimal price))
            {
                var p = products[index];
                p.Name = txtName.Text;
                p.Specs = txtSpecs.Text;
                p.Description = txtDesc.Text;
                p.Price = price;
                RefreshList();
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstProducts.SelectedIndex;
            if (index >= 0)
            {
                var p = products[index];
                txtName.Text = p.Name;
                txtSpecs.Text = p.Specs;
                txtDesc.Text = p.Description;
                txtPrice.Text = p.Price.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
