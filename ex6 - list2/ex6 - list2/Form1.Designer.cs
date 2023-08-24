
namespace ex6___list2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSabores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRefri = new System.Windows.Forms.CheckBox();
            this.chkBroto = new System.Windows.Forms.CheckBox();
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdCheque = new System.Windows.Forms.RadioButton();
            this.rdVista = new System.Windows.Forms.RadioButton();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzaria Pong";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escolha o seu sabor:";
            // 
            // cbSabores
            // 
            this.cbSabores.FormattingEnabled = true;
            this.cbSabores.Items.AddRange(new object[] {
            "Pizza de Polenguinho - R$15,00",
            "Pizza de Sal - R$10,00",
            "Pizza de Peixe Scott - R$20,00"});
            this.cbSabores.Location = new System.Drawing.Point(26, 169);
            this.cbSabores.Name = "cbSabores";
            this.cbSabores.Size = new System.Drawing.Size(173, 23);
            this.cbSabores.TabIndex = 2;
            this.cbSabores.SelectedIndexChanged += new System.EventHandler(this.cbSabores_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade:";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(26, 248);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(173, 23);
            this.txtQuant.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRefri);
            this.groupBox1.Controls.Add(this.chkBroto);
            this.groupBox1.Controls.Add(this.chkBorda);
            this.groupBox1.Location = new System.Drawing.Point(288, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionais";
            // 
            // chkRefri
            // 
            this.chkRefri.AutoSize = true;
            this.chkRefri.Location = new System.Drawing.Point(42, 126);
            this.chkRefri.Name = "chkRefri";
            this.chkRefri.Size = new System.Drawing.Size(95, 19);
            this.chkRefri.TabIndex = 2;
            this.chkRefri.Text = "Refri - R$2,00";
            this.chkRefri.UseVisualStyleBackColor = true;
            // 
            // chkBroto
            // 
            this.chkBroto.AutoSize = true;
            this.chkBroto.Location = new System.Drawing.Point(42, 79);
            this.chkBroto.Name = "chkBroto";
            this.chkBroto.Size = new System.Drawing.Size(117, 19);
            this.chkBroto.TabIndex = 1;
            this.chkBroto.Text = "Brotinho - R$4,00";
            this.chkBroto.UseVisualStyleBackColor = true;
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(42, 32);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(153, 19);
            this.chkBorda.TabIndex = 0;
            this.chkBorda.Text = "Borda recheada - R$1,50";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdCheque);
            this.groupBox2.Controls.Add(this.rdVista);
            this.groupBox2.Controls.Add(this.rdCredito);
            this.groupBox2.Location = new System.Drawing.Point(642, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 174);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de Pagamento";
            // 
            // rdCheque
            // 
            this.rdCheque.AutoSize = true;
            this.rdCheque.Location = new System.Drawing.Point(47, 125);
            this.rdCheque.Name = "rdCheque";
            this.rdCheque.Size = new System.Drawing.Size(107, 19);
            this.rdCheque.TabIndex = 2;
            this.rdCheque.TabStop = true;
            this.rdCheque.Text = "Cheque (+10%)";
            this.rdCheque.UseVisualStyleBackColor = true;
            // 
            // rdVista
            // 
            this.rdVista.AutoSize = true;
            this.rdVista.Location = new System.Drawing.Point(47, 78);
            this.rdVista.Name = "rdVista";
            this.rdVista.Size = new System.Drawing.Size(88, 19);
            this.rdVista.TabIndex = 1;
            this.rdVista.TabStop = true;
            this.rdVista.Text = "Vista (-10%)";
            this.rdVista.UseVisualStyleBackColor = true;
            this.rdVista.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Location = new System.Drawing.Point(47, 33);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(99, 19);
            this.rdCredito.TabIndex = 0;
            this.rdCredito.TabStop = true;
            this.rdCredito.Text = "Crédito (+5%)";
            this.rdCredito.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.btnFechar);
            this.groupBox3.Location = new System.Drawing.Point(288, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 125);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.Location = new System.Drawing.Point(468, 23);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(137, 86);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovo.Location = new System.Drawing.Point(250, 23);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(137, 86);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo Pedido";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFechar.Location = new System.Drawing.Point(42, 23);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(137, 86);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar Pedido";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(288, 487);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 25);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Valor total:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 489);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(937, 547);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSabores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSabores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRefri;
        private System.Windows.Forms.CheckBox chkBroto;
        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdCheque;
        private System.Windows.Forms.RadioButton rdVista;
        private System.Windows.Forms.RadioButton rdCredito;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox1;
    }
}

