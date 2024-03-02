using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        public int Id { get; set; } 
        
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        
        [DisplayName("Cantidad de Canciones")]
        public int CantidadDeCanciones { get; set; }
        public string UrlTapa {  get; set; }

        public Genero Genero { get; set; }

        [DisplayName("Edición")]
        public Edicion Edicion { get; set; }

        public override string ToString()
        {
            return Titulo;
        }

    }

}
