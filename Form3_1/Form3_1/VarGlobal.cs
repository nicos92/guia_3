using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form3_1
{
    public static class VarGlobal
    {
        public static int MontoIngresado = 0;
        public static int ValorProducto = 0;
        public static List<TipoCambio> ListTipoCambio = new List<TipoCambio>();
        public static int[] ArrValor = { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        public static int resto =0;
        public static int resultado=0;

        public static TipoCambio tc = new TipoCambio();
        
    }
}
