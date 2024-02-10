using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tic_tac_toe
{
    public partial class gamingForm : Form
    {
        private char playerSign;
        private int nGames;
        private int setPoint;
        private char[] board;
        private int scoreX = 0;
        private int scoreO = 0;
        private int gamesWonByX = 0;
        private int gamesWonByO = 0;
        private int gamesPlayed = 0;
        private bool gameWon = false;
        private int[,] winningCombinations = new int[,]
        {
                {0, 1, 2},  // Righe
                {3, 4, 5},
                {6, 7, 8},
                {0, 3, 6},  // Colonne
                {1, 4, 7},
                {2, 5, 8},
                {0, 4, 8},  // Diagonali
                {2, 4, 6}
        };

        public gamingForm(char sign, int games)
        {
            InitializeComponent();
            playerSign = sign;

            nGames = games;
            InitializeGame();
            nextGameBtn.Enabled = false;
            surrenderBtn.Enabled = true;
            if (gamesPlayed < nGames)
            {
                surrenderBtn.Enabled = true;
            }

            if (board.All(ch => ch != '\0'))
            {
                nextGameBtn.Enabled = true;
            }
        }

        private void InitializeGame()
        {

            board = new char[9];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }


            Button[] buttons = new Button[9];
            for (int i = 0; i < 9; i++)
            {
                buttons[i] = new Button();
                buttons[i].Name = "button" + (i + 1);
                buttons[i].Text = "";
                buttons[i].Click += Button_Click;
                buttons[i].Tag = i;
                buttons[i].Font = new Font("Arial", 20, FontStyle.Bold);
                buttons[i].Size = new Size(75, 75);
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].FlatAppearance.MouseOverBackColor = buttons[i].BackColor;
                buttons[i].FlatAppearance.MouseDownBackColor = buttons[i].BackColor;
                buttons[i].BackColor = ColorTranslator.FromHtml("#C4A381");


                gridPanel.Controls.Add(buttons[i]);
            }
            gamesPlayed++;
            labelScoreX.Text = $"Punteggio X: {scoreX}";
            labelScoreO.Text = $"Punteggio O: {scoreO}";
            labelGameTurn.Text = $"Partite giocate: {(gamesPlayed - 1).ToString()}";
            labelTurn.Text = $"Turno di: {playerSign}";
            gameWon = false;
            setPoint = (nGames / 2) + 1;
            //Console.WriteLine(setPoint.ToString());
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = (int)button.Tag;

            if (!gameWon && board[index] == ' ')
            {
                board[index] = playerSign;
                button.Text = playerSign.ToString();

                char winner = CalculateWinner();
                if (winner == 'X' || winner == 'O' || winner == 'D')
                {
                    gameWon = true;
                }

                if (!gameWon)
                {
                    playerSign = (playerSign == 'X') ? 'O' : 'X';
                    labelTurn.Text = $"Turno di: {playerSign}";
                }

                if (gamesPlayed >= nGames)
                {
                    nextGameBtn.Enabled = true;
                    surrenderBtn.Enabled = false;
                }
            }

            if (board[index] == 'X')
            {
                button.BackColor = ColorTranslator.FromHtml("#B2675E");
            }
            else if (board[index] == 'O')
            {
                button.BackColor = ColorTranslator.FromHtml("#BBD686");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#644536");
            SetFontColor(this, ColorTranslator.FromHtml("#EEF1BD"));
            surrenderBtn.BackColor = ColorTranslator.FromHtml("#C4A381");
            nextGameBtn.BackColor = ColorTranslator.FromHtml("#C4A381");
            exitBtn.BackColor = ColorTranslator.FromHtml("#C4A381");
        }

        private void SetFontColor(Control control, Color color)
        {
            foreach (Control c in control.Controls)
            {
                // Imposta il colore del font per il controllo
                c.ForeColor = color;

                // Ricorsivamente, imposta il colore del font per i controlli figli
                if (c.HasChildren)
                {
                    SetFontColor(c, color);
                }
            }
        }
        private void RegenerateButtons()
        {
            foreach (Control control in gridPanel.Controls)
            {
                if (control is Button button)
                {
                    button.Text = "";
                    button.BackColor = ColorTranslator.FromHtml("#C4A381");
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }


            labelScoreX.Text = $"Punteggio X: {scoreX}";
            labelScoreO.Text = $"Punteggio O: {scoreO}";
            labelTurn.Text = $"Turno di: {playerSign}";

            if (gamesPlayed < nGames && !(gamesWonByO >= setPoint) && !(gamesWonByX >= setPoint))
            {
                nextGameBtn.Enabled = true;
            }
            else if (gamesPlayed == nGames || gamesWonByO == setPoint || gamesWonByX == setPoint)
            {
                if (!(gamesWonByO == gamesWonByX))
                {
                    nextGameBtn.Enabled = false;
                    char whoWon = (gamesWonByO > gamesWonByX) ? 'O' : 'X';
                    MessageBox.Show($"Giocatore {whoWon}, hai vinto!", "Partita Conclusa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    nextGameBtn.Enabled = false;
                    MessageBox.Show($"Partita conclusa con una Patta!", "Partita Conclusa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            gamesPlayed++;
            labelGameTurn.Text = $"Partite giocate: {(gamesPlayed - 1).ToString()}";

        }

        private char CalculateWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                int a = winningCombinations[i, 0];
                int b = winningCombinations[i, 1];
                int c = winningCombinations[i, 2];

                if (board[a] != ' ' && board[a] == board[b] && board[b] == board[c])
                {
                    return board[a]; // Restituisce il vincitore
                }
            }

            // Se non ci sono vincitori e il tabellone è pieno, la partita è finita in pareggio
            if (board.All(ch => ch != ' '))
            {
                return 'D'; // Pareggio
            }

            return ' '; // La partita è in corso
        }
        private void nextGameBtn_Click(object sender, EventArgs e)
        {
            if (gameWon)
            {
                char winner = CalculateWinner();
                if (winner == 'X')
                {
                    scoreX++;
                    gamesWonByX++;
                    playerSign = 'O';
                }
                else if (winner == 'O')
                {
                    scoreO++;
                    gamesWonByO++;
                    playerSign = 'X';
                }

                if (gamesPlayed <= nGames)
                {
                    surrenderBtn.Enabled = true;
                }
                else
                {
                    surrenderBtn.Enabled = false;
                }
                gameWon = false;
            }

            RegenerateButtons();
        }

        private void surrenderBtn_Click(object sender, EventArgs e)
        {
            gameWon = true;
            char winner = (playerSign == 'X') ? 'O' : 'X';
            if (winner == 'X')
            {
                scoreX++;
                gamesWonByX++;
                playerSign = 'O';
            }
            else if (winner == 'O')
            {
                scoreO++;
                gamesWonByO++;
                playerSign = 'X';
            }
            RegenerateButtons();
            if (gamesPlayed <= nGames)
            {
                surrenderBtn.Enabled = true;
            }
            else
            {
                surrenderBtn.Enabled = false;
            }
            gameWon = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Sei sicuro di voler uscire dalla partita?", "Conferma Chiusura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) { this.Close(); }
        }
    }
}
