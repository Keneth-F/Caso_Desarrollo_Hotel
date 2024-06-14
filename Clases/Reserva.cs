using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_Desarrollo_Hotel.Clases
{
    public class Reserva
    {
        public string Id { get; set; }
        public string ClienteId { get; set; }
        public string HabitacionId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }
    }
}
