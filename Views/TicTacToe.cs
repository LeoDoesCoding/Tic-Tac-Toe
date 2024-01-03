using TicTacToe.Model;
using System.Diagnostics;
using System.Resources;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static TicTacToe.TicTacToe;

namespace TicTacToe {
    public partial class TicTacToe : Form {
        //Run by Program.cs
        TTTboard board;
        PictureBox[,] grid;
        bool drawLine = false;

        public TicTacToe() {
            InitializeComponent();
            board = new TTTboard();
            grid = new PictureBox[,] { { space1, space2, space3 }, { space4, space5, space6 }, { space7, space8, space9 } };
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void TicTacToe_Load(object sender, EventArgs e) {

        }

        private void gridLayout_Paint(object sender, PaintEventArgs e) {

        }

        //If endgame, draw line across winning moves
        private void Space_Paint(object sender, PaintEventArgs e) {
            if (drawLine) {
                switch (board.GetWinningMove()) {
                    case 0:
                        using (Pen pen = new Pen(Color.Lime, 6.0f)) {
                            e.Graphics.DrawLine(pen, 0, 60, 120, 60);
                        }
                        break;
                    case 1:
                        using (Pen pen = new Pen(Color.Lime, 6.0f)) {
                            e.Graphics.DrawLine(pen, 60, 0, 60, 120);
                        }
                        break;
                    case 2:
                        using (Pen pen = new Pen(Color.Lime, 6.0f)) {
                            e.Graphics.DrawLine(pen, 0, 0, 120, 120);
                        }
                        break;
                    case 3:
                        using (Pen pen = new Pen(Color.Lime, 6.0f)) {
                            e.Graphics.DrawLine(pen, 120, 0, 0, 120);
                        }
                        break;
                }
            }
        }

        //When a space is clicked, set move there then check if it is a winning move
        private void Space_Click(object sender, EventArgs e) {
            PictureBox space = (PictureBox)sender;
            space.Enabled = false;
            board.PlayTurn(space.Location.Y / space.Height, space.Location.X / space.Width);
            space.BackgroundImage = Properties.Resources.ResourceManager.GetObject(board.GetTurn()) as Image;

            //Check if move is a winning move
            if (board.CheckTurn(space.Location.Y / space.Height, space.Location.X / space.Width)) {
                //Disable all buttons
                foreach (PictureBox i in grid) {
                    i.Enabled = false;
                }
                commentary.Text = board.GetTurn() + " is the winner!";

                //Invalidate the winning squares so that a line can be painted through them.
                drawLine = true;
                switch (board.GetWinningMove()) {
                    case 0: //Row (draw line horizontally)
                        for (int i = 0; i < 3; i++) {
                            grid[space.Location.Y / space.Width, i].Invalidate();
                        }
                        break;
                    case 1: //Column (draws line vertically)
                        for (int i = 0; i < 3; i++) {
                            grid[i, space.Location.X / space.Width].Invalidate();
                        }
                        break;
                    case 2: //Diagonal
                        for (int i = 0; i < 3; i++) {
                            grid[i, i].Invalidate();
                        }
                        break;
                    case 3: //Other diagonal
                        for (int i = 0; i < 3; i++) {
                            grid[i, 2-i].Invalidate();
                        }
                        break;
                }
            } else {
                commentary.Text = $"It is {board.GetTurn()}'s go.";
            }
        }
    }
}