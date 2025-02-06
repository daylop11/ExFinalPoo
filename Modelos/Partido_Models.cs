using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExFinal.Modelos
{
    public class Partido_Models
    {
        public int id { get; set; }
        public int id_Equipo1 { get; set; }
        public int id_Equipo2 { get; set; }
        public string Fecha { get; set; }
        public string Resultado { get; set; }
        public string NombreEquipo { get; set; }
        public string NombreEquipo2 { get; set; }
    }
    }
