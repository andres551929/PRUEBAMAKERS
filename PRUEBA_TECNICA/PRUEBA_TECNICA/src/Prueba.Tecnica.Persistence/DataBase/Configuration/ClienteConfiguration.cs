using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Tecnica.Domain.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Tecnica.Persistence.DataBase.Configuration
{
    public class ClienteConfiguration
    {
        public ClienteConfiguration(EntityTypeBuilder<ClienteEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.CLIE_ID);
            entityBuilder.Property(x => x.CLIE_NOMBRE).IsRequired();

        }
    }
}
