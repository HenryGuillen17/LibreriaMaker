using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Dao
{
    public class Editorial
    {
        public int IdEditorial { get; set; }
        public string Nombre { get; set; }

        public List<Libro> Libros { get; set; }
    }
}
