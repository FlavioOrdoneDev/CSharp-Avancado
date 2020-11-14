namespace Events
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
            this.btnVideoEncode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVideoEncode
            // 
            this.btnVideoEncode.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVideoEncode.Location = new System.Drawing.Point(345, 185);
            this.btnVideoEncode.Name = "btnVideoEncode";
            this.btnVideoEncode.Size = new System.Drawing.Size(127, 53);
            this.btnVideoEncode.TabIndex = 0;
            this.btnVideoEncode.Text = "Video Encode";
            this.btnVideoEncode.UseVisualStyleBackColor = false;
            this.btnVideoEncode.Click += new System.EventHandler(this.btnVideoEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVideoEncode);
            this.Name = "Form1";
            this.Text = "Eventos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVideoEncode;
    }
}

