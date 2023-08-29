
namespace ex3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbldiv = new System.Windows.Forms.Label();
            this.lblsoma = new System.Windows.Forms.Label();
            this.lblsub = new System.Windows.Forms.Label();
            this.lblmul = new System.Windows.Forms.Label();
            this.buttonsoma = new System.Windows.Forms.Button();
            this.buttonsub = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.buttonmul = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(95, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbldiv
            // 
            this.lbldiv.AutoSize = true;
            this.lbldiv.Location = new System.Drawing.Point(428, 78);
            this.lbldiv.Name = "lbldiv";
            this.lbldiv.Size = new System.Drawing.Size(0, 15);
            this.lbldiv.TabIndex = 1;
            // 
            // lblsoma
            // 
            this.lblsoma.AutoSize = true;
            this.lblsoma.Location = new System.Drawing.Point(428, 120);
            this.lblsoma.Name = "lblsoma";
            this.lblsoma.Size = new System.Drawing.Size(0, 15);
            this.lblsoma.TabIndex = 2;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Location = new System.Drawing.Point(428, 162);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(0, 15);
            this.lblsub.TabIndex = 3;
            // 
            // lblmul
            // 
            this.lblmul.AutoSize = true;
            this.lblmul.Location = new System.Drawing.Point(428, 212);
            this.lblmul.Name = "lblmul";
            this.lblmul.Size = new System.Drawing.Size(0, 15);
            this.lblmul.TabIndex = 4;
            // 
            // buttonsoma
            // 
            this.buttonsoma.Location = new System.Drawing.Point(543, 116);
            this.buttonsoma.Name = "buttonsoma";
            this.buttonsoma.Size = new System.Drawing.Size(75, 23);
            this.buttonsoma.TabIndex = 5;
            this.buttonsoma.Text = "+";
            this.buttonsoma.UseVisualStyleBackColor = true;
            this.buttonsoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsub
            // 
            this.buttonsub.Location = new System.Drawing.Point(363, 214);
            this.buttonsub.Name = "buttonsub";
            this.buttonsub.Size = new System.Drawing.Size(75, 23);
            this.buttonsub.TabIndex = 6;
            this.buttonsub.Text = "-";
            this.buttonsub.UseVisualStyleBackColor = true;
            this.buttonsub.Click += new System.EventHandler(this.buttonsub_Click);
            // 
            // buttondiv
            // 
            this.buttondiv.Location = new System.Drawing.Point(490, 214);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(75, 23);
            this.buttondiv.TabIndex = 7;
            this.buttondiv.Text = "/";
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.buttondiv_Click);
            // 
            // buttonmul
            // 
            this.buttonmul.Location = new System.Drawing.Point(474, 268);
            this.buttonmul.Name = "buttonmul";
            this.buttonmul.Size = new System.Drawing.Size(75, 23);
            this.buttonmul.TabIndex = 8;
            this.buttonmul.Text = "*";
            this.buttonmul.UseVisualStyleBackColor = true;
            this.buttonmul.Click += new System.EventHandler(this.buttonmul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonmul);
            this.Controls.Add(this.buttondiv);
            this.Controls.Add(this.buttonsub);
            this.Controls.Add(this.buttonsoma);
            this.Controls.Add(this.lblmul);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.lblsoma);
            this.Controls.Add(this.lbldiv);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbldiv;
        private System.Windows.Forms.Label lblsoma;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label lblmul;
        private System.Windows.Forms.Button buttonsoma;
        private System.Windows.Forms.Button buttonsub;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button buttonmul;
    }
}

