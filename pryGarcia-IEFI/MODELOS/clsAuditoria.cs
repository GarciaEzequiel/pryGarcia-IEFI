using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGarcia_IEFI.MODELOS
{
    public class clsAuditoria
    {
        public int IdAuditoria { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public int TiempoUso { get; set; }
    }
}
