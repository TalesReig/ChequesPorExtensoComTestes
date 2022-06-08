using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheques_Por_Extenso
{
    public class Cheque
    {
        string[] unidades = new string[] { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        string[] DezenaComplexa = new string[] { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        string[] dezenas = new string[] { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        string[] centenas = new string[] { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

        string[] multiplicadorSingular = new string[] { "centavo", "real", "mil", "milhão", "bilhão" };
        string[] multiplicadorPlural = new string[] { "centavos", "reais", "mil", "milhões", "bilhões" };

        public string chequeEscritoPorExtenso(decimal valor)
        {
            //string numeroString = Convert.ToString(valor);
            //char[] array = numeroString.ToCharArray();
            string resultado = "";

            decimal max = 999999999999999999999999999m;

            if (valor > max || valor <= 0)
                resultado = "Valor Invalido";

            var partes = ObterPartesDoValor(valor);

            int numero = 0;
            string juncao = "";

            for (int i = partes.Count; i > 0; i--)
            {
                string classeAtual = partes[i - 1];

                string SingularOuPlural = classeAtual == "001" ? multiplicadorSingular[numero] : multiplicadorPlural[numero];

                if(classeAtual != "000")
                {
                    string centena = classeAtual[0].ToString();
                    string dezena = classeAtual[1].ToString();
                    string unidade = classeAtual[2].ToString();


                    int centenaInt = Convert.ToInt32(centena);
                    int dezenaInt = Convert.ToInt32(dezena);
                    int unidadeInt = Convert.ToInt32(unidade);

                    //Conmtrola Unidades
                    if (centena == "0" && dezena == "0" && unidade != "0")
                    {
                        resultado = resultado + unidades[unidadeInt];
                    }

                    //Controla Dezenas
                    if(centena == "0" && dezena != "0")
                    {
                        //Dezenas Simples Multiplos de 10
                        if (centena == "0" && dezena != "0" && unidade == "0")
                        {
                            resultado = resultado + dezenas[dezenaInt];
                        }
                        //DezenaComplexa 11-19
                        else if (centena == "0" && dezena == "1" && unidade != "0")
                        {
                            resultado = resultado + DezenaComplexa[unidadeInt];
                        }

                        //DezenaComplexa 20 - 99
                        else if (centena == "0" && dezenaInt > 1 && unidade != "0")
                        {
                            resultado = resultado + dezenas[dezenaInt] +" e "+ unidades[unidadeInt];
                        }
                    }

                    //Controla Centenas
                    if(centena != "0")
                    {
                        //Cem
                        if (centena == "1" && dezena == "0" && unidade == "0")
                        {
                            resultado = resultado + "cem";
                        }

                        //Centenas Simples Multiplos de 100
                        else if (dezena == "0" && unidade == "0")
                        {
                            resultado = resultado + centenas[centenaInt];
                        }

                        //Centenas Complexa Multiplos de 100 + (unidades)
                        else if (dezena == "0" && unidade != "0")
                        {
                            resultado = resultado + centenas[centenaInt] + " e " + unidades[unidadeInt];
                        }

                        //Centenas Complexa Multiplos de 100 + (11...19)
                        else if (dezena == "1" && unidade != "0")
                        {
                            resultado = resultado + centenas[centenaInt] +" e "+ DezenaComplexa[unidadeInt];
                        }
                        //Centenas Complexa Multiplos de 100 + (1...99)
                        else
                        {
                            if(unidade == "0")
                                resultado = resultado + centenas[centenaInt] +" e "+ dezenas[dezenaInt];
                            else if(unidade != "0")
                                resultado = resultado + centenas[centenaInt] +" e "+ dezenas[dezenaInt] +" e "+ unidades[unidadeInt];

                        }
                    }
                }
            }

                return resultado;

        }

        private List<string> ObterPartesDoValor(decimal valor)                                                                        //centavos por ultimo
        {
            string valorStr = valor.ToString("000,000,000,000.00");
            string[] partesEDecimal = valorStr.Split(',');
            string[] partes = partesEDecimal[0].Split('.');

            return new List<string>(partes)
            {
                "0" + partesEDecimal[1]
            };
        }

    }
}

