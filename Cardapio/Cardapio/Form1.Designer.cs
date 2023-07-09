namespace Cardapio
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
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblPrato = new System.Windows.Forms.Label();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.lblSobremesa = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cboEntrada = new System.Windows.Forms.ComboBox();
            this.cboPrato = new System.Windows.Forms.ComboBox();
            this.cboSobremesa = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(114, 63);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(82, 24);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblPrato
            // 
            this.lblPrato.AutoSize = true;
            this.lblPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrato.Location = new System.Drawing.Point(488, 63);
            this.lblPrato.Name = "lblPrato";
            this.lblPrato.Size = new System.Drawing.Size(145, 24);
            this.lblPrato.TabIndex = 1;
            this.lblPrato.Text = "Prato Principal";
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(114, 266);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(72, 24);
            this.lblOpcao.TabIndex = 3;
            this.lblOpcao.Text = "Opção";
            // 
            // lblSobremesa
            // 
            this.lblSobremesa.AutoSize = true;
            this.lblSobremesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobremesa.Location = new System.Drawing.Point(964, 63);
            this.lblSobremesa.Name = "lblSobremesa";
            this.lblSobremesa.Size = new System.Drawing.Size(116, 24);
            this.lblSobremesa.TabIndex = 2;
            this.lblSobremesa.Text = "Sobremesa";
            this.lblSobremesa.Click += new System.EventHandler(this.LblSobremesa_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(114, 293);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 24);
            this.lblResultado.TabIndex = 4;
            // 
            // cboEntrada
            // 
            this.cboEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEntrada.FormattingEnabled = true;
            this.cboEntrada.Items.AddRange(new object[] {
            "Vol-au-vent de camarão",
            "Alcatra ao molho roti",
            "Caprese no palito",
            "Canapés de salame",
            "Patê de azeitona com torradinhas",
            "Espetinho de carambola"});
            this.cboEntrada.Location = new System.Drawing.Point(118, 90);
            this.cboEntrada.Name = "cboEntrada";
            this.cboEntrada.Size = new System.Drawing.Size(331, 32);
            this.cboEntrada.TabIndex = 5;
            this.cboEntrada.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // cboPrato
            // 
            this.cboPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrato.FormattingEnabled = true;
            this.cboPrato.Items.AddRange(new object[] {
            "Espaguete ao frutos do mar",
            "Camarão na champagne com arroz de maçã",
            "Paella",
            "Stroganov de frutos do mar",
            "Lula grelhada com arroz negro",
            "Lagosta ao thermidor",
            "Filé mignon ao molho de ervas",
            "Picanha grelhada com batata recheada"});
            this.cboPrato.Location = new System.Drawing.Point(492, 90);
            this.cboPrato.Name = "cboPrato";
            this.cboPrato.Size = new System.Drawing.Size(436, 32);
            this.cboPrato.TabIndex = 6;
            // 
            // cboSobremesa
            // 
            this.cboSobremesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSobremesa.FormattingEnabled = true;
            this.cboSobremesa.Items.AddRange(new object[] {
            "Quindim",
            "Brigadeiro",
            "Rapadura",
            "Pavê",
            "Pudim de leite condensado",
            "Paçoca de amendoim",
            "Bolo de rolo",
            "Goiabada",
            "Romeu e Julieta",
            "Pé de moleque"});
            this.cboSobremesa.Location = new System.Drawing.Point(968, 90);
            this.cboSobremesa.Name = "cboSobremesa";
            this.cboSobremesa.Size = new System.Drawing.Size(324, 32);
            this.cboSobremesa.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(391, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "MOSTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(796, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(955, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 46);
            this.button3.TabIndex = 10;
            this.button3.Text = "SAIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboSobremesa);
            this.Controls.Add(this.cboPrato);
            this.Controls.Add(this.cboEntrada);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOpcao);
            this.Controls.Add(this.lblSobremesa);
            this.Controls.Add(this.lblPrato);
            this.Controls.Add(this.lblEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblPrato;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.Label lblSobremesa;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cboEntrada;
        private System.Windows.Forms.ComboBox cboPrato;
        private System.Windows.Forms.ComboBox cboSobremesa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

