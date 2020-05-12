using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPrimosV2
{
    public partial class Form1 : Form
    {
        private Primos primos;

        public Form1()
        {
            InitializeComponent();
            primos = new Primos();
            Primos.listBoxResultado = listBoxResultado;
            Primos.label_Resultado = label_Resultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNumero2.Select();
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!primos.VerificaCaractere(Primos.TipoCaractere.numero, e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\r')
            {
                btnVerificarPrimo_Click(btnVerificarPrimo, EventArgs.Empty);
            }
        }

        private void textBoxNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!primos.VerificaCaractere(Primos.TipoCaractere.numero, e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\r')
            {
                btnClassificarNumeros_Click(btnClassificarNumeros, EventArgs.Empty);
            }
        }

        private void btnVerificarPrimo_Click(object sender, EventArgs e)
        {
            if (!(textBoxNumero.Text == ""))
            {
                label_Resultado.Text = "";
                if (primos.VerificaPrimo(Convert.ToInt32(textBoxNumero.Text)))
                {
                    label_Resultado.Text = "O número " + textBoxNumero.Text + " é primo.";
                }
                else
                {
                    label_Resultado.Text = "O número " + textBoxNumero.Text + " não é primo.";
                }
            }
        }

        private void btnClassificarNumeros_Click(object sender, EventArgs e)
        {
            if (!(textBoxNumero.Text == "") && !(textBoxNumero2.Text == ""))
            {
                label_Resultado.Text = "";
                primos.VerificaPrimos(Convert.ToInt32(textBoxNumero.Text), Convert.ToInt32(textBoxNumero2.Text), Primos.TipoNum.todos);
            }
        }

        private void btnSoNumerosPrimos_Click(object sender, EventArgs e)
        {
            if (!(textBoxNumero.Text == "") && !(textBoxNumero2.Text == ""))
            {
                label_Resultado.Text = "";
                primos.VerificaPrimos(Convert.ToInt32(textBoxNumero.Text), Convert.ToInt32(textBoxNumero2.Text), Primos.TipoNum.primo);
            }
        }

        private void btnSoNumerosCompostos_Click(object sender, EventArgs e)
        {
            if (!(textBoxNumero.Text == "") && !(textBoxNumero2.Text == ""))
            {
                label_Resultado.Text = "";
                primos.VerificaPrimos(Convert.ToInt32(textBoxNumero.Text), Convert.ToInt32(textBoxNumero2.Text), Primos.TipoNum.composto);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxNumero.Text = "2";
            textBoxNumero2.Text = "";
            label_Resultado.Text = "Verificar Números Primos";
            listBoxResultado.Items.Clear();
            textBoxNumero2.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
