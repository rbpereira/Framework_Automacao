using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Comum
{
    public static class GeradorCpfCnpj
    {
        public static String GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            return semente;
        }

        public static String GerarCnpj()
        {

            var comPontos = false;
            string cnpj;
            Random randomiza = new Random();

            var n = 9;
            int n1 = randomiza.Next(0, n);
            int n2 = randomiza.Next(0, n);
            int n3 = randomiza.Next(0, n);
            int n4 = randomiza.Next(0, n);
            int n5 = randomiza.Next(0, n);
            int n6 = randomiza.Next(0, n);
            int n7 = randomiza.Next(0, n);
            int n8 = randomiza.Next(0, n);
            int n9 = 0; //randomiza(n);
            int n10 = 0; //randomiza(n);
            int n11 = 0; //randomiza(n);
            int n12 = 1; //randomiza(n);
            int d1 = n12 * 2 + n11 * 3 + n10 * 4 + n9 * 5 + n8 * 6 + n7 * 7 + n6 * 8 + n5 * 9 + n4 * 2 + n3 * 3 + n2 * 4 + n1 * 5;
            d1 = 11 - (d1 % 11);
            if (d1 >= 10) d1 = 0;
            var d2 = d1 * 2 + n12 * 3 + n11 * 4 + n10 * 5 + n9 * 6 + n8 * 7 + n7 * 8 + n6 * 9 + n5 * 2 + n4 * 3 + n3 * 4 + n2 * 5 + n1 * 6;
            d2 = 11 - (d2 % 11);
            if (d2 >= 10) d2 = 0;
            cnpj = "";
            if (comPontos)
            {
                cnpj = "" + n1 + n2 + "." + n3 + n4 + n5 + "." + n6 + n7 + n8 + "/" + n9 + n10 + n11 + n12 + "-" + d1 + d2;
            }
            else
            {
                cnpj = "" + n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 + n11 + n12 + d1 + d2;
            }

            return cnpj;

        }
    }
}
