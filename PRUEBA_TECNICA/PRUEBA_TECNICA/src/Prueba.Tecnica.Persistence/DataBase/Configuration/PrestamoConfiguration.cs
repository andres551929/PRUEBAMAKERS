using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Tecnica.Domain.Entities.Prestamo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Tecnica.Persistence.DataBase.Configuration
{
    public class PrestamoConfiguration
    {
        public PrestamoConfiguration(EntityTypeBuilder<PrestamoEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.PRES_ID);
            entityBuilder.Property(x => x.CLIE_ID).IsRequired();
            entityBuilder.Property(x => x.PRES_CANTIDAD).IsRequired();
  


 

        }
    }
}
