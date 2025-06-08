using UML_Forms;

namespace UML_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private ColorData CurrentColorData = new ColorData();
        private ColorList CurrentColorList = new ColorList();
        public const int HeighRow = 30;
        public const int WidthLabel = 55;
        public const int WidthPanel = 100;
        public const int gap = 5;

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = trackBar4.Value.ToString();
            textBox3.Text = trackBar3.Value.ToString();
            textBox2.Text = trackBar2.Value.ToString();
            textBox1.Text = trackBar1.Value.ToString();

            CurrentColorData.SetterForAll(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            CurrentColorData.ConvertColor();
            panel3.BackColor = CurrentColorData.GetColor();

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                trackBar1.Value = 255;
                trackBar1.Enabled = false;
            }
            else
            {
                trackBar1.Enabled = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                trackBar2.Value = 0;
                trackBar2.Enabled = false;
            }
            else
            {
                trackBar2.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                trackBar3.Value = 0;
                trackBar3.Enabled = false;
            }
            else
            {
                trackBar3.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                trackBar4.Value = 0;
                trackBar4.Enabled = false;
            }
            else
            {
                trackBar4.Enabled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentColorList.GetterList().Any(CurrentElem => CurrentElem.GetHex() == CurrentColorData.GetHex()))
            {
                MessageBox.Show("in list");
            }
            else
            {
                CurrentColorList.AddColor(CurrentColorData);
                panel3.Controls.Add(new Label() { Width = WidthLabel, Text = CurrentColorData.GetHex(), Location = new Point(gap, gap + CurrentColorList.GetterList().Count + HeighRow) });
                panel1.Controls.Add(new Panel() { Width = WidthPanel, BackColor = CurrentColorData.GetColor(), Location = new Point(2 + gap + WidthLabel, gap + CurrentColorList.GetterList().Count + HeighRow) });
                panel1.Controls.Add(new Button() { Text = "Delete", Width = WidthPanel, Location = new Point(3 * gap + WidthLabel + WidthPanel, gap + CurrentColorList.GetterList().Count * HeighRow), Tag = CurrentColorList.GetterList().Count });
            }
        }
        private void buttonDel_Click(object sender)
        {
            CurrentColorList.DeleteColor(Button delButton )
        }
    }
}
