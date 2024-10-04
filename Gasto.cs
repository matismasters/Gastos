using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingFungi
{
    public class Gasto
    {
        private static int UltimoId = 0;

        public int IdGasto { get; set; }

        public string Razon { get; set; }

        public float Precio { get; set; }

        public DateTime Fecha { get; set; }

        public Socio Socio { get; set; }

        public Cosecha Cosecha { get; set; }

        public Gasto(string razon, float precio, Socio socio, Cosecha cosecha)
        {
            this.IdGasto = NuevoId();
            this.Razon = razon;
            this.Precio = precio;
            this.Fecha = DateTime.Now;
            this.Socio = socio;
            this.Cosecha = cosecha;
        }

        private static int NuevoId()
        {
            return UltimoId++;
        }
    }
}
