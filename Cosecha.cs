using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingFungi
{
    public class Cosecha
    {
        public int IdCosecha { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public List<Gasto> Gastos { get; set; }

        public Cosecha()
        {
            this.FechaInicio = DateTime.Now;
            this.Gastos = new List<Gasto>();
        }
    }
}
