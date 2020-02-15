using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelos.Dao;

namespace Persistencia.Config
{
    public class EditorialConfig
    {
        public EditorialConfig(EntityTypeBuilder<Editorial> entityBuilder)
        {

            entityBuilder.HasKey(x => x.IdEditorial);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(20);


        }
    }
}
