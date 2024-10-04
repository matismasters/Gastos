using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingFungi
{
    public class VistaMostrarGastos
    {
        public static void MostrarGastos(List<Gasto> gastos)
        {
            Console.WriteLine("(ID) \t $ \t Razon");
            Console.WriteLine("------------------");
            foreach (Gasto gasto in gastos)
            {
                Console.WriteLine($"({gasto.IdGasto}) \t {gasto.Precio} \t {gasto.Razon}");
            }
            Console.WriteLine("------------------");
        }
    }
}
