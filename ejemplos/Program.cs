using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplos
{
    class Program
    {
        public static void Main(string[] args)
        {
            // poema - manejo de error
            Console.WriteLine("Cada ves que pienso en tí,");
            Console.WriteLine("mis ojos rompen en llanto;");
            Console.WriteLine("y muy triste me pregunto,");
            Console.WriteLine("¿porqué te quiero tanto?");
            Console.WriteLine();
            int gustaPoema = 2;
            do
            {
                Console.WriteLine("Te gusta el poema (si/no)");
                string g = Console.ReadLine();
                gustaPoema = Verificar(g);
                
            } while (gustaPoema == 2);

            // probar división - Crear una excepción personalizada
            Division div = new Division();
            try
            {
                Console.WriteLine("ingrese el dividendo");
                int dividendo = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el divisor");
                int divisor = System.Convert.ToInt32(Console.ReadLine());
                div.Dividir(dividendo, divisor);
            }
            catch (DivididoPorCero d)
            {
                Console.WriteLine("ExepciónDivisionPorCero: {0}", d.Message);
            }
            finally
            {
                Console.WriteLine("Gracias por preferir mi divisor");
            }
            Console.ReadKey();
        }
        private static int Verificar(string respuesta)
        {
            string d = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToLower(respuesta);
            if (d == "si")
            {
                Console.WriteLine("genial :)");
                return 1;
            }
            else if (d == "no")
            {
                Console.WriteLine("que pena :(");
                return 0;
            }
            else
            {
                ArgumentException e = new ArgumentException("Por favor ingresar una respuesta válida (presione enter para continuar)");
                Console.WriteLine(e.Message);
                return 2;
            }
        }

    } 
}
