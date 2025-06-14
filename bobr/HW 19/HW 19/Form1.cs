namespace HW_19
{
    public partial class Form1 : Form
    {
        private const int CellSize = 60;
        private readonly List<ChessPiece> pieces = new List<ChessPiece>();
        private ChessPiece selectedPiece;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Width = CellSize * 8 + 16;
            this.Height = CellSize * 8 + 39;

            // Створення кількох фігур
            pieces.Add(new ChessPiece(0, 1, "♟")); // чорний пішак
            pieces.Add(new ChessPiece(0, 6, "♙")); // білий пішак
            pieces.Add(new ChessPiece(0, 0, "♜")); // чорна тура
            pieces.Add(new ChessPiece(7, 7, "♖")); // біла тура

            this.MouseDown += ChessForm_MouseDown;

            // Прив’язка подій контекстного меню
            contextMenuStrip1.Items[0].Click += Move_Click;
            contextMenuStrip1.Items[1].Click += Delete_Click;
        }
        private void ChessForm_MouseDown(object sender, MouseEventArgs e)
        {
            int row = e.Y / CellSize;
            int col = e.X / CellSize;

            if (e.Button == MouseButtons.Right)
            {
                selectedPiece = pieces.FirstOrDefault(p => p.Row == row && p.Col == col);
                if (selectedPiece != null)
                    contextMenuStrip1.Show(this, e.Location);
            }
        }

        private void Move_Click(object sender, EventArgs e)
        {
            if (selectedPiece != null)
            {
                Random rnd = new Random();
                selectedPiece.Row = rnd.Next(0, 8);
                selectedPiece.Col = rnd.Next(0, 8);
                Invalidate();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (selectedPiece != null)
            {
                pieces.Remove(selectedPiece);
                selectedPiece = null;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawBoard(e.Graphics);
            DrawPieces(e.Graphics);
        }

        private void DrawBoard(Graphics g)
        {
            bool isWhite = true;
            for (int row = 0; row < 8; row++)
            {
                isWhite = !isWhite;
                for (int col = 0; col < 8; col++)
                {
                    Rectangle rect = new Rectangle(col * CellSize, row * CellSize, CellSize, CellSize);
                    g.FillRectangle(isWhite ? Brushes.Beige : Brushes.Sienna, rect);
                    isWhite = !isWhite;
                }
            }
        }

        private void DrawPieces(Graphics g)
        {
            using (Font font = new Font("Segoe UI Symbol", 28))
            using (StringFormat sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                foreach (var piece in pieces)
                {
                    Rectangle rect = new Rectangle(piece.Col * CellSize, piece.Row * CellSize, CellSize, CellSize);
                    g.DrawString(piece.Symbol, font, Brushes.Black, rect, sf);
                }
            }
        }
    }

    public class ChessPiece
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Symbol { get; set; }

        public ChessPiece(int col, int row, string symbol)
        {
            Row = row;
            Col = col;
            Symbol = symbol;
        }
    }
}

