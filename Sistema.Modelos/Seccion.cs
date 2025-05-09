using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class Seccion
    {
        [Key] public int Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        //KF
        public int EventoCodigo { get; set; }
        public int SalaCodigo { get; set; }
        //navegacion
        public Evento? Eventos { get; set; }
        public Sala? Salas { get; set; }
    }
}
