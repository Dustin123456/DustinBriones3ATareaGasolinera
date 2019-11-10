using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaGasolinera.Clases;

namespace TareaGasolinera
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente suCliente;
            suCliente = new Cliente();
            Console.WriteLine(" BIENVENIDO A LA APLICACION ");
            Console.WriteLine("Ingrese los apellidos del cliente.");
            suCliente.Apellidos = (Console.ReadLine());
            Console.WriteLine("Ingrese los nombres del cliente.");
            suCliente.Nombres = (Console.ReadLine());
            Console.WriteLine("Ingrese el numero de cedula del cliente.");
            suCliente.NumeroDeCedula = (Console.ReadLine());
            Console.WriteLine("Ingrese la direccion del cliente.");
            suCliente.Direccion = (Console.ReadLine());


            Gasolina suGasolina;
            suGasolina = new Gasolina();
            Console.WriteLine("Ingrese que tipo de gasolina desea(Extra o Super).");
            suGasolina.Tipo = (Console.ReadLine());
            
            int sisa = 1;
            do
            {
                Console.WriteLine("Ingrese 1 si escogió Extra o ingrese 2 si escogió Super.");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    suGasolina.Precio = 1.5;
                    sisa = 0;
                }
                else if (opcion == 2)
                {
                    suGasolina.Precio = 2.00;
                    sisa = 0;
                }
                else Console.WriteLine(" Error. Ingrese una de las dos opciones indicadas.");
            } while (sisa==1);       
            Console.WriteLine();
            Console.WriteLine("Ingrese cuantos galones de gasolina desea el cliente.");
            suGasolina.CantidadDeGalones = int.Parse(Console.ReadLine());



            Console.WriteLine("El cliente correspondiente a los siguientes datos:");
            Console.WriteLine(suCliente.Apellidos);
            Console.WriteLine(suCliente.Nombres);
            Console.WriteLine("Identificacion: "+suCliente.NumeroDeCedula);
            Console.WriteLine(suCliente.Direccion);
            Console.WriteLine("Ha hecho la siguiente compra:");
            Console.WriteLine("Gasolina: "+suGasolina.Tipo+".");
            Console.WriteLine("Precio de galon: "+suGasolina.Precio+"$.");
            Console.WriteLine("Galones: "+suGasolina.CantidadDeGalones+".");
            Console.WriteLine("Por lo tanto sus valores a pagar son:");
            Console.WriteLine("Subtotal: "+suGasolina.SubTotal());
            Console.WriteLine("IVA: "+suGasolina.IVA());
            Console.WriteLine("Total: "+suGasolina.Total());
            Console.ReadKey();

        }
    }
}
