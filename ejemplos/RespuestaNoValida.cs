using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplos
{
    class RespuestaNoValida: ApplicationException
    {

        public RespuestaNoValida(string message): base(message)
        {
            Console.WriteLine("Error encontrado: ");
        }
    }
}
