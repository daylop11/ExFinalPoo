using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFinal.Modelos
{
    public class Jugador_Models
    {
        public int id { get; set; }
        public int ID { get; internal set; }
        public string name { get; set; }
        public string posicion { get; set; }
        public string Posicion { get; internal set; }
        public int id_Equipo { get; set; }
        public int? ID_Equipo { get; internal set; }
        public string Nombre { get; internal set; }
    }
}
