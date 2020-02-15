using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelos.Dao;

namespace Persistencia.Config
{
    public class LibroConfig
    {
        public LibroConfig(EntityTypeBuilder<Libro> entityBuilder)
        {

            entityBuilder.HasKey(x => x.IdLibro);

            entityBuilder.Property(x => x.Titulo).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.IdEditorial).IsRequired();
            entityBuilder.Property(x => x.Fecha).IsRequired().HasColumnType("date");
            entityBuilder.Property(x => x.Costo).HasColumnType("decimal(10,2)").IsRequired();
            entityBuilder.Property(x => x.PrecioSugerido).HasColumnType("decimal(10,2)").IsRequired();
            entityBuilder.Property(x => x.Autor).IsRequired().HasMaxLength(500);

            entityBuilder.HasOne(x => x.Editorial)
                .WithMany(x => x.Libros).IsRequired();
        }
    }
}
