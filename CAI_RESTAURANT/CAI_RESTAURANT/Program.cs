using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_RESTAURANT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> ListaRest = new List<Restaurant>();

            Restaurant R1 = new Restaurant(1, "Maria", "Lopez", 35, DateTime.Parse("21/09/2020 14:00:00"));
            ListaRest.Add(R1);
            R1.AgregarMesa();
            R1.AgregarSilla();
            R1.AgregarSilla();
            R1.AgregarSilla();
            R1.QuitarSilla(1);

            Restaurant R2 = new Restaurant(1, "Lucia", "Lopez", 25, DateTime.Parse("21/09/2020 12:00:00"));
            ListaRest.Add(R2);
            R2.AgregarSilla();
           
            Restaurant R3 = new Restaurant(1, "Juan", "Perez", 40, DateTime.Parse("25/09/2020 09:00:00"));
            ListaRest.Add(R3);
            R3.AgregarSilla();
            R3.AgregarSilla();
           
            Restaurant R4 = new Restaurant(1, "Carlos", "Fernandez", 60, DateTime.Parse("07/10/2020 21:00:00"));
            ListaRest.Add(R4);
           
            Restaurant R5 = new Restaurant(1, "Mirta", "Duran", 58, DateTime.Parse("07/10/2020 15:00:00"));
            ListaRest.Add(R5);

          
   

            Console.ReadKey();
        
        }
    }
}


    class Restaurant 
    {
        private int Reserva;
        private string Nombre;
        private string Apellido;
        private int Edad;
        private DateTime FechaHora;
        private int Mesa;
        private int Silla;
        
        public int reserva
        {
            get
            {
                return Reserva;
            }
            set
            {
                Reserva = value;
            }
        }

        public string nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public string apellido
        {
            get
            {
                return Apellido;
            }
            set
            {
                Apellido = value;
            }
        }

        private int edad
        {
            get
            {
                return Edad;
            }
            set
            {
                Edad = value;
            }
        }
        public DateTime fechahora
        {
            get 
            {
                return FechaHora;
            }
            set
            {
                FechaHora = value;
            }
        }


        public Restaurant(int Reserva,string Nombre, string Apellido, int Edad, DateTime FechaHora)
        {
            this.Reserva = Reserva;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.FechaHora = FechaHora;
            this.Mesa = 30;
            this.Silla = 50;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} ", this.Reserva, this.Nombre, this.Apellido,this.Edad, this.FechaHora);
        }

        public void AgregarMesa()
        {
            this.Mesa += 1;
        }

        public void AgregarSilla()
        {
            this.Silla += 1;
        }
        public void QuitarSilla(int Cantidad)
        {
            this.Silla = this.Silla - Cantidad;
        }

}

