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
    public partial class SalesForm : Form
    {
        private List<Product> products = new List<Product>();
        private List<Product> cart = new List<Product>();
        public SalesForm()
        {
            InitializeComponent();
        }
        private void SalesForm_Load(object sender, EventArgs e)
        {
            // Початкові товари
            products.Add(new Product("Відеокарта", "RTX 4070", "Ігрова відеокарта", 18000));
            products.Add(new Product("Процесор", "i7-12700K", "12 ядер, 20 потоків", 12000));
            products.Add(new Product("ОЗУ", "32ГБ DDR4", "Kingston", 4000));

            cmbProducts.DataSource = new BindingSource(products, null);
            cmbProducts.DisplayMember = "Name";
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product selected)
            {
                txtPrice.Text = selected.Price.ToString("0.00") + " грн";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product selected)
            {
                cart.Add(selected);
                lstCart.Items.Add(selected.Name + " - " + selected.Description);
                UpdateTotal();
            }
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            ProductEditorForm editor = new ProductEditorForm(products);
            editor.ShowDialog();

            cmbProducts.DataSource = null;
            cmbProducts.DataSource = new BindingSource(products, null);
            cmbProducts.DisplayMember = "Name";
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (var item in cart)
                total += item.Price;
            lblTotal.Text = $"Загальна сума: {total} грн";
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Specs { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string name, string specs, string description, decimal price)
        {
            Name = name;
            Specs = specs;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Specs} - {Description}";
        }
    }

}

