using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuminiHireApi.Util
{
    public static class functions
    {
        public static String Acentuacao(String termo)
        {
            var sb = new StringBuilder(termo.ToUpper());

            sb.Replace("Á", "A");
            sb.Replace("À", "A");
            sb.Replace("Ã", "A");
            sb.Replace("Ê", "E");
            sb.Replace("É", "E");
            sb.Replace("Í", "I");
            sb.Replace("Ó", "O");
            sb.Replace("Õ", "O");
            sb.Replace("Ú", "U");
            sb.Replace("Y", "I");
            sb.Replace("BR", "B");
            sb.Replace("BL", "B");
            sb.Replace("PH", "F");
            sb.Replace("MG", "G");
            sb.Replace("NG", "G");
            sb.Replace("RG", "G");
            sb.Replace("GE", "J");
            sb.Replace("GI", "J");
            sb.Replace("RJ", "J");
            sb.Replace("MJ", "J");
            sb.Replace("NJ", "J");
            sb.Replace("GR", "G");
            sb.Replace("GL", "G");
            sb.Replace("CE", "S");
            sb.Replace("CI", "S");
            sb.Replace("CH", "S");
            sb.Replace("CT", "T");
            sb.Replace("CS", "S");
            sb.Replace("Q", "K");
            sb.Replace("CA", "K");
            sb.Replace("CO", "K");
            sb.Replace("CU", "K");
            sb.Replace("CK", "K");
            sb.Replace("C", "K");
            sb.Replace("LH", "L");
            sb.Replace("RM", "SM");
            sb.Replace("N", "M");
            sb.Replace("GM", "M");
            sb.Replace("MD", "M");
            sb.Replace("NH", "N");
            sb.Replace("PR", "P");
            sb.Replace("X", "S");
            sb.Replace("TS", "S");
            sb.Replace("C", "S");
            sb.Replace("Z", "S");
            sb.Replace("RS", "S");
            sb.Replace("TR", "T");
            sb.Replace("TL", "T");
            sb.Replace("LT", "T");
            sb.Replace("RT", "T");
            sb.Replace("ST", "T");
            sb.Replace("W", "V");

            int tam = sb.Length - 1;
            if (tam > -1)
            {
                switch (sb[tam])
                {
                    case 'S':
                    case 'Z':
                    case 'R':
                    case 'M':
                    case 'N':
                        sb.Remove(tam, 1);
                        break;
                    case 'L':
                        sb[tam] = 'U';
                        break;
                }

            }

            tam = sb.Length - 2;
            if (tam > -1)
            {
                if (sb[tam] == 'A' && sb[tam + 1] == 'O')
                {
                    sb.Remove(tam, 2);
                }
            }
            // ---------
            sb.Replace("Ç", "S");

            sb.Replace("L", "R");
            /* if (!_usarVogais)
            {
                sb.Replace("A", "");
                sb.Replace("E", "");
                sb.Replace("I", "");
                sb.Replace("O", "");
                sb.Replace("U", "");
            } */
            sb.Replace("H", "");

            StringBuilder frasesaida = new StringBuilder();
            if (sb.Length <= 0) return "";
            frasesaida.Append(sb[0]);
            for (int i = 1; i <= sb.Length - 1; i += 1)
            {
                if (frasesaida[frasesaida.Length - 1] != sb[i] || char.IsDigit(sb[i]))
                    frasesaida.Append(sb[i]);
            }

            return frasesaida.ToString();
        }


        public static string RemoverAcentuacao(this string text)
        {
            var textolimpo = new string(text
                .Normalize(NormalizationForm.FormD)
                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray());

            return textolimpo;
        }


        public static string removerAcentos(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return texto;
        }
    }
}
