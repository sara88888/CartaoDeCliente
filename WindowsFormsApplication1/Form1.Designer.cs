namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnLoja = new System.Windows.Forms.Button();
            this.btnEscritorio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPrimeiroNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbApelido = new System.Windows.Forms.TextBox();
            this.tbTransf = new System.Windows.Forms.TextBox();
            this.udTxPrize = new System.Windows.Forms.NumericUpDown();
            this.tbValTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbArtigo = new System.Windows.Forms.TextBox();
            this.tbIDcartao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNrCompra = new System.Windows.Forms.TextBox();
            this.tbPontos = new System.Windows.Forms.TextBox();
            this.tbQtt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCompra = new System.Windows.Forms.ComboBox();
            this.udTotalCompra = new System.Windows.Forms.NumericUpDown();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.cbRebate = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.udTxPrize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTotalCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoja
            // 
            this.btnLoja.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoja.Location = new System.Drawing.Point(81, 360);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(224, 60);
            this.btnLoja.TabIndex = 22;
            this.btnLoja.Text = "Loja";
            this.btnLoja.UseVisualStyleBackColor = false;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // btnEscritorio
            // 
            this.btnEscritorio.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEscritorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscritorio.Location = new System.Drawing.Point(429, 362);
            this.btnEscritorio.Name = "btnEscritorio";
            this.btnEscritorio.Size = new System.Drawing.Size(201, 58);
            this.btnEscritorio.TabIndex = 43;
            this.btnEscritorio.Text = "Escritório";
            this.btnEscritorio.UseVisualStyleBackColor = false;
            this.btnEscritorio.Click += new System.EventHandler(this.btnEscritorio_Click);
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor total das compras";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(334, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Taxa de bónus %";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3
            // 
            this.lbl3.Enabled = false;
            this.lbl3.Location = new System.Drawing.Point(8, 46);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(218, 30);
            this.lbl3.TabIndex = 18;
            this.lbl3.Text = "Transferência de pontos";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGravar.Location = new System.Drawing.Point(268, 567);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(243, 46);
            this.btnGravar.TabIndex = 19;
            this.btnGravar.Text = "Gravar/Sair";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Visible = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label9
            // 
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(8, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Novo titular :";
            // 
            // tbPrimeiroNome
            // 
            this.tbPrimeiroNome.Location = new System.Drawing.Point(277, 88);
            this.tbPrimeiroNome.Name = "tbPrimeiroNome";
            this.tbPrimeiroNome.Size = new System.Drawing.Size(130, 26);
            this.tbPrimeiroNome.TabIndex = 1;
            this.tbPrimeiroNome.TextChanged += new System.EventHandler(this.tbPrimeiroNome_TextChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(136, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Primeiro nome";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Apelido";
            // 
            // tbApelido
            // 
            this.tbApelido.Location = new System.Drawing.Point(490, 88);
            this.tbApelido.Name = "tbApelido";
            this.tbApelido.Size = new System.Drawing.Size(166, 26);
            this.tbApelido.TabIndex = 41;
            this.tbApelido.TextChanged += new System.EventHandler(this.tbApelido_TextChanged);
            // 
            // tbTransf
            // 
            this.tbTransf.Location = new System.Drawing.Point(232, 50);
            this.tbTransf.Name = "tbTransf";
            this.tbTransf.Size = new System.Drawing.Size(70, 26);
            this.tbTransf.TabIndex = 42;
            this.tbTransf.TextChanged += new System.EventHandler(this.tbTransf_TextChanged);
            // 
            // udTxPrize
            // 
            this.udTxPrize.DecimalPlaces = 2;
            this.udTxPrize.Location = new System.Drawing.Point(471, 48);
            this.udTxPrize.Name = "udTxPrize";
            this.udTxPrize.Size = new System.Drawing.Size(80, 26);
            this.udTxPrize.TabIndex = 44;
            this.udTxPrize.ValueChanged += new System.EventHandler(this.udTxPrize_ValueChanged);
            // 
            // tbValTotal
            // 
            this.tbValTotal.Location = new System.Drawing.Point(228, 12);
            this.tbValTotal.Name = "tbValTotal";
            this.tbValTotal.ReadOnly = true;
            this.tbValTotal.Size = new System.Drawing.Size(100, 26);
            this.tbValTotal.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbValTotal);
            this.groupBox2.Controls.Add(this.udTxPrize);
            this.groupBox2.Controls.Add(this.tbTransf);
            this.groupBox2.Controls.Add(this.tbApelido);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbPrimeiroNome);
            this.groupBox2.Location = new System.Drawing.Point(23, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 129);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(107, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número da compra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nº Cartão";
            // 
            // label4
            // 
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(528, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pontos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(112, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prémios por pontos";
            // 
            // label7
            // 
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(460, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total €";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(4, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Artigos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.SystemColors.Window;
            this.lblNome.Enabled = false;
            this.lblNome.Location = new System.Drawing.Point(315, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(345, 19);
            this.lblNome.TabIndex = 21;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbArtigo
            // 
            this.tbArtigo.Location = new System.Drawing.Point(111, 95);
            this.tbArtigo.Multiline = true;
            this.tbArtigo.Name = "tbArtigo";
            this.tbArtigo.Size = new System.Drawing.Size(342, 101);
            this.tbArtigo.TabIndex = 23;
            // 
            // tbIDcartao
            // 
            this.tbIDcartao.Enabled = false;
            this.tbIDcartao.Location = new System.Drawing.Point(106, 14);
            this.tbIDcartao.Name = "tbIDcartao";
            this.tbIDcartao.Size = new System.Drawing.Size(42, 26);
            this.tbIDcartao.TabIndex = 25;
            this.tbIDcartao.TextChanged += new System.EventHandler(this.tbIDcartao_TextChanged);
            this.tbIDcartao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIDcartao_KeyPress);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(171, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Nome do titular";
            // 
            // tbNrCompra
            // 
            this.tbNrCompra.Location = new System.Drawing.Point(295, 10);
            this.tbNrCompra.Name = "tbNrCompra";
            this.tbNrCompra.ReadOnly = true;
            this.tbNrCompra.Size = new System.Drawing.Size(50, 26);
            this.tbNrCompra.TabIndex = 27;
            // 
            // tbPontos
            // 
            this.tbPontos.Location = new System.Drawing.Point(603, 8);
            this.tbPontos.Name = "tbPontos";
            this.tbPontos.ReadOnly = true;
            this.tbPontos.Size = new System.Drawing.Size(54, 26);
            this.tbPontos.TabIndex = 28;
            // 
            // tbQtt
            // 
            this.tbQtt.Location = new System.Drawing.Point(459, 95);
            this.tbQtt.Multiline = true;
            this.tbQtt.Name = "tbQtt";
            this.tbQtt.Size = new System.Drawing.Size(65, 102);
            this.tbQtt.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Procurar";
            // 
            // cbCompra
            // 
            this.cbCompra.FormattingEnabled = true;
            this.cbCompra.Location = new System.Drawing.Point(111, 57);
            this.cbCompra.Name = "cbCompra";
            this.cbCompra.Size = new System.Drawing.Size(544, 28);
            this.cbCompra.TabIndex = 32;
            this.cbCompra.SelectedIndexChanged += new System.EventHandler(this.cbCompra_SelectedIndexChanged);
            // 
            // udTotalCompra
            // 
            this.udTotalCompra.DecimalPlaces = 2;
            this.udTotalCompra.Enabled = false;
            this.udTotalCompra.Location = new System.Drawing.Point(534, 205);
            this.udTotalCompra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.udTotalCompra.Name = "udTotalCompra";
            this.udTotalCompra.ReadOnly = true;
            this.udTotalCompra.Size = new System.Drawing.Size(121, 26);
            this.udTotalCompra.TabIndex = 33;
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(530, 95);
            this.tbPreco.Multiline = true;
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(125, 102);
            this.tbPreco.TabIndex = 34;
            // 
            // cbRebate
            // 
            this.cbRebate.FormattingEnabled = true;
            this.cbRebate.Location = new System.Drawing.Point(187, 242);
            this.cbRebate.Name = "cbRebate";
            this.cbRebate.Size = new System.Drawing.Size(424, 28);
            this.cbRebate.TabIndex = 38;
            this.cbRebate.SelectedIndexChanged += new System.EventHandler(this.cbRebate_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbIDcartao);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 339);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbRebate);
            this.groupBox3.Controls.Add(this.tbPreco);
            this.groupBox3.Controls.Add(this.udTotalCompra);
            this.groupBox3.Controls.Add(this.cbCompra);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbQtt);
            this.groupBox3.Controls.Add(this.tbPontos);
            this.groupBox3.Controls.Add(this.tbNrCompra);
            this.groupBox3.Controls.Add(this.tbArtigo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(3, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 289);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEscritorio);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLoja);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "              C  a  r  t  ã  o       M  y  C  h  i  c";
            ((System.ComponentModel.ISupportInitialize)(this.udTxPrize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTotalCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbPrimeiroNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbApelido;
        private System.Windows.Forms.TextBox tbTransf;
        private System.Windows.Forms.Button btnEscritorio;
        private System.Windows.Forms.NumericUpDown udTxPrize;
        private System.Windows.Forms.TextBox tbValTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbArtigo;
        private System.Windows.Forms.TextBox tbIDcartao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNrCompra;
        private System.Windows.Forms.TextBox tbPontos;
        private System.Windows.Forms.TextBox tbQtt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCompra;
        private System.Windows.Forms.NumericUpDown udTotalCompra;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.ComboBox cbRebate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

