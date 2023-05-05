using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CPEjercicio01_Judith
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora com = new Computadora();
            char resp;
            com.Encendido();
            Console.WriteLine("Ingrese la capacidad del disco duro: ");
            com.Capacidad = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Desea agregar un dato: ");
                resp = char.Parse(Console.ReadLine());
                if (resp == 's' || resp == 'S')
                {
                    Console.WriteLine("Ingrese un dato: ");
                    int datos = int.Parse(Console.ReadLine());
                    com.AddDato(datos);
                }
                else
                {
                    Console.WriteLine("La opcion ingresada es invalida...");
                }
            } while (resp != 's' || resp != 's');

            Console.WriteLine("Desea eliminar un dato: ");
            resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {

                com.Eliminardato();
            }
            else
            {
                Console.WriteLine("La opcion ingresada es invalida...");
            }
            com.Apagado();

            Console.ReadKey();
        }
    }
}
