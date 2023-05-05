using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//3.Crea una clase Computadora con los siguientes atributos:
//– Capacidad disco(GB)
//-Espacio Disponible(GB)
//– encendido: booleano
//Los métodos a añadir son:
//– aniadirDatos(int datos): añade información al disco duro, si supera el espacio disponible del disco, el tamaño del disco será el máximo posible. Solo si esta encendida la Computadora.
//– eliminarDatos(int datos): elimina información al disco duro, si el tamaño del disco es menor que 0, el tamaño del disco se quedara a 0. Solo si esta encendida la Computadora.
//– encender(): enciende la Computadora y muestra un mensaje en pantalla de Bienvenida.
//– apagar(): apaga la Computadora y muestra un mensaje en pantalla de despedida
//— Computadora : Constructor.
namespace CPEjercicio01_Judith
{
    class Computadora
    {
        int capacidad;
        int disponible;
        bool estado;
        public Computadora() { }

        public Computadora(int capacidad, int disponible, bool estado)
        {
            this.capacidad = capacidad;
            this.disponible = disponible;
            this.estado = estado;
        }

        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Disponible { get => disponible; set => disponible = value; }
        public bool Estado { get => estado; set => estado = value; }

        public void AddDato(int datos)
        {
            if (this.Capacidad != 0 && estado == true)
            {

                if (datos <= this.capacidad)
                {
                    Console.WriteLine("Dato agregado correctamente...");
                    this.Disponible = this.Capacidad - datos;
                }
                else
                {
                    Console.WriteLine("ERROR: El dato ingresado excede la disponibilidad del disco duro...");
                }
            }

            else
            {
                Console.WriteLine("No hay espacio disponible para agregar el dato...");
            }
        }
        public void Eliminardato()
        {
            Console.WriteLine("¿Esta segur@ que desea eliminar un dato?: S/N");
            string resp = Console.ReadLine();
            if (resp == "S" || resp == "s")
            {
                this.disponible = this.capacidad;
            }
            else
            {
                Console.WriteLine("\t\t\tOperacion cancelada...");
            }
        }

        public void Encendido()
        {
            this.estado = true;
            Console.WriteLine("\tComputadora Encendida\n\t\tBienevenid@");
        }
        public void Apagado()
        {
            Console.WriteLine("¿Esta segur@ que desea apagar lacomputadora?: S/N");
            string resp = Console.ReadLine();
            if (resp == "S" || resp == "s")
            {
                this.estado = false;
                Console.WriteLine("\tComputadora Apagada\n\t\tHasta luego");
            }
            else
            {
                Console.WriteLine("\t\t\tOperacion cancelada...");
            }
        }
    }
}

