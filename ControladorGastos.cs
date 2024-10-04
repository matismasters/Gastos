using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingFungi
{
    public class ControladorGastos
    {
        public List<Gasto> Gastos { get; set; }

        public ControladorGastos()
        {
            this.Gastos = new List<Gasto>();
        }

        public Gasto AgregarGasto()
        {
            Gasto gasto = VistaAgregarGasto.PedirDatos();
            this.Gastos.Add(gasto);
            return gasto;
        }

        public void MostrarGastos()
        {
            VistaMostrarGastos.MostrarGastos(this.Gastos);
        }

        public Gasto? BuscarGastoPorId(int idGasto)
        {
            foreach (Gasto gasto in this.Gastos)
            {
                if (gasto.IdGasto == idGasto)
                {
                    return gasto;
                }
            }

            return null;

            //return this.Gastos.Find(g => g.IdGasto == idGasto);
        }

        public bool EliminarGasto()
        {
            VistaMostrarGastos.MostrarGastos(this.Gastos);

            Console.WriteLine("Ingrese el ID del gasto a eliminar:");
            int idGasto = int.Parse(Console.ReadLine() ?? string.Empty);

            Gasto? gasto = this.BuscarGastoPorId(idGasto);
            if (gasto != null)
            {
                this.Gastos.Remove(gasto);
                return true;
            }

            return false;
        }
    }
}
