using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_Desarrollo_Hotel.Clases
{
    public class Pago
    {
        public string Id { get; set; }
        public string ReservaId { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
    }
}
