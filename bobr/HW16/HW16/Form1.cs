using System.Windows.Forms;

namespace HW16
{
    public partial class Form1 : Form
    {
        private string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            filePath = Path.Combine(Application.StartupPath, "sample.txt");

            if (!File.Exists(filePath))
            {
                string[] sampleLines =
                {
                    "Це перший рядок.",
                    "Ось другий рядок тексту.",
                    "Ще один рядок.",
                    "WinForms — це просто!",
                    "Можна додати скільки завгодно рядків.",
                    "Цей текст зчитується з файлу.",
                    "Кінець файлу."
                };

                await File.WriteAllLinesAsync(filePath, sampleLines);
            }
        }

        private async void btnLoadFile_Click(object sender, EventArgs e)
        {
            await ReadFileWithProgressAsync(filePath);
        }

        private async Task ReadFileWithProgressAsync(string path)
        {
            try
            {
                string[] lines = await File.ReadAllLinesAsync(path);
                int totalLines = lines.Length;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = totalLines;
                progressBar1.Value = 0;

                richTextBox1.Clear();

                for (int i = 0; i < totalLines; i++)
                {
                    richTextBox1.AppendText(lines[i] + Environment.NewLine);

                    progressBar1.Value = i + 1;

                    await Task.Delay(50);
                }

                MessageBox.Show("Зчитування завершено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnLoadFile_StyleChanged(object sender, EventArgs e)
        {

        }
    }
}
