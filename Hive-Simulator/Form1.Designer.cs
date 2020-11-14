namespace Hive_Simulator
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
            this.workeerBeeJob = new System.Windows.Forms.ComboBox();
            this.report = new System.Windows.Forms.TextBox();
            this.numShifts = new System.Windows.Forms.NumericUpDown();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.btnNextShift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atribuições de Abelha Operárias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trabalho de Abelha Operária";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turnos";
            // 
            // workeerBeeJob
            // 
            this.workeerBeeJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workeerBeeJob.FormattingEnabled = true;
            this.workeerBeeJob.Items.AddRange(new object[] {
            "Coletar Nectar",
            "Cuidar do Ovos",
            "Manter a Colmeia",
            "Cuidar dos Filhotes",
            "Produzir Mel",
            "Patrulhar a Colmeia"});
            this.workeerBeeJob.Location = new System.Drawing.Point(91, 95);
            this.workeerBeeJob.Name = "workeerBeeJob";
            this.workeerBeeJob.Size = new System.Drawing.Size(233, 23);
            this.workeerBeeJob.TabIndex = 3;
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.Location = new System.Drawing.Point(94, 175);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(478, 243);
            this.report.TabIndex = 4;
            // 
            // numShifts
            // 
            this.numShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numShifts.Location = new System.Drawing.Point(334, 96);
            this.numShifts.Name = "numShifts";
            this.numShifts.Size = new System.Drawing.Size(70, 21);
            this.numShifts.TabIndex = 5;
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignJob.Location = new System.Drawing.Point(91, 134);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(233, 35);
            this.btnAssignJob.TabIndex = 6;
            this.btnAssignJob.Text = "Atribua este trabalho a uma abelha";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            this.btnAssignJob.Click += new System.EventHandler(this.btnAssignJob_Click);
            // 
            // btnNextShift
            // 
            this.btnNextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextShift.Location = new System.Drawing.Point(456, 68);
            this.btnNextShift.Name = "btnNextShift";
            this.btnNextShift.Size = new System.Drawing.Size(116, 101);
            this.btnNextShift.TabIndex = 7;
            this.btnNextShift.Text = "Trabalhar o próximo turno";
            this.btnNextShift.UseVisualStyleBackColor = true;
            this.btnNextShift.Click += new System.EventHandler(this.btnNextShift_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 430);
            this.Controls.Add(this.btnNextShift);
            this.Controls.Add(this.btnAssignJob);
            this.Controls.Add(this.numShifts);
            this.Controls.Add(this.report);
            this.Controls.Add(this.workeerBeeJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox workeerBeeJob;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.NumericUpDown numShifts;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.Button btnNextShift;
    }
}

