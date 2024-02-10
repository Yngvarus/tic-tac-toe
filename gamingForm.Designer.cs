namespace tic_tac_toe
{
    partial class gamingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            turnPanel = new Panel();
            labelTurn = new Label();
            infoPanel = new Panel();
            labelGameTurn = new Label();
            labelScoreO = new Label();
            labelScoreX = new Label();
            surrenderBtn = new Button();
            nextGameBtn = new Button();
            gridPanel = new TableLayoutPanel();
            exitBtn = new Button();
            turnPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // turnPanel
            // 
            turnPanel.Controls.Add(labelTurn);
            turnPanel.Location = new Point(27, 12);
            turnPanel.Name = "turnPanel";
            turnPanel.Size = new Size(275, 25);
            turnPanel.TabIndex = 1;
            // 
            // labelTurn
            // 
            labelTurn.AutoSize = true;
            labelTurn.Location = new Point(114, 4);
            labelTurn.Name = "labelTurn";
            labelTurn.Size = new Size(0, 15);
            labelTurn.TabIndex = 0;
            // 
            // infoPanel
            // 
            infoPanel.Controls.Add(labelGameTurn);
            infoPanel.Controls.Add(labelScoreO);
            infoPanel.Controls.Add(labelScoreX);
            infoPanel.Location = new Point(27, 324);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(275, 100);
            infoPanel.TabIndex = 2;
            // 
            // labelGameTurn
            // 
            labelGameTurn.AutoSize = true;
            labelGameTurn.Location = new Point(82, 51);
            labelGameTurn.Name = "labelGameTurn";
            labelGameTurn.Size = new Size(0, 15);
            labelGameTurn.TabIndex = 2;
            // 
            // labelScoreO
            // 
            labelScoreO.AutoSize = true;
            labelScoreO.Location = new Point(26, 21);
            labelScoreO.Name = "labelScoreO";
            labelScoreO.Size = new Size(0, 15);
            labelScoreO.TabIndex = 1;
            // 
            // labelScoreX
            // 
            labelScoreX.AutoSize = true;
            labelScoreX.Location = new Point(155, 21);
            labelScoreX.Name = "labelScoreX";
            labelScoreX.Size = new Size(0, 15);
            labelScoreX.TabIndex = 0;
            // 
            // surrenderBtn
            // 
            surrenderBtn.Location = new Point(27, 442);
            surrenderBtn.Name = "surrenderBtn";
            surrenderBtn.Size = new Size(101, 32);
            surrenderBtn.TabIndex = 3;
            surrenderBtn.Text = "Arrenditi";
            surrenderBtn.UseVisualStyleBackColor = true;
            surrenderBtn.Click += surrenderBtn_Click;
            // 
            // nextGameBtn
            // 
            nextGameBtn.Location = new Point(201, 442);
            nextGameBtn.Name = "nextGameBtn";
            nextGameBtn.Size = new Size(101, 32);
            nextGameBtn.TabIndex = 4;
            nextGameBtn.Text = "Prossima Partita";
            nextGameBtn.UseVisualStyleBackColor = true;
            nextGameBtn.Click += nextGameBtn_Click;
            // 
            // gridPanel
            // 
            gridPanel.ColumnCount = 3;
            gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            gridPanel.Location = new Point(27, 43);
            gridPanel.Name = "gridPanel";
            gridPanel.RowCount = 3;
            gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            gridPanel.Size = new Size(275, 275);
            gridPanel.TabIndex = 5;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(134, 442);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(61, 32);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Esci";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // gamingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 486);
            Controls.Add(exitBtn);
            Controls.Add(gridPanel);
            Controls.Add(nextGameBtn);
            Controls.Add(surrenderBtn);
            Controls.Add(infoPanel);
            Controls.Add(turnPanel);
            Name = "gamingForm";
            Text = "In Partita!";
            Load += Form1_Load;
            turnPanel.ResumeLayout(false);
            turnPanel.PerformLayout();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel turnPanel;
        private Panel infoPanel;
        private Button surrenderBtn;
        private Button nextGameBtn;
        private TableLayoutPanel gridPanel;
        private Label labelScoreO;
        private Label labelScoreX;
        private Label labelTurn;
        private Label labelGameTurn;
        private Button exitBtn;
    }
}