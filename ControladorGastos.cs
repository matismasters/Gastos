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
            return gasto;
        }
    }
}
