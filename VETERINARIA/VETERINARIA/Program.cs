using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria v1 = new Veterinaria();
            v1.AgregarVeterinaria();
            v1.Mostrar();
            v1.cambiarPrecio(v1, 500);
            Console.ReadKey();
        }

        class Veterinaria
        {
            public List<Veterinaria> ListaV = new List<Veterinaria>();

            private string Doctor;
            private string Pago;
            private string Mascota;
            private DateTime Turno;
            private float Precio;

            public string doctor
            {
                get
                {
                    return Doctor;
                }
                set
                {
                    Doctor = value;
                }
            }

            public string pago
            {
                get
                {
                    return Pago;
                }
                set
                {
                    Pago = value;
                }
            }

            public string mascota
            {
                get
                {
                    return Mascota;
                }
                set
                {
                    Mascota = value;
                }
            }

            public DateTime turno
            {
                get
                {
                    return Turno;
                }
                set
                {
                    Turno = value;
                }
            }

            public float precio
            {
                get
                {
                    return Precio;
                }
                set
                {
                    Precio = value;
                }
            }


            public void AgregarVeterinaria()
            {
                Veterinaria v1 = new Veterinaria();
                v1.Doctor = "Lopaz";
                v1.Pago = "Efectivo";
                v1.Mascota = "Perro";
                v1.Turno = DateTime.Parse("02-09-2020");
                v1.Precio = 100;
                ListaV.Add(v1);
            }

            public void cambiarPrecio(Veterinaria v1, float precio)
            {
                v1.Precio = precio;
            }

            public override string ToString()
            {
                return string.Format("{0} - {1} - {2} - {3} - {4}", Doctor, Pago, Mascota, Turno, Precio);
            }

            public void Mostrar()
            {
                string Acumulador = "";
                foreach (Veterinaria v in ListaV)
                {
                    Acumulador += v.ToString() + System.Environment.NewLine;   
                }
                Console.WriteLine(Acumulador);
            }
        }
    }
}
