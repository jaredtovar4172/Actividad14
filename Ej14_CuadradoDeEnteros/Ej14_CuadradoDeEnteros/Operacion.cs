using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14_CuadradoDeEnteros
{
    class Operacion
    {
        public decimal Op (decimal b)
        {
            decimal aux = b;
            for (int i = 1; i <= 2 - 1; i++)
                aux = aux * b;
            return (aux);
        }
}
}
