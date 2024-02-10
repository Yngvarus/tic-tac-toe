namespace tic_tac_toe
{
    partial class newGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitBtn = new Button();
            oBtn = new Button();
            xBtn = new Button();
            gamesNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)gamesNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(59, 396);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(203, 51);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "Esci";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // oBtn
            // 
            oBtn.Location = new Point(83, 230);
            oBtn.Name = "oBtn";
            oBtn.Size = new Size(153, 58);
            oBtn.TabIndex = 1;
            oBtn.Text = "Inizia Partita: O";
            oBtn.UseVisualStyleBackColor = true;
            oBtn.Click += oBtn_Click;
            // 
            // xBtn
            // 
            xBtn.Location = new Point(83, 106);
            xBtn.Name = "xBtn";
            xBtn.Size = new Size(153, 58);
            xBtn.TabIndex = 2;
            xBtn.Text = "Inizia Partita: X";
            xBtn.UseVisualStyleBackColor = true;
            xBtn.Click += xBtn_Click;
            // 
            // gamesNumericUpDown
            // 
            gamesNumericUpDown.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            gamesNumericUpDown.Location = new Point(125, 186);
            gamesNumericUpDown.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            gamesNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            gamesNumericUpDown.Name = "gamesNumericUpDown";
            gamesNumericUpDown.Size = new Size(73, 22);
            gamesNumericUpDown.TabIndex = 3;
            gamesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // newGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(334, 486);
            ControlBox = false;
            Controls.Add(gamesNumericUpDown);
            Controls.Add(xBtn);
            Controls.Add(oBtn);
            Controls.Add(exitBtn);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.PaleGoldenrod;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "newGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuova Partita";
            Load += newGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)gamesNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitBtn;
        private Button oBtn;
        private Button xBtn;
        private NumericUpDown gamesNumericUpDown;
    }
}