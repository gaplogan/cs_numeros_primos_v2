using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPrimosV2
{
    class Primos
    {
		public static ListBox listBoxResultado;
		public static Label label_Resultado;

		public enum TipoCaractere
        {
            letra,
            numero
        }

		public enum TipoNum
        {
            primo,
            composto,
            todos
        }

		public bool VerificaPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

		public void VerificaPrimos(int inicio, int final, TipoNum tipoNumLista)
		{			
			listBoxResultado.Items.Clear();
			if (inicio > final)
			{
				int num = final;
				final = inicio;
				inicio = num;
			}

			if (inicio < 2)
			{
				inicio = 2;
			}

			switch (tipoNumLista)
			{
				case TipoNum.composto:
					label_Resultado.Text = "Números Compostos Entre " + inicio + " e " + final;
					break;
				case TipoNum.primo:
					label_Resultado.Text = "Números Primos Entre " + inicio + " e " + final;
					break;
				default:
					label_Resultado.Text = "Números Primos e Compostos Entre " + inicio + " e " + final;
					break;
			}

			for (int i = inicio; i <= final; i++)
			{
				if (VerificaPrimo(i))
				{
					if (tipoNumLista == TipoNum.todos || tipoNumLista == TipoNum.primo)
					{
						listBoxResultado.Items.Add("O número " + i + " é primo.");
					}
				}
				else if (tipoNumLista == TipoNum.todos || tipoNumLista == TipoNum.composto)
				{
					listBoxResultado.Items.Add("O número " + i + " não é primo.");
				}
			}
		}

		public bool VerificaCaractere(TipoCaractere car, char key)
		{
			string source = (car != TipoCaractere.numero) ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" : "0123456789";
			if (source.Contains(key))
			{
				return true;
			}
			return false;
		}
	}
}
