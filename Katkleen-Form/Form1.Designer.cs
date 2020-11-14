namespace Katkleen_Form
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
            this.numeroPessoas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroPessoas
            // 
            this.numeroPessoas.Location = new System.Drawing.Point(176, 85);
            this.numeroPessoas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numeroPessoas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroPessoas.Name = "numeroPessoas";
            this.numeroPessoas.Size = new System.Drawing.Size(120, 20);
            this.numeroPessoas.TabIndex = 0;
            this.numeroPessoas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroPessoas.ValueChanged += new System.EventHandler(this.numeroPessoas_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Pessoas";
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(176, 136);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(71, 17);
            this.healthyBox.TabIndex = 3;
            this.healthyBox.Text = "Saudável";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(176, 171);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(115, 17);
            this.fancyBox.TabIndex = 4;
            this.fancyBox.Text = "Decoração Chique";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Custo";
            // 
            // costLabel
            // 
            this.costLabel.Location = new System.Drawing.Point(217, 215);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 20);
            this.costLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 339);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fancyBox);
            this.Controls.Add(this.healthyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeroPessoas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeroPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeroPessoas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costLabel;
    }
}

