using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Dto
{
    public class EditorialDto
    {
        public int IdEditorial { get; set; }
        public string Nombre { get; set; }

        public List<LibroDto> Libros { get; set; }
    }
}
