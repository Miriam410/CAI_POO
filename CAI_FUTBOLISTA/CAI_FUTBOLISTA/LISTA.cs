using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_FUTBOLISTA
{
    class LISTA
    {
        List<FUTBOLISTA> ListaFutb = new List<FUTBOLISTA>();
        public void Agregar()
        {
            FUTBOLISTA f1 = new FUTBOLISTA("Lionel", "Messi", "Argentino", 33, "F.C.Barcelona", true);
            // tiene doble nacionalidad. españa x residencia

            FUTBOLISTA f2 = new FUTBOLISTA("Cristiano", "Ronaldo", "Portugues", 35, "Juventus F.C", true);
           
            FUTBOLISTA f3 = new FUTBOLISTA("Leonardo Rafael", "Jara", "Argentino", 29, "C.A.Boca Juniors", false);
  
            FUTBOLISTA f4 = new FUTBOLISTA("Toni", "Kroos", "Alemana", 30, "Real Madrid C.F",true);
            
            FUTBOLISTA f5 = new FUTBOLISTA("Santiago Mariano", "Rodriguez","Montevideo",20, "CLub Nacional de Football", false);
           
            ListaFutb.Add(f1);
            ListaFutb.Add(f2);
            ListaFutb.Add(f3);
            ListaFutb.Add(f4);
            ListaFutb.Add(f5);
        }

        public void Mostrar()
        {
            string Acumulador = "";
            foreach (FUTBOLISTA futbolista in ListaFutb)
            {
                Acumulador += futbolista.ToString() + System.Environment.NewLine;
            }
            Console.WriteLine("Lista de jugadores: " + System.Environment.NewLine);
            Console.WriteLine(Acumulador);
        }
        public void Jugar()
        {
            int Edad =0;
            bool Mundial = true;
            foreach (FUTBOLISTA futbolista in ListaFutb)
            {
                if (Mundial && (Edad <= 36))
                {
                    Console.WriteLine("Puede serguir jugando en el mundial");
                }
                else if (Mundial && (Edad > 36))
                {
                    Console.WriteLine("No puede jugar, excede de la edad");
                }
                else
                {
                    Console.WriteLine("No puede jugar");
                }
            }
        }

    }
}
