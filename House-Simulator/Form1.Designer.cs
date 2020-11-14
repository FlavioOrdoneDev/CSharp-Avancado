namespace House_Simulator
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
            this.txtDesciption = new System.Windows.Forms.TextBox();
            this.btnGoHere = new System.Windows.Forms.Button();
            this.btnGoThroughTheDoor = new System.Windows.Forms.Button();
            this.comboBoxExits = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(31, 22);
            this.txtDesciption.Multiline = true;
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(492, 274);
            this.txtDesciption.TabIndex = 0;
            // 
            // btnGoHere
            // 
            this.btnGoHere.Location = new System.Drawing.Point(31, 329);
            this.btnGoHere.Name = "btnGoHere";
            this.btnGoHere.Size = new System.Drawing.Size(127, 46);
            this.btnGoHere.TabIndex = 1;
            this.btnGoHere.Text = "Go here";
            this.btnGoHere.UseVisualStyleBackColor = true;
            this.btnGoHere.Click += new System.EventHandler(this.btnGoHere_Click);
            // 
            // btnGoThroughTheDoor
            // 
            this.btnGoThroughTheDoor.Location = new System.Drawing.Point(31, 392);
            this.btnGoThroughTheDoor.Name = "btnGoThroughTheDoor";
            this.btnGoThroughTheDoor.Size = new System.Drawing.Size(492, 46);
            this.btnGoThroughTheDoor.TabIndex = 2;
            this.btnGoThroughTheDoor.Text = "Go through the door";
            this.btnGoThroughTheDoor.UseVisualStyleBackColor = true;
            this.btnGoThroughTheDoor.Click += new System.EventHandler(this.btnGoThroughTheDoor_Click);
            // 
            // comboBoxExits
            // 
            this.comboBoxExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExits.FormattingEnabled = true;
            this.comboBoxExits.Location = new System.Drawing.Point(180, 341);
            this.comboBoxExits.Name = "comboBoxExits";
            this.comboBoxExits.Size = new System.Drawing.Size(343, 24);
            this.comboBoxExits.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.comboBoxExits);
            this.Controls.Add(this.btnGoThroughTheDoor);
            this.Controls.Add(this.btnGoHere);
            this.Controls.Add(this.txtDesciption);
            this.Name = "Form1";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesciption;
        private System.Windows.Forms.Button btnGoHere;
        private System.Windows.Forms.Button btnGoThroughTheDoor;
        private System.Windows.Forms.ComboBox comboBoxExits;
    }
}

