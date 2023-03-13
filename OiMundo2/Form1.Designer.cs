namespace OiMundo2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idade = new System.Windows.Forms.Label();
            this.nacionalidade = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.valorNota = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroInserido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 122);
            this.button1.TabIndex = 0;
            this.button1.Text = "Olá Mundo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 124);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ideda média";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(585, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 117);
            this.button3.TabIndex = 2;
            this.button3.Text = "Raizes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 111);
            this.button4.TabIndex = 3;
            this.button4.Text = "Pode votar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 4;
            // 
            // idade
            // 
            this.idade.AutoSize = true;
            this.idade.Location = new System.Drawing.Point(12, 232);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(105, 16);
            this.idade.TabIndex = 5;
            this.idade.Text = "Insira sua idade ";
            this.idade.Click += new System.EventHandler(this.label1_Click);
            // 
            // nacionalidade
            // 
            this.nacionalidade.AutoSize = true;
            this.nacionalidade.Location = new System.Drawing.Point(13, 268);
            this.nacionalidade.Name = "nacionalidade";
            this.nacionalidade.Size = new System.Drawing.Size(99, 16);
            this.nacionalidade.TabIndex = 7;
            this.nacionalidade.Text = "É Brasileiro(a)?";
            this.nacionalidade.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 268);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Sim";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(192, 268);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 20);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Não";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // valorNota
            // 
            this.valorNota.Location = new System.Drawing.Point(324, 236);
            this.valorNota.Name = "valorNota";
            this.valorNota.Size = new System.Drawing.Size(177, 22);
            this.valorNota.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(324, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 111);
            this.button5.TabIndex = 11;
            this.button5.Text = "Calcular imposto";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insira o valor da nota";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(550, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 111);
            this.button6.TabIndex = 15;
            this.button6.Text = "O número é: ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 17;
            // 
            // NumeroInserido
            // 
            this.NumeroInserido.Location = new System.Drawing.Point(550, 236);
            this.NumeroInserido.Name = "NumeroInserido";
            this.NumeroInserido.Size = new System.Drawing.Size(177, 22);
            this.NumeroInserido.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Insira um número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroInserido);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.valorNota);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.nacionalidade);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.Label nacionalidade;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox valorNota;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroInserido;
        private System.Windows.Forms.Label label3;
    }
}

