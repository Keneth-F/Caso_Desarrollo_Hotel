using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_Desarrollo_Hotel.Clases
{
    public class Habitacion
    {
        public string Id { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public double Precio { get; set; }
        public string HotelId { get; set; }
    }
}
