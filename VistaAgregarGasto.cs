using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingFungi
{
    public class VistaAgregarGasto
    {
        public static Gasto PedirDatos()
        {
            Console.WriteLine("Ingrese la razon del gasto:");
            string razon = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del gasto:");
            float precio = float.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el nombre del socio:");
            //string nombreSocio = Console.ReadLine();
            //Socio socio = new Socio(nombreSocio);

            //Console.WriteLine("Ingrese el codigo de la cosecha:");
            //string codigoCosecha = Console.ReadLine();
            //Cosecha cosecha = new Cosecha(codigoCosecha);

            Console.WriteLine("Agregado exitosamente!");

            return new Gasto(razon, precio, null, null);
        }
    }
}
