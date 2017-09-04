namespace Hangtur
{
    partial class Main
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
            this.gameBoard = new System.Windows.Forms.PictureBox();
            this.guess = new System.Windows.Forms.Label();
            this.makeAttempt = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.letters = new System.Windows.Forms.Label();
            this.guide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBoard
            // 
            this.gameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameBoard.Image = global::Hangtur.Properties.Resources._0;
            this.gameBoard.Location = new System.Drawing.Point(12, 12);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(398, 297);
            this.gameBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameBoard.TabIndex = 0;
            this.gameBoard.TabStop = false;
            // 
            // guess
            // 
            this.guess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guess.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess.Location = new System.Drawing.Point(12, 312);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(524, 67);
            this.guess.TabIndex = 1;
            this.guess.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
    " _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
    " _ _ _ _ _ _";
            this.guess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makeAttempt
            // 
            this.makeAttempt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.makeAttempt.Enabled = false;
            this.makeAttempt.Location = new System.Drawing.Point(416, 12);
            this.makeAttempt.Name = "makeAttempt";
            this.makeAttempt.Size = new System.Drawing.Size(126, 23);
            this.makeAttempt.TabIndex = 3;
            this.makeAttempt.Text = "Make attempt";
            this.makeAttempt.UseVisualStyleBackColor = true;
            this.makeAttempt.Click += new System.EventHandler(this.MakeAttempt_Click);
            // 
            // newGame
            // 
            this.newGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newGame.Location = new System.Drawing.Point(416, 41);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(126, 23);
            this.newGame.TabIndex = 4;
            this.newGame.Text = "New game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // letters
            // 
            this.letters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.letters.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letters.Location = new System.Drawing.Point(12, 379);
            this.letters.Name = "letters";
            this.letters.Size = new System.Drawing.Size(524, 52);
            this.letters.TabIndex = 5;
            this.letters.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z Æ Ø Å";
            this.letters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guide
            // 
            this.guide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guide.Location = new System.Drawing.Point(416, 247);
            this.guide.Name = "guide";
            this.guide.Size = new System.Drawing.Size(120, 62);
            this.guide.TabIndex = 6;
            this.guide.Text = "Click \'New Game\' to begin.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 449);
            this.Controls.Add(this.guide);
            this.Controls.Add(this.letters);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.makeAttempt);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.gameBoard);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(570, 320);
            this.Name = "Main";
            this.Text = "Hangtur";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_press);
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBoard;
        private System.Windows.Forms.Label guess;
        private System.Windows.Forms.Button makeAttempt;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Label letters;
        private System.Windows.Forms.Label guide;
    }
}

