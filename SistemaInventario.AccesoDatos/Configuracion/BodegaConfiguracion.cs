﻿using Microsoft.EntityFrameworkCore;
using SistemaInventario.Modelos;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.NewFolder
{
    public class BodegaConfiguracion : IEntityTypeConfiguration <Bodega>
    {
        public void Configure(EntityTypeBuilder<Bodega> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(60);
            builder.Property(x=> x.Descripcion).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Estado).IsRequired();

        }
    }
}
