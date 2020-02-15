using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Dto
{
    public class LibroDto
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public int IdEditorial { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioSugerido { get; set; }
        public string Autor { get; set; }

        // 
        public EditorialDto Editorial { get; set; }
    }
    public class LibroCreateForm
    {
        public string Titulo { get; set; }
        public int IdEditorial { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioSugerido { get; set; }
        public string Autor { get; set; }
        
    }
}
