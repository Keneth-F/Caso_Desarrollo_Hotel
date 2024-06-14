using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_Desarrollo_Hotel.Clases
{
    public class Factura
    {
        public string Id { get; set; }
        public string ReservaId { get; set; }
        public string ClienteId { get; set; }
        public string EmpleadoId { get; set; }
        public double Monto { get; set; }
        public DateTime FechaEmision { get; set; }
    }
}
