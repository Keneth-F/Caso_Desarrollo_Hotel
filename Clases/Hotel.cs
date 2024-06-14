using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_Desarrollo_Hotel.Clases
{
    public class Hotel
    {
        public Hotel(string id, string nombre, string direccion, string ciudad, string pais, int estrellas)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Ciudad = ciudad;
            Pais = pais;
            Estrellas = estrellas;
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public int Estrellas { get; set; }
        public List<Habitacion> Habitaciones { get; set; }= new List<Habitacion>();
    }
}
