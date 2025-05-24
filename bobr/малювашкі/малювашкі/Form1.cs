namespace малювашкі
{
    public partial class Form1 : Form
    {
        List<Point> Bobrs = new List<Point>();
        Image bobr_portret;
        int width = 60;
        int height = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bobr_portret = Image.FromFile("C:\\Users\\Lenovo\\Downloads\\black-47369_1280.png");
            bobr_portret = (Image)(new Bitmap(bobr_portret, width, height));
        }

        private void draw_bobr(Graphics s, Point x)
        {
            s.DrawImage(bobr_portret, x);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics a = e.Graphics;

            Pen pen = new Pen(Brushes.DarkBlue, 3);
            Point[] b = new Point[3] { new Point(30, 30), new Point(90, 30), new Point(60, 81) };
            a.DrawPolygon(pen, b);
            Point[] c = new Point[3] { new Point(30, 63), new Point(60, 11), new Point(90, 63) };
            a.DrawPolygon(pen, c);

            for (int i = 0; i < Bobrs.Count; i++) 
            { 
                draw_bobr(a, Bobrs[i]);            
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Bobrs.Add(new Point(e.X - (width/2), e.Y - (height/2)));
            Invalidate();

        }
    }
}
