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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string folderPath = txtFolder.Text;
            string pattern = txtPattern.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Папка не знайдена.");
                return;
            }

            lstFiles.Items.Clear();
            try
            {
                string[] files = Directory.GetFiles(folderPath, pattern, SearchOption.AllDirectories);
                lstFiles.Items.AddRange(files);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при пошуку: " + ex.Message);
            }
        }
    }
}

