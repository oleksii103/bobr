using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace HW_15
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            cmbTask.Items.AddRange(new string[]
            {
                "1. Вгадай число",
                "2. Втікає статик",
                "3. День тижня за датою",
                "4. Час до дати"
            });

            cmbTask.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTask.SelectedIndexChanged += CmbTask_SelectedIndexChanged;

            btnStatic.MouseEnter += BtnStatic_MouseEnter;
            btnCheckDay.Click += BtnCheckDay_Click;
            btnCalculateTime.Click += BtnCalculateTime_Click;

            HideAllTaskControls();
        }

        private void CmbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllTaskControls();

            switch (cmbTask.SelectedIndex)
            {
                case 0:
                    StartGame(); 
                    break;
                case 1:
                    btnStatic.Visible = true;
                    break;
                case 2:
                    txtDate.Visible = true;
                    btnCheckDay.Visible = true;
                    txtResult.Visible = true;
                    break;
                case 3:
                    datePicker.Visible = true;
                    btnCalculateTime.Visible = true;
                    rbYears.Visible = true;
                    rbMonths.Visible = true;
                    rbDays.Visible = true;
                    rbMinutes.Visible = true;
                    rbSeconds.Visible = true;
                    txtResult.Visible = true;
                    break;
            }
        }

        private void HideAllTaskControls()
        {
            btnStatic.Visible = false;

            txtDate.Visible = false;
            btnCheckDay.Visible = false;

            datePicker.Visible = false;
            btnCalculateTime.Visible = false;

            rbYears.Visible = false;
            rbMonths.Visible = false;
            rbDays.Visible = false;
            rbMinutes.Visible = false;
            rbSeconds.Visible = false;

            txtResult.Visible = false;
        }

        private void StartGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                int attempts = 0;
                bool guessed = false;

                while (!guessed)
                {
                    attempts++;
                    int guess = rand.Next(1, 11);

                    var result = MessageBox.Show(
                        $"Чи це число {guess}?",
                        "Вгадай число",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        guessed = true;
                        MessageBox.Show(
                            $"Вгадано за {attempts} спроб!",
                            "Результат",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                var playResult = MessageBox.Show(
                    "Грати ще раз?",
                    "Гра",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                playAgain = (playResult == DialogResult.Yes);
            }
        }

        private void BtnStatic_MouseEnter(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - btnStatic.Width;
            int maxY = this.ClientSize.Height - btnStatic.Height;
            btnStatic.Location = new Point(rand.Next(maxX), rand.Next(maxY));
        }

        private void BtnCheckDay_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtDate.Text, out DateTime dt))
            {
                string day = CultureInfo.GetCultureInfo("uk-UA").DateTimeFormat.GetDayName(dt.DayOfWeek);
                txtResult.Text = $"Це був {day}.";
            }
            else
            {
                txtResult.Text = "Невірна дата. Введіть у форматі рррр-мм-дд";
            }
        }

        private void BtnCalculateTime_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime future = datePicker.Value;

            if (future <= now)
            {
                txtResult.Text = "Дата вже минула.";
                return;
            }

            TimeSpan diff = future - now;

            if (rbYears.Checked)
                txtResult.Text = $"Залишилось приблизно {diff.TotalDays / 365:F2} років";
            else if (rbMonths.Checked)
                txtResult.Text = $"Залишилось приблизно {diff.TotalDays / 30:F2} місяців";
            else if (rbDays.Checked)
                txtResult.Text = $"Залишилось {diff.Days} днів";
            else if (rbMinutes.Checked)
                txtResult.Text = $"Залишилось {(int)diff.TotalMinutes} хвилин";
            else if (rbSeconds.Checked)
                txtResult.Text = $"Залишилось {(int)diff.TotalSeconds} секунд";
            else
                txtResult.Text = "Оберіть одиниці вимірювання!";
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {

        }
    }
}
