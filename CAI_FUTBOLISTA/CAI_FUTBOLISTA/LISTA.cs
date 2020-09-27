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
            FUTBOLISTA f1 = new FUTBOLISTA("Lionel", "Messi", "Argentino", 33, "F.C.Barcelona");
            // tiene doble nacionalidad. españa x residencia
            f1.getMundial;
            f1.setMundial(true);
            

            FUTBOLISTA f2 = new FUTBOLISTA("Cristiano", "Ronaldo", "Portugues", 35, "Juventus F.C");
            f2.getMundial;
            f2.setMundial(true);
            

            FUTBOLISTA f3 = new FUTBOLISTA("Leonardo Rafael", "Jara", "Argentino", 29, "C.A.Boca Juniors");
            f3.getMundial;
            f3.setMundial(false);

            FUTBOLISTA f4 = new FUTBOLISTA("Toni", "Kroos", "Alemana", 30, "Real Madrid C.F");
            f4.getMundial;
            f4.setMundial(true);
            

            FUTBOLISTA f5 = new FUTBOLISTA("Santiago Mariano", "Rodriguez","Montevideo",20, "CLub Nacional de Football");
            f5.getMundial;
            f5.setMundial(false);
            

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
            int Edad= 0;
            bool Mundial=false;
            foreach (FUTBOLISTA futbolista in ListaFutb)
            {
                if (!Mundial && (Edad <= 36))
                {
                    Console.WriteLine("Puede serguir jugando en el mundial");
                }
                else 
                {
                    if (!Mundial && (Edad > 36))
                    {
                        Console.WriteLine("No puede jugar, excede de la edad");
                    }
                    else
                    {
                        if (Mundial && Edad<36)
                        {
                            Console.WriteLine("No puede jugar, aunque tenga la edad");
                        }
                        else
                        {
                            Console.WriteLine("No puede jugar");
                        }
                    }
                }
            }
        }

    }
}
