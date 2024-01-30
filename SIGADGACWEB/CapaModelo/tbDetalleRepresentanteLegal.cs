using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
   public class tbDetalleRepresentanteLegal
    {
        public string CodigoUsuario { get; set; }
        public decimal OidCiaAviacion { get; set; }
        public string NombreCompania { get; set; }
        public string NombreRepresentante { get; set; }
        public string PathArchivo { get; set; }
        public string EstadoRepresentante { get; set; }
        public string UsuarioCreado { get; set; }
        public string FechaCreado { get; set; }
        public string HoraCreado { get; set; }
        public string UsuarioModificado { get; set; }
        public string FechaModificado { get; set; }
        public string HoraModificado { get; set; }
    }
}
