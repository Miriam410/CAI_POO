using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_FUTBOLISTA
{
    class FUTBOLISTA
    {
 
        private string Nombre;
        private string Apellido;
        private string Nacionalidad;
        private int Edad;
        private string Club;
        private bool Mundial;

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

        public string nacionalidad
        {
            get
            {
                return Nacionalidad;
            }
            set
            {
                Nacionalidad = value;
            }
        }

        public int edad
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

        public string club
        {
            get
            {
                return Club;
            }
            set
            {
                Club = value;
            }
        }

        public void setMundial(bool paramMundial)
        {
            Mundial = paramMundial;
        }

        public string getMundial()
        {
            return Mundial;
        }

        public FUTBOLISTA()
        {
        
        }

        public FUTBOLISTA(string Nombre, string Apellido, string Nacionalidad, int Edad,string Club)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Nacionalidad = Nacionalidad;
            this.Edad = Edad;
            this.Club = Club;
        }

       
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", this.Nombre, this.Apellido, this.Nacionalidad, this.Edad, this.Club, this.Mundial);
        }

        
        
    }
}
