namespace Kathleen_Party_Heranca
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
            this.Party = new System.Windows.Forms.TabControl();
            this.tabDinner = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostDinner = new System.Windows.Forms.TextBox();
            this.healthyDinner = new System.Windows.Forms.CheckBox();
            this.fancyDinner = new System.Windows.Forms.CheckBox();
            this.numericDinner = new System.Windows.Forms.NumericUpDown();
            this.tabAnniversary = new System.Windows.Forms.TabPage();
            this.txtCostAnniversary = new System.Windows.Forms.TextBox();
            this.txtCakeWriting = new System.Windows.Forms.TextBox();
            this.numericAnniversary = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.fancyAnniversary = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Party.SuspendLayout();
            this.tabDinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDinner)).BeginInit();
            this.tabAnniversary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnniversary)).BeginInit();
            this.SuspendLayout();
            // 
            // Party
            // 
            this.Party.Controls.Add(this.tabDinner);
            this.Party.Controls.Add(this.tabAnniversary);
            this.Party.Location = new System.Drawing.Point(80, 67);
            this.Party.Name = "Party";
            this.Party.SelectedIndex = 0;
            this.Party.Size = new System.Drawing.Size(362, 266);
            this.Party.TabIndex = 0;
            // 
            // tabDinner
            // 
            this.tabDinner.Controls.Add(this.label5);
            this.tabDinner.Controls.Add(this.label1);
            this.tabDinner.Controls.Add(this.txtCostDinner);
            this.tabDinner.Controls.Add(this.healthyDinner);
            this.tabDinner.Controls.Add(this.fancyDinner);
            this.tabDinner.Controls.Add(this.numericDinner);
            this.tabDinner.Location = new System.Drawing.Point(4, 22);
            this.tabDinner.Name = "tabDinner";
            this.tabDinner.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinner.Size = new System.Drawing.Size(354, 240);
            this.tabDinner.TabIndex = 0;
            this.tabDinner.Text = "Dinner";
            this.tabDinner.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cost";
            // 
            // txtCostDinner
            // 
            this.txtCostDinner.Location = new System.Drawing.Point(151, 168);
            this.txtCostDinner.Name = "txtCostDinner";
            this.txtCostDinner.Size = new System.Drawing.Size(100, 20);
            this.txtCostDinner.TabIndex = 3;
            // 
            // healthyDinner
            // 
            this.healthyDinner.AutoSize = true;
            this.healthyDinner.Location = new System.Drawing.Point(120, 126);
            this.healthyDinner.Name = "healthyDinner";
            this.healthyDinner.Size = new System.Drawing.Size(96, 17);
            this.healthyDinner.TabIndex = 2;
            this.healthyDinner.Text = "Healthy Option";
            this.healthyDinner.UseVisualStyleBackColor = true;
            this.healthyDinner.CheckedChanged += new System.EventHandler(this.healthyDinner_CheckedChanged_1);
            // 
            // fancyDinner
            // 
            this.fancyDinner.AutoSize = true;
            this.fancyDinner.Checked = true;
            this.fancyDinner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDinner.Location = new System.Drawing.Point(120, 93);
            this.fancyDinner.Name = "fancyDinner";
            this.fancyDinner.Size = new System.Drawing.Size(115, 17);
            this.fancyDinner.TabIndex = 1;
            this.fancyDinner.Text = "Fancy Decorations";
            this.fancyDinner.UseVisualStyleBackColor = true;
            this.fancyDinner.CheckedChanged += new System.EventHandler(this.fancyDinner_CheckedChanged_1);
            // 
            // numericDinner
            // 
            this.numericDinner.Location = new System.Drawing.Point(120, 52);
            this.numericDinner.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericDinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDinner.Name = "numericDinner";
            this.numericDinner.Size = new System.Drawing.Size(120, 20);
            this.numericDinner.TabIndex = 0;
            this.numericDinner.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDinner.ValueChanged += new System.EventHandler(this.numericDinner_ValueChanged_1);
            // 
            // tabAnniversary
            // 
            this.tabAnniversary.Controls.Add(this.txtCostAnniversary);
            this.tabAnniversary.Controls.Add(this.txtCakeWriting);
            this.tabAnniversary.Controls.Add(this.numericAnniversary);
            this.tabAnniversary.Controls.Add(this.label4);
            this.tabAnniversary.Controls.Add(this.fancyAnniversary);
            this.tabAnniversary.Controls.Add(this.label3);
            this.tabAnniversary.Controls.Add(this.label2);
            this.tabAnniversary.Location = new System.Drawing.Point(4, 22);
            this.tabAnniversary.Name = "tabAnniversary";
            this.tabAnniversary.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnniversary.Size = new System.Drawing.Size(354, 240);
            this.tabAnniversary.TabIndex = 1;
            this.tabAnniversary.Text = "Anniversary";
            this.tabAnniversary.UseVisualStyleBackColor = true;
            // 
            // txtCostAnniversary
            // 
            this.txtCostAnniversary.Location = new System.Drawing.Point(151, 196);
            this.txtCostAnniversary.Name = "txtCostAnniversary";
            this.txtCostAnniversary.Size = new System.Drawing.Size(128, 20);
            this.txtCostAnniversary.TabIndex = 6;
            // 
            // txtCakeWriting
            // 
            this.txtCakeWriting.Location = new System.Drawing.Point(120, 157);
            this.txtCakeWriting.Name = "txtCakeWriting";
            this.txtCakeWriting.Size = new System.Drawing.Size(200, 20);
            this.txtCakeWriting.TabIndex = 5;
            this.txtCakeWriting.TextChanged += new System.EventHandler(this.txtCakeWriting_TextChanged);
            // 
            // numericAnniversary
            // 
            this.numericAnniversary.Location = new System.Drawing.Point(120, 52);
            this.numericAnniversary.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericAnniversary.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAnniversary.Name = "numericAnniversary";
            this.numericAnniversary.Size = new System.Drawing.Size(120, 20);
            this.numericAnniversary.TabIndex = 4;
            this.numericAnniversary.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAnniversary.ValueChanged += new System.EventHandler(this.numericAnniversary_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cake Writing";
            // 
            // fancyAnniversary
            // 
            this.fancyAnniversary.AutoSize = true;
            this.fancyAnniversary.Checked = true;
            this.fancyAnniversary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyAnniversary.Location = new System.Drawing.Point(120, 94);
            this.fancyAnniversary.Name = "fancyAnniversary";
            this.fancyAnniversary.Size = new System.Drawing.Size(115, 17);
            this.fancyAnniversary.TabIndex = 2;
            this.fancyAnniversary.Text = "Fancy Decorations";
            this.fancyAnniversary.UseVisualStyleBackColor = true;
            this.fancyAnniversary.CheckedChanged += new System.EventHandler(this.fancyAnniversary_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.Party);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Party.ResumeLayout(false);
            this.tabDinner.ResumeLayout(false);
            this.tabDinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDinner)).EndInit();
            this.tabAnniversary.ResumeLayout(false);
            this.tabAnniversary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnniversary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Party;
        private System.Windows.Forms.TabPage tabDinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostDinner;
        private System.Windows.Forms.CheckBox healthyDinner;
        private System.Windows.Forms.CheckBox fancyDinner;
        private System.Windows.Forms.NumericUpDown numericDinner;
        private System.Windows.Forms.TabPage tabAnniversary;
        private System.Windows.Forms.TextBox txtCostAnniversary;
        private System.Windows.Forms.TextBox txtCakeWriting;
        private System.Windows.Forms.NumericUpDown numericAnniversary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fancyAnniversary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

