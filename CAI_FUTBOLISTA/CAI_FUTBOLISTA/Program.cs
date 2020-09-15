using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_FUTBOLISTA
{
    class Program
    {
        static void Main(string[] args)
        {
            LISTA L = new LISTA();
            L.Agregar();
            L.Mostrar();
            L.Jugar();

            Console.ReadKey();



        }
    }
}
