namespace NumerosPrimosV2
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
            this.label_Resultado = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.btnVerificarPrimo = new System.Windows.Forms.Button();
            this.btnClassificarNumeros = new System.Windows.Forms.Button();
            this.btnSoNumerosPrimos = new System.Windows.Forms.Button();
            this.btnSoNumerosCompostos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_Resultado
            // 
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Resultado.Location = new System.Drawing.Point(13, 13);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(759, 71);
            this.label_Resultado.TabIndex = 0;
            this.label_Resultado.Text = "Verificar números primos";
            this.label_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.Location = new System.Drawing.Point(522, 99);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(250, 49);
            this.textBoxNumero.TabIndex = 1;
            this.textBoxNumero.Text = "2";
            this.textBoxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero2.Location = new System.Drawing.Point(522, 154);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(250, 49);
            this.textBoxNumero2.TabIndex = 2;
            this.textBoxNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero2_KeyPress);
            // 
            // btnVerificarPrimo
            // 
            this.btnVerificarPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarPrimo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerificarPrimo.Location = new System.Drawing.Point(522, 209);
            this.btnVerificarPrimo.Name = "btnVerificarPrimo";
            this.btnVerificarPrimo.Size = new System.Drawing.Size(250, 60);
            this.btnVerificarPrimo.TabIndex = 3;
            this.btnVerificarPrimo.Text = "Verificar Primo";
            this.btnVerificarPrimo.UseVisualStyleBackColor = true;
            this.btnVerificarPrimo.Click += new System.EventHandler(this.btnVerificarPrimo_Click);
            // 
            // btnClassificarNumeros
            // 
            this.btnClassificarNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassificarNumeros.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClassificarNumeros.Location = new System.Drawing.Point(522, 275);
            this.btnClassificarNumeros.Name = "btnClassificarNumeros";
            this.btnClassificarNumeros.Size = new System.Drawing.Size(250, 60);
            this.btnClassificarNumeros.TabIndex = 4;
            this.btnClassificarNumeros.Text = "Classificar Números";
            this.btnClassificarNumeros.UseVisualStyleBackColor = true;
            this.btnClassificarNumeros.Click += new System.EventHandler(this.btnClassificarNumeros_Click);
            // 
            // btnSoNumerosPrimos
            // 
            this.btnSoNumerosPrimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoNumerosPrimos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSoNumerosPrimos.Location = new System.Drawing.Point(522, 341);
            this.btnSoNumerosPrimos.Name = "btnSoNumerosPrimos";
            this.btnSoNumerosPrimos.Size = new System.Drawing.Size(250, 60);
            this.btnSoNumerosPrimos.TabIndex = 5;
            this.btnSoNumerosPrimos.Text = "Só Números Primos";
            this.btnSoNumerosPrimos.UseVisualStyleBackColor = true;
            this.btnSoNumerosPrimos.Click += new System.EventHandler(this.btnSoNumerosPrimos_Click);
            // 
            // btnSoNumerosCompostos
            // 
            this.btnSoNumerosCompostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoNumerosCompostos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSoNumerosCompostos.Location = new System.Drawing.Point(522, 407);
            this.btnSoNumerosCompostos.Name = "btnSoNumerosCompostos";
            this.btnSoNumerosCompostos.Size = new System.Drawing.Size(250, 60);
            this.btnSoNumerosCompostos.TabIndex = 6;
            this.btnSoNumerosCompostos.Text = "Só Números Compostos";
            this.btnSoNumerosCompostos.UseVisualStyleBackColor = true;
            this.btnSoNumerosCompostos.Click += new System.EventHandler(this.btnSoNumerosCompostos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpar.Location = new System.Drawing.Point(522, 473);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(250, 60);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(522, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 60);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 37;
            this.listBoxResultado.Location = new System.Drawing.Point(13, 99);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(494, 485);
            this.listBoxResultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSoNumerosCompostos);
            this.Controls.Add(this.btnSoNumerosPrimos);
            this.Controls.Add(this.btnClassificarNumeros);
            this.Controls.Add(this.btnVerificarPrimo);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label_Resultado);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Números Primos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Button btnVerificarPrimo;
        private System.Windows.Forms.Button btnClassificarNumeros;
        private System.Windows.Forms.Button btnSoNumerosPrimos;
        private System.Windows.Forms.Button btnSoNumerosCompostos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxResultado;
    }
}

