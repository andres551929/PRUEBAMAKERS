using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Tecnica.Domain.Entities.PrestamoEstadoPrestamo
{
    public class PrestamoEstadoPrestamo
    {
        public int PREP_ID { get; set; }

        public int PRES_ID { get; set; }
        public int ESPR_ID { get; set; }
        public DateTime PREP_FECHAESTADO { get; set; }
        public int PREP_REGISTRADOPOR { get; set; }

    }
}
