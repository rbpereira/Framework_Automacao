using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Comum
{
    public static class GerarNumeros
    {
        public static string GerarNumerosAleatorios()
        {
            Random randNum = new Random();
            var Num = randNum.Next(1,1000);

            return Num.ToString();
        }

        public static string GerarValoresAleatorios()
        {
            Random randNum = new Random();
            var Num = randNum.Next(1, 1000);

            return Num.ToString() + ",00";
        }
    }
}
