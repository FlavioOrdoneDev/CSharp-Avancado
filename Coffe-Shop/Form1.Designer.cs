namespace Coffe_Shop
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
            this.txtNameLumber = new System.Windows.Forms.TextBox();
            this.btnAddLumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericLumber = new System.Windows.Forms.NumericUpDown();
            this.listBoxCoffe = new System.Windows.Forms.ListBox();
            this.radioCrispy = new System.Windows.Forms.RadioButton();
            this.radioSoggy = new System.Windows.Forms.RadioButton();
            this.radioBrowned = new System.Windows.Forms.RadioButton();
            this.radioBanana = new System.Windows.Forms.RadioButton();
            this.btnNextLumber = new System.Windows.Forms.Button();
            this.btnAddFlapJacks = new System.Windows.Forms.Button();
            this.txtFlapJacks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericLumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Lenhador";
            // 
            // txtNameLumber
            // 
            this.txtNameLumber.Location = new System.Drawing.Point(113, 24);
            this.txtNameLumber.Name = "txtNameLumber";
            this.txtNameLumber.Size = new System.Drawing.Size(207, 20);
            this.txtNameLumber.TabIndex = 1;
            // 
            // btnAddLumber
            // 
            this.btnAddLumber.Location = new System.Drawing.Point(113, 50);
            this.btnAddLumber.Name = "btnAddLumber";
            this.btnAddLumber.Size = new System.Drawing.Size(207, 23);
            this.btnAddLumber.TabIndex = 2;
            this.btnAddLumber.Text = "Adicionar Lenhador";
            this.btnAddLumber.UseVisualStyleBackColor = true;
            this.btnAddLumber.Click += new System.EventHandler(this.btnAddLumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Linha de café da manhã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alimente um Lenhador";
            // 
            // numericLumber
            // 
            this.numericLumber.Location = new System.Drawing.Point(272, 91);
            this.numericLumber.Name = "numericLumber";
            this.numericLumber.Size = new System.Drawing.Size(48, 20);
            this.numericLumber.TabIndex = 5;
            this.numericLumber.ValueChanged += new System.EventHandler(this.numericLumber_ValueChanged);
            // 
            // listBoxCoffe
            // 
            this.listBoxCoffe.FormattingEnabled = true;
            this.listBoxCoffe.Location = new System.Drawing.Point(12, 124);
            this.listBoxCoffe.Name = "listBoxCoffe";
            this.listBoxCoffe.Size = new System.Drawing.Size(119, 290);
            this.listBoxCoffe.TabIndex = 6;
            // 
            // radioCrispy
            // 
            this.radioCrispy.AutoSize = true;
            this.radioCrispy.Location = new System.Drawing.Point(148, 124);
            this.radioCrispy.Name = "radioCrispy";
            this.radioCrispy.Size = new System.Drawing.Size(73, 17);
            this.radioCrispy.TabIndex = 7;
            this.radioCrispy.Text = "Crocantes";
            this.radioCrispy.UseVisualStyleBackColor = true;
            // 
            // radioSoggy
            // 
            this.radioSoggy.AutoSize = true;
            this.radioSoggy.Location = new System.Drawing.Point(148, 158);
            this.radioSoggy.Name = "radioSoggy";
            this.radioSoggy.Size = new System.Drawing.Size(83, 17);
            this.radioSoggy.TabIndex = 8;
            this.radioSoggy.Text = "Encharcada";
            this.radioSoggy.UseVisualStyleBackColor = true;
            // 
            // radioBrowned
            // 
            this.radioBrowned.AutoSize = true;
            this.radioBrowned.Checked = true;
            this.radioBrowned.Location = new System.Drawing.Point(148, 192);
            this.radioBrowned.Name = "radioBrowned";
            this.radioBrowned.Size = new System.Drawing.Size(66, 17);
            this.radioBrowned.TabIndex = 9;
            this.radioBrowned.TabStop = true;
            this.radioBrowned.Text = "Dourada";
            this.radioBrowned.UseVisualStyleBackColor = true;
            // 
            // radioBanana
            // 
            this.radioBanana.AutoSize = true;
            this.radioBanana.Location = new System.Drawing.Point(148, 225);
            this.radioBanana.Name = "radioBanana";
            this.radioBanana.Size = new System.Drawing.Size(62, 17);
            this.radioBanana.TabIndex = 10;
            this.radioBanana.Text = "Banana";
            this.radioBanana.UseVisualStyleBackColor = true;
            // 
            // btnNextLumber
            // 
            this.btnNextLumber.Location = new System.Drawing.Point(148, 391);
            this.btnNextLumber.Name = "btnNextLumber";
            this.btnNextLumber.Size = new System.Drawing.Size(172, 23);
            this.btnNextLumber.TabIndex = 11;
            this.btnNextLumber.Text = "Próximo Lenhador";
            this.btnNextLumber.UseVisualStyleBackColor = true;
            this.btnNextLumber.Click += new System.EventHandler(this.btnNextLumber_Click);
            // 
            // btnAddFlapJacks
            // 
            this.btnAddFlapJacks.Location = new System.Drawing.Point(148, 249);
            this.btnAddFlapJacks.Name = "btnAddFlapJacks";
            this.btnAddFlapJacks.Size = new System.Drawing.Size(172, 23);
            this.btnAddFlapJacks.TabIndex = 12;
            this.btnAddFlapJacks.Text = "Adicionar Panquecas";
            this.btnAddFlapJacks.UseVisualStyleBackColor = true;
            this.btnAddFlapJacks.Click += new System.EventHandler(this.btnAddFlapJacks_Click);
            // 
            // txtFlapJacks
            // 
            this.txtFlapJacks.Location = new System.Drawing.Point(148, 278);
            this.txtFlapJacks.Multiline = true;
            this.txtFlapJacks.Name = "txtFlapJacks";
            this.txtFlapJacks.Size = new System.Drawing.Size(172, 107);
            this.txtFlapJacks.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 426);
            this.Controls.Add(this.txtFlapJacks);
            this.Controls.Add(this.btnAddFlapJacks);
            this.Controls.Add(this.btnNextLumber);
            this.Controls.Add(this.radioBanana);
            this.Controls.Add(this.radioBrowned);
            this.Controls.Add(this.radioSoggy);
            this.Controls.Add(this.radioCrispy);
            this.Controls.Add(this.listBoxCoffe);
            this.Controls.Add(this.numericLumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddLumber);
            this.Controls.Add(this.txtNameLumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cafeteria";
            ((System.ComponentModel.ISupportInitialize)(this.numericLumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameLumber;
        private System.Windows.Forms.Button btnAddLumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericLumber;
        private System.Windows.Forms.ListBox listBoxCoffe;
        private System.Windows.Forms.RadioButton radioCrispy;
        private System.Windows.Forms.RadioButton radioSoggy;
        private System.Windows.Forms.RadioButton radioBrowned;
        private System.Windows.Forms.RadioButton radioBanana;
        private System.Windows.Forms.Button btnNextLumber;
        private System.Windows.Forms.Button btnAddFlapJacks;
        private System.Windows.Forms.TextBox txtFlapJacks;
    }
}

