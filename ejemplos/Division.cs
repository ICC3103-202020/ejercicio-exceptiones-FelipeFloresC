using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplos
{
    class Division
    {
        public void Dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
            {
                throw (new DivididoPorCero("División por cero encontrada") );
            }
            else
            {
                float cuociente = dividendo / divisor;
                Console.WriteLine("El cuociente de la división es: {0}", cuociente);
            }
        }

    }
}
