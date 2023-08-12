namespace Banco
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
            textoTitular = new TextBox();
            textoNumero = new TextBox();
            textoSaldo = new TextBox();
            depositar = new Button();
            sacar = new Button();
            Titular = new Label();
            Numero = new Label();
            Saldo = new Label();
            Valor = new Label();
            textoValor = new TextBox();
            contaBox = new GroupBox();
            contaBox.SuspendLayout();
            SuspendLayout();
            // 
            // textoTitular
            // 
            textoTitular.Location = new Point(140, 24);
            textoTitular.Name = "textoTitular";
            textoTitular.Size = new Size(125, 27);
            textoTitular.TabIndex = 0;
            textoTitular.TextChanged += textoTitular_TextChanged;
            // 
            // textoNumero
            // 
            textoNumero.Location = new Point(140, 71);
            textoNumero.Name = "textoNumero";
            textoNumero.Size = new Size(125, 27);
            textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            textoSaldo.Location = new Point(140, 122);
            textoSaldo.Name = "textoSaldo";
            textoSaldo.Size = new Size(125, 27);
            textoSaldo.TabIndex = 2;
            // 
            // depositar
            // 
            depositar.Location = new Point(12, 214);
            depositar.Name = "depositar";
            depositar.Size = new Size(94, 29);
            depositar.TabIndex = 3;
            depositar.Text = "Depositar";
            depositar.UseVisualStyleBackColor = true;
            depositar.Click += botaoDepositar_Click;
            // 
            // sacar
            // 
            sacar.Location = new Point(140, 214);
            sacar.Name = "sacar";
            sacar.Size = new Size(94, 29);
            sacar.TabIndex = 4;
            sacar.Text = "Sacar";
            sacar.UseVisualStyleBackColor = true;
            sacar.Click += botaoSacar_Click;
            // 
            // Titular
            // 
            Titular.AutoSize = true;
            Titular.Location = new Point(13, 31);
            Titular.Name = "Titular";
            Titular.Size = new Size(51, 20);
            Titular.TabIndex = 5;
            Titular.Text = "Titular";
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(13, 78);
            Numero.Name = "Numero";
            Numero.Size = new Size(63, 20);
            Numero.TabIndex = 6;
            Numero.Text = "Numero";
            // 
            // Saldo
            // 
            Saldo.AutoSize = true;
            Saldo.Location = new Point(13, 129);
            Saldo.Name = "Saldo";
            Saldo.Size = new Size(47, 20);
            Saldo.TabIndex = 7;
            Saldo.Text = "Saldo";
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(13, 176);
            Valor.Name = "Valor";
            Valor.Size = new Size(43, 20);
            Valor.TabIndex = 8;
            Valor.Text = "Valor";
            // 
            // textoValor
            // 
            textoValor.Location = new Point(140, 169);
            textoValor.Name = "textoValor";
            textoValor.Size = new Size(125, 27);
            textoValor.TabIndex = 9;
            // 
            // contaBox
            // 
            contaBox.Controls.Add(textoValor);
            contaBox.Controls.Add(Valor);
            contaBox.Controls.Add(Saldo);
            contaBox.Controls.Add(Numero);
            contaBox.Controls.Add(Titular);
            contaBox.Controls.Add(sacar);
            contaBox.Controls.Add(depositar);
            contaBox.Controls.Add(textoSaldo);
            contaBox.Controls.Add(textoNumero);
            contaBox.Controls.Add(textoTitular);
            contaBox.Location = new Point(19, 18);
            contaBox.Name = "contaBox";
            contaBox.Size = new Size(285, 259);
            contaBox.TabIndex = 10;
            contaBox.TabStop = false;
            contaBox.Text = "Conta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 296);
            Controls.Add(contaBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contaBox.ResumeLayout(false);
            contaBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textoTitular;
        private TextBox textoNumero;
        private TextBox textoSaldo;
        private Button depositar;
        private Button sacar;
        private Label Titular;
        private Label Numero;
        private Label Saldo;
        private Label Valor;
        private TextBox textoValor;
        private GroupBox contaBox;
    }
}