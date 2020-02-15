using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Dao
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public int IdEditorial { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioSugerido { get; set; }
        public string Autor { get; set; }

        // 
        public Editorial Editorial { get; set; }
    }
}
