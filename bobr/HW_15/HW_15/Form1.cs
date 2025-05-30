namespace HW_15
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
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
                        $"Is the number you thought of {guess}?",
                        "Guess the Number",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        guessed = true;
                        MessageBox.Show(
                            $"Number guessed in {attempts} attempts!",
                            "Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                var playResult = MessageBox.Show(
                    "Do you want to play again?",
                    "Play Again?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                playAgain = (playResult == DialogResult.Yes);
            }

            this.Close();
        }
    }

}
