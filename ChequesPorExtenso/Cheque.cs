using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequesPorExtenso
{
    internal class Cheque
    {
        string[] unidades = new string[] { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        string[] DezenaComplexa = new string[] { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        string[] dezenas = new string[] { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        string[] centenas = new string[] { "cem", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

        string[] multiplicadorSingular = new string[] { "centavo", "real", "mil", "milhão", "bilhão" };
        string[] multiplicadorPlural = new string[] { "centavos", "reais", "mil", "milhões", "bilhões" };

        public string chequeEscritoPorExtenso(decimal valor)
        {
            string numeroString = Convert.ToString(valor);
            char[] array = numeroString.ToCharArray();
            string resultado = "";

            decimal max = 999999999999999999999999999m;

            if (valor > max || valor <= 0)
                resultado = "Valor Invalido";

            //primeiros 3 valores
            if (array.Length <= 3)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    resultado = resultado + array[i];
                }
            }

            return resultado;

        }

    }
}
