namespace Card_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.deckNumber1 = new System.Windows.Forms.Label();
            this.deckNumber2 = new System.Windows.Forms.Label();
            this.resetDeck1 = new System.Windows.Forms.Button();
            this.shuffleDeck1 = new System.Windows.Forms.Button();
            this.resetDeck2 = new System.Windows.Forms.Button();
            this.shuffleDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.txtDeck1 = new System.Windows.Forms.ListBox();
            this.txtDeck2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // deckNumber1
            // 
            this.deckNumber1.AutoSize = true;
            this.deckNumber1.Location = new System.Drawing.Point(55, 22);
            this.deckNumber1.Name = "deckNumber1";
            this.deckNumber1.Size = new System.Drawing.Size(106, 13);
            this.deckNumber1.TabIndex = 2;
            this.deckNumber1.Text = "Baralho #1 (6 cartas)";
            // 
            // deckNumber2
            // 
            this.deckNumber2.AutoSize = true;
            this.deckNumber2.Location = new System.Drawing.Point(344, 21);
            this.deckNumber2.Name = "deckNumber2";
            this.deckNumber2.Size = new System.Drawing.Size(112, 13);
            this.deckNumber2.TabIndex = 3;
            this.deckNumber2.Text = "Baralho #2 (52 cartas)";
            // 
            // resetDeck1
            // 
            this.resetDeck1.Location = new System.Drawing.Point(12, 350);
            this.resetDeck1.Name = "resetDeck1";
            this.resetDeck1.Size = new System.Drawing.Size(179, 32);
            this.resetDeck1.TabIndex = 4;
            this.resetDeck1.Text = "Resetar Baralho #1";
            this.resetDeck1.UseVisualStyleBackColor = true;
            this.resetDeck1.Click += new System.EventHandler(this.resetDeck1_Click);
            // 
            // shuffleDeck1
            // 
            this.shuffleDeck1.Location = new System.Drawing.Point(12, 390);
            this.shuffleDeck1.Name = "shuffleDeck1";
            this.shuffleDeck1.Size = new System.Drawing.Size(179, 32);
            this.shuffleDeck1.TabIndex = 5;
            this.shuffleDeck1.Text = "Embaralhar Baralho #1";
            this.shuffleDeck1.UseVisualStyleBackColor = true;
            this.shuffleDeck1.Click += new System.EventHandler(this.shuffleDeck1_Click);
            // 
            // resetDeck2
            // 
            this.resetDeck2.Location = new System.Drawing.Point(282, 350);
            this.resetDeck2.Name = "resetDeck2";
            this.resetDeck2.Size = new System.Drawing.Size(179, 32);
            this.resetDeck2.TabIndex = 6;
            this.resetDeck2.Text = "Resetar Baralho #2";
            this.resetDeck2.UseVisualStyleBackColor = true;
            this.resetDeck2.Click += new System.EventHandler(this.resetDeck2_Click);
            // 
            // shuffleDeck2
            // 
            this.shuffleDeck2.Location = new System.Drawing.Point(282, 390);
            this.shuffleDeck2.Name = "shuffleDeck2";
            this.shuffleDeck2.Size = new System.Drawing.Size(179, 32);
            this.shuffleDeck2.TabIndex = 7;
            this.shuffleDeck2.Text = "Embaralhar Baralho #2";
            this.shuffleDeck2.UseVisualStyleBackColor = true;
            this.shuffleDeck2.Click += new System.EventHandler(this.shuffleDeck2_Click);
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(210, 94);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(55, 23);
            this.moveToDeck2.TabIndex = 8;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(210, 141);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(55, 23);
            this.moveToDeck1.TabIndex = 9;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // txtDeck1
            // 
            this.txtDeck1.FormattingEnabled = true;
            this.txtDeck1.Location = new System.Drawing.Point(12, 41);
            this.txtDeck1.Name = "txtDeck1";
            this.txtDeck1.Size = new System.Drawing.Size(179, 303);
            this.txtDeck1.TabIndex = 10;
            // 
            // txtDeck2
            // 
            this.txtDeck2.FormattingEnabled = true;
            this.txtDeck2.Location = new System.Drawing.Point(282, 41);
            this.txtDeck2.Name = "txtDeck2";
            this.txtDeck2.Size = new System.Drawing.Size(179, 303);
            this.txtDeck2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 438);
            this.Controls.Add(this.txtDeck2);
            this.Controls.Add(this.txtDeck1);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.shuffleDeck2);
            this.Controls.Add(this.resetDeck2);
            this.Controls.Add(this.shuffleDeck1);
            this.Controls.Add(this.resetDeck1);
            this.Controls.Add(this.deckNumber2);
            this.Controls.Add(this.deckNumber1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Cartas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label deckNumber1;
        private System.Windows.Forms.Label deckNumber2;
        private System.Windows.Forms.Button resetDeck1;
        private System.Windows.Forms.Button shuffleDeck1;
        private System.Windows.Forms.Button resetDeck2;
        private System.Windows.Forms.Button shuffleDeck2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.ListBox txtDeck1;
        private System.Windows.Forms.ListBox txtDeck2;
    }
}

