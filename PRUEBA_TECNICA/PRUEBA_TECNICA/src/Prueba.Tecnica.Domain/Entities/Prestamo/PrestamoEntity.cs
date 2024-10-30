using Prueba.Tecnica.Domain.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Tecnica.Domain.Entities.Prestamo
{
    public class PrestamoEntity
    {
        public int PRES_ID { get; set; }

        public int CLIE_ID { get; set; }
        public double PRES_CANTIDAD { get; set; }


    }
}
