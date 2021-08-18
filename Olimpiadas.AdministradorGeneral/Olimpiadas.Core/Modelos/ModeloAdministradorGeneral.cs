using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Representa un modelo datos para un usuario con los permisos de un administrador general.
    /// </summary>
    public class ModeloAdministradorGeneral : ModeloBase
    {
        /// <summary>
        /// Usuario con los permisos de administrador general.
        /// </summary>
        public TIUsuarioAdministradorGeneral UsuarioAdministradorGeneral { get; set; }

        /// <summary>
        /// Configuracion red del servidor.
        /// </summary>
        public TIAdministradorGeneralConfiguracionRed ConfiguracionRed { get; set; }

        /// <summary>
        /// Sucursales administradas por el administrador general.
        /// </summary>
        public List<TIAdministradorGeneralSucursal> SucursalesAdministradas { get; set; } = new List<TIAdministradorGeneralSucursal>();

    }
}
