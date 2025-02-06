using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFinal.Modelos
{
    public class Equipo_Models
    {       
        public int Id { get; set; }
        public int ID { get; internal set; }
        public string Name { get; set; }    
        public string Ciudad { get; set; }
        public string Nombre { get; internal set; }
    }
}
