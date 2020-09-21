using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_08_09_20202
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> ListaAutos = new List<Auto>();
            Auto a1 = new Auto("Ford", "Fiesta", "Nafta 1.4 TD");
            ListaAutos.Add(a1);
           // a1.QuitarStock(1, );

            Auto a2 = new Auto("Chevrolet", "Onix", "Nafta 1.3 TD");
            a2.AgregarUnAuto();
            //a2.QuitarStock(11);    intercambiar con lìnea 28 para ver què hace
            
            ListaAutos.Add(a2);

            ListaAutos.Add(new Auto("Volkswagen", "Golf", "Nafta 1.4 T5I "));
             
            Console.WriteLine("Ingrese el nombre de un auto");

            Auto a = new Auto();
            Auto a3 = a2;
            a2.QuitarStock(11);
            a3.AgregarUnAuto();

            foreach (Auto auto in ListaAutos)
            {
                Console.WriteLine(auto.ToString());
                if (auto.Vendido())
                {
                    Console.WriteLine("Esta vendido");
                }
                else
                {
                    Console.WriteLine("Hay stock");
                }
                //if (auto.Modelo.ToUpper().Contain(IngresoUsuario.ToUpper()))
                //{
                //    Console.WriteLine(auto.ToString());
                //}
            }
         string IngresoUsuario = Console.ReadLine();
        }
}

    public class Auto
    {
        private string marca;
        private string modelo;
        private string version;
        private int stock;


        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }

        }

        public string Modelo
        {
            get
            {
                return modelo;  
            }
            set
            {
                if (this.Marca == "ford")
                {
                    if (value == "fiesta")
                    {
                        modelo = value;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    modelo = value;
                }
            }
        }

        public string Version
        {
            get
            {
                return version;
            }
        }

        public Auto()
        { 
        }

        public Auto(string marca, string modelo, string version)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.version = version;
            this.stock = 10;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this.Marca, this.Modelo, this.Version);
        }

        public void AgregarUnAuto()
        {
            this.stock = this.stock + 1;
        }

        //public void AgregarStock(int cantidad)
        //{
        //    this.stock = this.stock + cantidad;  
        //}

        public void QuitarStock(int cantidad)
        {
            this.stock = this.stock - cantidad;
        }

        //public bool QuitarStock(int cantidad, bool desactivar)
        //{
        //    this.stock = this.stock - cantidad;
        //    if (desactivar)
        //    {
        //        return false;
        //    }
        //}

        //public bool Vendido()
        //{
        //    if (stock > o)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}


        public bool Vendido()
        {
            if (stock == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }





















}
