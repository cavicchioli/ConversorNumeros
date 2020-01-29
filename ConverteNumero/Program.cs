using System;
using System.Collections.Generic;
using System.Linq;

namespace ConverteNumero
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dicionario = criarDicionario();

            Console.WriteLine(retornarNumeroExtenso(int.Parse(Console.ReadLine()), dicionario));

            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine(retornarNumeroExtenso(i, dicionario));
            //}

        }

        public static string retornarNumeroExtenso(int numero, Dictionary<int, string> dict)
        {
            List<string> numeroExtenso = new List<string>();

            if (dict.ContainsKey(numero))
            {
                return dict[numero];
            }
            else
            {
                var stringNumero = numero.ToString();
                var tamanhoNumero = stringNumero.Length;


                if (tamanhoNumero == 2)
                {
                    var dezena = int.Parse(stringNumero[0].ToString()) *10;
                    var unidade = int.Parse(stringNumero[1].ToString());

                    numeroExtenso.Add($"{dict[dezena]} e ");
                    numeroExtenso.Add(unidade == 0 ? "" : dict[unidade]);
                }
                else if (tamanhoNumero == 3)
                {
                    var centena = int.Parse(stringNumero[0].ToString()) * 100;
                    var dezena = int.Parse(stringNumero[1].ToString()) * 10;
                    var unidade = int.Parse(stringNumero[2].ToString());

                    numeroExtenso.Add(centena == 100? $"cento e " : $"{dict[centena]} e ");
                    numeroExtenso.Add(dezena == 0 ? "" : $"{dict[dezena]} e ");
                    numeroExtenso.Add(unidade == 0 ? "" : dict[unidade]);
                }
            }

            return string.Join("", numeroExtenso.Select(x => x));
        }

        public static Dictionary<int, string> criarDicionario()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(0, "zero");
            dict.Add(1, "um");
            dict.Add(2, "dois");
            dict.Add(3, "três");
            dict.Add(4, "quatro");
            dict.Add(5, "cinco");
            dict.Add(6, "seis");
            dict.Add(7, "sete");
            dict.Add(8, "oito");
            dict.Add(9, "nove");
            dict.Add(10, "dez");
            dict.Add(11, "onze");
            dict.Add(12, "doze");
            dict.Add(13, "treze");
            dict.Add(14, "quatorze");
            dict.Add(15, "quinze");
            dict.Add(16, "dezesseis");
            dict.Add(17, "dezessete");
            dict.Add(18, "dezoito");
            dict.Add(19, "dezenove");
            dict.Add(20, "vinte");
            dict.Add(30, "trinta");
            dict.Add(40, "quarenta");
            dict.Add(50, "cinquenta");
            dict.Add(60, "sessenta");
            dict.Add(70, "setenta");
            dict.Add(80, "oitenta");
            dict.Add(90, "noventa");
            dict.Add(100, "cem");
            dict.Add(200, "duzentos");
            dict.Add(300, "trezentos");
            dict.Add(400, "quatrocentos");
            dict.Add(500, "quinhentos");
            dict.Add(600, "seiscentos");
            dict.Add(700, "setecentos");
            dict.Add(800, "oitocentos");
            dict.Add(900, "novecentos");

            return dict;
        }
    }
}
