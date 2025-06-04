using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGarcia_IEFI
{
    public class clsUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Contraseña { get; set; }
        public string Area { get; set; }
        public bool Activo { get; set; }
        public string NombreUsuario { get; set; }

        public int IdAuditoriaSesion { get; set; }
        
        public DateTime FechaAcceso { get; set; }

    }
}
