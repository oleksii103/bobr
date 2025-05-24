namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool IsMusicPlaing { get; set; }
        List<string> musicList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            IsMusicPlaing = false;
            musicList = Directory.GetFiles("\"D:\\It Step Academy\\c#\\bobr\\WinFormsApp1\\WinFormsApp1\\").ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsMusicPlaing == false)
            {
                IsMusicPlaing = true;
                button1.Image = Properties.Resources.pause;
            }
            else
            {
                IsMusicPlaing = false;
                button1.Image = Properties.Resources.play_buttton;
            }
        }
    }
}
