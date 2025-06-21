namespace Weather
{
    public partial class Form1 : Form
    {
        private ApiAcces apiHadler = new ApiAcces();
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            textBox1.Text = "Lviv";

            g();
        }

        private void PoNovoi(WeatherInfo weatherInfo)
        {
            var WeatherProp = weatherInfo.GetType().GetProperties();

            foreach (var item in WeatherProp)
            {
                //var curentLable = this.GetType().GetField(item.Name, (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | BindingFlags.Instance)).GetValue(this) as Label;

                //curentLable.Text = 

                var control = this.Controls.Find(item.Name, true).FirstOrDefault() as Label;

                if (control == null)
                {
                    continue;
                }


                control.Text = control.Text.Remove(control.Text.IndexOf('-') + 1);
                control.Text += item.GetValue(weatherInfo).ToString();
            }
        }

        private async Task g()
        {
            WeatherInfo weatherInfo = await apiHadler.GetDate(textBox1.Text);
            PoNovoi(weatherInfo);

            var h = await apiHadler.GetPicture(weatherInfo.condition.icon);
            pictureBox1.Image = Image.FromStream(h);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                temp_.Name = "temp_c";
            }
            else
            {
                temp_.Name = "temp_f";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g();
        }
    }
}
