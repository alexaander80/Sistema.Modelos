using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class Sala
    {
        [Key]public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }

        //KF

        //navegacion
        
    }
}
