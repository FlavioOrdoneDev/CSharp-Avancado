namespace Go_Fish_Dictionary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listHand = new System.Windows.Forms.ListBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your Hand";
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.Location = new System.Drawing.Point(350, 45);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(183, 407);
            this.listHand.TabIndex = 4;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(41, 45);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(116, 26);
            this.textName.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(177, 45);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(146, 32);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start the Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(41, 101);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(282, 251);
            this.textProgress.TabIndex = 7;
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(44, 382);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.Size = new System.Drawing.Size(279, 108);
            this.textBooks.TabIndex = 8;
            // 
            // buttonAsk
            // 
            this.buttonAsk.Location = new System.Drawing.Point(350, 458);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(183, 32);
            this.buttonAsk.TabIndex = 9;
            this.buttonAsk.Text = "Ask for a card";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 510);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.Button buttonAsk;
    }
}

