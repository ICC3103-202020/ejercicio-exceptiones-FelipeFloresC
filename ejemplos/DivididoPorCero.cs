using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplos
{
    class DivididoPorCero: ApplicationException
    {
        public DivididoPorCero(string message): base(message)
        {

        }
    }
}
