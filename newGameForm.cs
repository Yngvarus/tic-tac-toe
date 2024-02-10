namespace tic_tac_toe
{
    public partial class newGameForm : Form
    {
        public newGameForm()
        {
            InitializeComponent();
        }

        private void newGameForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#644536");
            exitBtn.BackColor = ColorTranslator.FromHtml("#C4A381");
            xBtn.BackColor = ColorTranslator.FromHtml("#B2675E");
            oBtn.BackColor = ColorTranslator.FromHtml("#BBD686");
            SetFontColor(this, ColorTranslator.FromHtml("#EEF1BD"));
            gamesNumericUpDown.BackColor = ColorTranslator.FromHtml("#C2B083");
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Sei sicuro di voler uscire dal gioco?", "Conferma Uscita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) { Application.Exit(); }
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            gamingForm gamingForm = new gamingForm('X', (int)gamesNumericUpDown.Value);
            gamingForm.Show();
            gamingForm.FormClosed += (s, args) => this.Show(); 
            //gamingForm.ShowDialog();
        }

        private void oBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            gamingForm gamingForm = new gamingForm('O', (int)gamesNumericUpDown.Value);
            gamingForm.Show();
            gamingForm.FormClosed += (s, args) => this.Show(); 
            //gamingForm.ShowDialog();
        }
    }
}